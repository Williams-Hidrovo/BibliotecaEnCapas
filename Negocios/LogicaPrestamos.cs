using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class LogicaPrestamos
    {
        private readonly DatosPrestamos datos;

        public LogicaPrestamos()
        {
            datos = new DatosPrestamos();
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
                throw new Exception($"Error en la capa de LogicaPrestamos: {ex.Message}");
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

        
    }
}
