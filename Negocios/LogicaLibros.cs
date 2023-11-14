using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class LogicaLibros
    {
        private readonly DatosLibros datos;

        public LogicaLibros()
        {
            datos = new DatosLibros();
        }

        public DataTable ObtenerDatos(string filtro="")
        {
            try
            {
                // Llamar a la capa de datos para obtener los datos
                return datos.ObtenerDatos(filtro);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la capa de negocios: {ex.Message}");
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

        public Libro ConsultarUsuarioPorId(int id)
        {
            return datos.ConsultarPorID(id);
        }

        public List<Libro> ObtenerTodosLibros()
        {
            return datos.ObtenerTodosIDS();
        }

    }
}
