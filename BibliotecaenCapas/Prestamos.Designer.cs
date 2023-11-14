namespace BibliotecaenCapas
{
    partial class Prestamos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbbUsuarios = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbbLibros = new ComboBox();
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
            dataGridView1.Size = new Size(636, 375);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellValidating += DataGridView1_CellValidating;
            dataGridView1.RowPrePaint += DataGridView1_RowPrePaint;
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
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(670, 93);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 4;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(670, 159);
            label2.Name = "label2";
            label2.Size = new Size(244, 32);
            label2.TabIndex = 5;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(670, 222);
            label3.Name = "label3";
            label3.Size = new Size(244, 32);
            label3.TabIndex = 6;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbUsuarios
            // 
            cbbUsuarios.FormattingEnabled = true;
            cbbUsuarios.Location = new Point(670, 365);
            cbbUsuarios.Name = "cbbUsuarios";
            cbbUsuarios.Size = new Size(244, 23);
            cbbUsuarios.TabIndex = 7;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(670, 319);
            label4.Name = "label4";
            label4.Size = new Size(244, 32);
            label4.TabIndex = 8;
            label4.Text = "IDS de Usuarios";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(670, 415);
            label5.Name = "label5";
            label5.Size = new Size(244, 32);
            label5.TabIndex = 10;
            label5.Text = "IDS de Libros";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbLibros
            // 
            cbbLibros.FormattingEnabled = true;
            cbbLibros.Location = new Point(670, 461);
            cbbLibros.Name = "cbbLibros";
            cbbLibros.Size = new Size(244, 23);
            cbbLibros.TabIndex = 9;
            // 
            // txtFiltro
            // 
            txtFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtFiltro.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFiltro.Location = new Point(139, 488);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(154, 33);
            txtFiltro.TabIndex = 12;
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
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 60, 76);
            ClientSize = new Size(926, 579);
            Controls.Add(txtFiltro);
            Controls.Add(btnBuscar);
            Controls.Add(label5);
            Controls.Add(cbbLibros);
            Controls.Add(label4);
            Controls.Add(cbbUsuarios);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prestamos";
            Text = "Prestamos";
            Load += Prestamos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbUsuarios;
        private Label label4;
        private Label label5;
        private ComboBox cbbLibros;
        private TextBox txtFiltro;
        private Button btnBuscar;
    }
}