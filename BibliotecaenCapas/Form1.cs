namespace BibliotecaenCapas
{
    public partial class Form1 : Form
    {
        private bool restaurar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1A_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!restaurar)
            {
                this.WindowState = FormWindowState.Maximized;
                restaurar = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                restaurar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Libros());
        }

        private void AbrirFormulario(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Usuarios());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Prestamos());
        }
    }
}