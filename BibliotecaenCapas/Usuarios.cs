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

namespace BibliotecaenCapas
{
    public partial class Usuarios : Form
    {
        private readonly LogicaUsuarios negocio;
        public Usuarios()
        {
            InitializeComponent();
            negocio = new LogicaUsuarios();

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos desde la capa de negocios y mostrarlos en el DataGridView
                dataGridView1.DataSource = negocio.ObtenerDatos();
                //dataGridView1.Columns["Portada"].Visible = false;
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 200;

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
