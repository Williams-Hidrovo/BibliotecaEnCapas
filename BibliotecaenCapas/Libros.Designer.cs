namespace BibliotecaenCapas
{
    partial class Libros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            btnGuardar = new Button();
            button1 = new Button();
            txtFiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(597, 375);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(656, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(253, 133, 73);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(488, 487);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(253, 133, 73);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 487);
            button1.Name = "button1";
            button1.Size = new Size(121, 34);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtFiltro.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFiltro.Location = new Point(139, 488);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(154, 33);
            txtFiltro.TabIndex = 4;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 60, 76);
            ClientSize = new Size(917, 589);
            Controls.Add(txtFiltro);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Libros";
            Text = "Libros";
            Load += Libros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button btnGuardar;
        private Button button1;
        private TextBox txtFiltro;
    }
}