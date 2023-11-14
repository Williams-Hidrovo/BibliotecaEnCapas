using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class LogicaUsuarios
    {
        private readonly DatosUsuarios datos;

        public LogicaUsuarios()
        {
            datos = new DatosUsuarios();

        }

        public DataTable ObtenerDatos(string filtro="")
        {
            try
            {
                // Llamar a la capa de datos para obtenerlos
                return datos.ObtenerDatos(filtro);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la capa de Logica Usuarios: {ex.Message}");
            }
        }

        public void GuardarDatos()
        {
            try
            {
                datos.GuardarCambios();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la capa de negocios: {ex.Message}");
            }
        }

        public Usuario ConsultarUsuarioPorCondicion(int id)
        {
            return datos.ConsultarPorID(id);
        }

        public List<Usuario> ObtenerTodosUsuarios()
        {
            return datos.ObtenerTodosIDS();
        }



    }
}
