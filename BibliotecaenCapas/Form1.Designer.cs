namespace BibliotecaenCapas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelContenedor = new Panel();
            pictureBox10 = new PictureBox();
            menuVertical = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            btnLibros = new Button();
            btnUsuarios = new Button();
            btnPrestamos = new Button();
            pictureBox3 = new PictureBox();
            barraTitulo = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(47, 60, 76);
            panelContenedor.Controls.Add(pictureBox10);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(257, 40);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1023, 680);
            panelContenedor.TabIndex = 8;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // pictureBox10
            // 
            pictureBox10.ErrorImage = (Image)resources.GetObject("pictureBox10.ErrorImage");
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(154, 170);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(616, 283);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.FromArgb(47, 60, 76);
            menuVertical.Controls.Add(panel3);
            menuVertical.Controls.Add(panel2);
            menuVertical.Controls.Add(panel1);
            menuVertical.Controls.Add(btnLibros);
            menuVertical.Controls.Add(btnUsuarios);
            menuVertical.Controls.Add(btnPrestamos);
            menuVertical.Controls.Add(pictureBox3);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 40);
            menuVertical.Margin = new Padding(4, 3, 4, 3);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(257, 680);
            menuVertical.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(253, 133, 73);
            panel3.Location = new Point(5, 195);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 43);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(253, 133, 73);
            panel2.Location = new Point(5, 123);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 43);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(253, 133, 73);
            panel1.Location = new Point(5, 54);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 43);
            panel1.TabIndex = 5;
            // 
            // btnLibros
            // 
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 133, 73);
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLibros.ForeColor = Color.White;
            btnLibros.Image = (Image)resources.GetObject("btnLibros.Image");
            btnLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibros.Location = new Point(12, 54);
            btnLibros.Margin = new Padding(4, 3, 4, 3);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(245, 43);
            btnLibros.TabIndex = 4;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 133, 73);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(12, 123);
            btnUsuarios.Margin = new Padding(4, 3, 4, 3);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(245, 43);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 133, 73);
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrestamos.ForeColor = Color.White;
            btnPrestamos.Image = (Image)resources.GetObject("btnPrestamos.Image");
            btnPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.Location = new Point(13, 195);
            btnPrestamos.Margin = new Padding(4, 3, 4, 3);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(245, 43);
            btnPrestamos.TabIndex = 2;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.UseVisualStyleBackColor = true;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 622);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(257, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(47, 60, 76);
            barraTitulo.Controls.Add(pictureBox1);
            barraTitulo.Controls.Add(pictureBox4);
            barraTitulo.Controls.Add(pictureBox5);
            barraTitulo.Controls.Add(pictureBox2);
            barraTitulo.Controls.Add(btnMinimizar);
            barraTitulo.Controls.Add(btnMaximizar);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Margin = new Padding(4, 3, 4, 3);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1280, 40);
            barraTitulo.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1174, 5);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1210, 5);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1247, 5);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 5);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(2468, 5);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(29, 29);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(2504, 5);
            btnMaximizar.Margin = new Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(29, 29);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(2541, 5);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 29);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelContenedor);
            Controls.Add(menuVertical);
            Controls.Add(barraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1A_Load;
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel menuVertical;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button btnLibros;
        private Button btnUsuarios;
        private Button btnPrestamos;
        private PictureBox pictureBox3;
        private Panel barraTitulo;
        private PictureBox pictureBox2;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnCerrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox10;
    }
}