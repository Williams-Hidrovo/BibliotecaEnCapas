using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosPrestamos
    {
        private MySqlDataAdapter adaptador;
        private DataTable dataTable;
        private MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=biblioteca;User ID=root;Password=;");
        public DataTable ObtenerDatos(string condicion = "")
        {
            string where = "";
            try
            {

                conexion.Open();
                if (condicion != "")
                {
                    where = $"WHERE id_usuario LIKE @condicion OR id_libro LIKE @condicion OR fecha_retiro LIKE @condicion OR fecha_entrega LIKE @condicion OR entregado LIKE @condicion";
                }
                string consulta = "SELECT * FROM prestamo" + " " + where;
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                adaptador = new MySqlDataAdapter(comando);
                adaptador.SelectCommand.Parameters.AddWithValue("@condicion", "%" + condicion + "%");
                MySqlCommandBuilder constructorComandos = new MySqlCommandBuilder(adaptador);
                dataTable = new DataTable();
                adaptador.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron prestamos con este valor", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la capa de datos Prestamos: {ex.Message}");
            }
            finally { conexion.Close(); }
        }

        public void GuardarCambios()
        {
            try
            {
                // Actualizar los cambios en la base de datos
                adaptador.Update(dataTable);
                MessageBox.Show("Cambios guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: El id usuario o libro no existe..");
            }
        }

       


    }

    
}
