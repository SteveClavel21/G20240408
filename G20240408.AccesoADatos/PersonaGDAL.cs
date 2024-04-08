using G20240408.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;

namespace G20240408.AccesoADatos
{
    public class PersonaGDAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaGDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public async Task<int> Crear(PersonaG personaG) {
            _appDbContext.Add(personaG);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaG personaG) {
            var personaData = await _appDbContext.PersonasG.FirstOrDefaultAsync(s => s.Id == personaG.Id);
            if (personaData != null)
            {
                personaData.NombreG = personaG.NombreG;
                personaData.ApellidoG = personaG.ApellidoG;
                personaData.FechaNacimientoG = personaG.FechaNacimientoG;
                personaData.SueldoG = personaG.SueldoG;
                personaData.EstatusG = personaG.EstatusG;
                _appDbContext.Update(personaData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaG personaG) {
            var personaData = await _appDbContext.PersonasG.FirstOrDefaultAsync(s => s.Id == personaG.Id);
            if (personaData != null)
                _appDbContext.Remove(personaData);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<PersonaG> ObtenerPorId(PersonaG personaG) {
            var personaData = await _appDbContext.PersonasG.FirstOrDefaultAsync(s => s.Id == personaG.Id);
            if (personaData != null)
                return personaData;
            else
                return new PersonaG();
        }
        public async Task<List<PersonaG>> ObtenerTodos() {
            return await _appDbContext.PersonasG.ToListAsync();
        }
        public async Task<List<PersonaG>> Buscar(PersonaG personaG) {

            var query = _appDbContext.PersonasG.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaG.NombreG))
            {
                query = query.Where(s => s.NombreG.Contains(personaG.NombreG));
            }
            if (!string.IsNullOrWhiteSpace(personaG.ApellidoG))
            {
                query = query.Where(s => s.ApellidoG.Contains(personaG.ApellidoG));
            }
            return await query.ToListAsync();
        }

    }
}
