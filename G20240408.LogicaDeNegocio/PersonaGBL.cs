using G20240408.AccesoADatos;
using G20240408.EntidadesDeNegocio;

namespace G20240408.LogicaDeNegocio
{
    public class PersonaGBL
    {
        readonly PersonaGDAL _personaGDAL;
        public PersonaGBL(PersonaGDAL personaGDAL)
        {
            _personaGDAL = personaGDAL;
        }

        public async Task<int> Crear(PersonaG personaG)
        {
            return await _personaGDAL.Crear(personaG);
        }
        public async Task<int> Modificar(PersonaG personaG)
        {
            return await _personaGDAL.Modificar(personaG);
        }
        public async Task<int> Eliminar(PersonaG personaG)
        {
            return await _personaGDAL.Eliminar(personaG);
        }
        public async Task<PersonaG> ObtenerPorId(PersonaG personaG)
        {
            return await _personaGDAL.ObtenerPorId(personaG);
        }
        public async Task<List<PersonaG>> ObtenerTodos()
        {
            return await _personaGDAL.ObtenerTodos();
        }
        public async Task<List<PersonaG>> Buscar(PersonaG personaG)
        {
            return await _personaGDAL.Buscar(personaG);
        }
    }
}
