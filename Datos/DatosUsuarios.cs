using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosUsuarios
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
                    where = $"WHERE nombre LIKE @condicion OR apellido LIKE @condicion OR id LIKE @condicion";
                }
                string consulta = "SELECT * FROM usuario" + " " + where;
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                adaptador = new MySqlDataAdapter(comando);
                adaptador.SelectCommand.Parameters.AddWithValue("@condicion", "%" + condicion + "%");
                MySqlCommandBuilder constructorComandos = new MySqlCommandBuilder(adaptador);
                dataTable = new DataTable();
                adaptador.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron usuarios con este valor", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la capa de datos: {ex.Message}");
            }
            finally { conexion.Close(); }
        }

        public void GuardarCambios()
        {
            try
            {
                adaptador.Update(dataTable);
                MessageBox.Show("Cambios guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
        }


        public Usuario ConsultarPorID(int id)
        {
            try
            {
                conexion.Open();

                string consulta = $"SELECT * FROM usuario WHERE id = {id}";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);


                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataTable dataTable = new DataTable();
                adaptador.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    Usuario usuario = new Usuario
                    {
                        Nombre = dataTable.Rows[0]["nombre"].ToString(),
                        Apellido = dataTable.Rows[0]["apellido"].ToString()
                    };

                    return usuario;

                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conexion.Close(); }

            return null;
        }


        public List<Usuario> ObtenerTodosIDS()
        {
            try
            {
                
                conexion.Open();

                string consulta = "SELECT * FROM usuario";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.Fill(dataTable);

                        List<Usuario> usuarios = new List<Usuario>();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Usuario usuario = new Usuario
                            {
                                id =Int32.Parse(row["id"].ToString()),
                                Nombre= row["nombre"].ToString()
                            };

                            usuarios.Add(usuario);
                        }

                        return usuarios;
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
    }
    public class Usuario
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }



    

   






