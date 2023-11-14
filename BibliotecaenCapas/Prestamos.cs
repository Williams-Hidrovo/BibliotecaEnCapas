using Datos;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BibliotecaenCapas
{
    public partial class Prestamos : Form
    {
        private readonly LogicaPrestamos negocio;
        private readonly LogicaUsuarios negocioUsuarios;
        private readonly LogicaLibros negocioLibros;

        public Prestamos()
        {
            InitializeComponent();
            negocio = new LogicaPrestamos();
            negocioUsuarios = new LogicaUsuarios();
            negocioLibros = new LogicaLibros();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = negocio.ObtenerDatos();
                CargarUsuariosEnListBox();
                CargarLibrosEnListBox();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error capa Presentacion Prestamos: {ex.Message}");
            }
        }

        private void DataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            bool valorBooleano = false;
            try
            {
                valorBooleano = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            }
            catch (Exception ex) { }



            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = valorBooleano ? Color.FromArgb(255, 165, 255, 134) : Color.FromArgb(255, 255, 155, 134);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                negocio.GuardarDatos();
                dataGridView1.Refresh();
                CargarUsuariosEnListBox();
                CargarLibrosEnListBox();
            }
            catch
            {
                MessageBox.Show("Estas tratando de guardar datos equivocados");
            }

        }

        private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                DateTime fecha;
                if (!DateTime.TryParse(e.FormattedValue.ToString(), out fecha))
                {
                    MessageBox.Show("Por favor, ingrese una fecha válida en el formato correcto.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idtext = "";
                if (e.RowIndex >= 0 && e.ColumnIndex == 1)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != null)
                    {
                        idtext = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    }
                    label1.Text = idtext;

                    Usuario usuario = negocioUsuarios.ConsultarUsuarioPorCondicion(Int32.Parse(idtext));

                    if (usuario != null)
                    {
                        label2.Text = usuario.Nombre;
                        label3.Text = usuario.Apellido;
                    }
                    else
                    {
                        label2.Text = "No se encontraron resultados.";
                    }


                }

                else if (e.RowIndex >= 0 && e.ColumnIndex == 2)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != null)
                    {
                        idtext = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    }
                    label1.Text = idtext;

                    Libro libro = negocioLibros.ConsultarUsuarioPorId(Int32.Parse(idtext));

                    if (libro != null)
                    {
                        label2.Text = libro.titulo;
                        label3.Text = libro.autor;
                    }
                    else
                    {
                        label2.Text = "No se encontraron resultados.";
                    }


                }
            }
            catch { }
        }

        private void CargarUsuariosEnListBox()
        {
            try
            {
                List<Usuario> usuarios = negocioUsuarios.ObtenerTodosUsuarios();

                // Limpia el ListBox antes de agregar los nuevos elementos
                cbbUsuarios.Items.Clear();

                foreach (Usuario usuario in usuarios)
                {
                    string dato = usuario.id + " " + usuario.Nombre;
                    cbbUsuarios.Items.Add(dato);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void CargarLibrosEnListBox()
        {
            try
            {
                List<Libro> libros = negocioLibros.ObtenerTodosLibros();

                // Limpia el ListBox antes de agregar los nuevos elementos
                cbbLibros.Items.Clear();

                foreach (Libro libro in libros)
                {
                    string dato = libro.id + " " + libro.titulo;
                    cbbLibros.Items.Add(dato);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libros: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string filtro = txtFiltro.Text;
            if (filtro != "")
            {
                dataGridView1.DataSource = negocio.ObtenerDatos(filtro);
                txtFiltro.Text = "";


            }
            else
            {
                dataGridView1.DataSource = negocio.ObtenerDatos();
            }
            if (dataGridView1.RowCount < 2)
            {
                dataGridView1.DataSource = negocio.ObtenerDatos();

            }
        }
    }
}
