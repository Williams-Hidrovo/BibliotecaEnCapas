using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosLibros
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
                    where = $"WHERE titulo LIKE @condicion OR autor LIKE @condicion OR year LIKE @condicion OR id LIKE @condicion";
                }
                string consulta = "SELECT * FROM libro" + " " + where;
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                adaptador = new MySqlDataAdapter(comando);
                adaptador.SelectCommand.Parameters.AddWithValue("@condicion","%" + condicion + "%");
                MySqlCommandBuilder constructorComandos = new MySqlCommandBuilder(adaptador);
                dataTable = new DataTable();
                adaptador.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron libros con este valor", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                return dataTable;
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la capa de datos libros: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
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
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
        }

        public Libro ConsultarPorID(int id)
        {
            try
            {
                conexion.Open();

                string consulta = $"SELECT * FROM libro WHERE id = {id}";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);


                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataTable dataTable = new DataTable();
                adaptador.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    Libro libro = new Libro
                    {
                        titulo = dataTable.Rows[0]["titulo"].ToString(),
                        // Agrega otras propiedades según tu estructura de tabla
                        autor = dataTable.Rows[0]["autor"].ToString()
                    };

                    return libro;

                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conexion.Close(); }

            return null;
        }

        public List<Libro> ObtenerTodosIDS()
        {
            try
            {

                conexion.Open();

                string consulta = "SELECT * FROM libro";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.Fill(dataTable);

                        List<Libro> libros = new List<Libro>();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Libro libro = new Libro
                            {
                                id = Int32.Parse(row["id"].ToString()),
                                titulo = row["titulo"].ToString()
                            };

                            libros.Add(libro);
                        }

                        return libros;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }

    public class Libro
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
    }
}

