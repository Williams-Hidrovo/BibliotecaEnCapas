namespace BibliotecaenCapas
{
    partial class Usuarios
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
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            txtFiltro = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(637, 375);
            dataGridView1.TabIndex = 0;
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
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtFiltro.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFiltro.Location = new Point(139, 488);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(154, 33);
            txtFiltro.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(253, 133, 73);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(12, 487);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(121, 34);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 60, 76);
            ClientSize = new Size(933, 587);
            Controls.Add(txtFiltro);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGuardar;
        private TextBox txtFiltro;
        private Button btnBuscar;
    }
}