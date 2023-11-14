using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaenCapas
{
    public partial class Libros : Form
    {
        private readonly LogicaLibros negocio;
        public Libros()
        {
            InitializeComponent();
            negocio = new LogicaLibros();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                string url = filaSeleccionada.Cells["portada"].Value.ToString();
                if (url == "") url = "https://heuft.com/upload/image/400x267/no_image_placeholder.png";
                pictureBox1.Image = DescargarImagen(url);
            }
        }

        private Image DescargarImagen(string url)
        {
            try
            {
                using (WebClient clienteWeb = new WebClient())
                {
                    byte[] bytes = clienteWeb.DownloadData(url);
                    using (var stream = new System.IO.MemoryStream(bytes))
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = negocio.ObtenerDatos();
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 150;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            negocio.GuardarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;
            if(filtro != "")
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
