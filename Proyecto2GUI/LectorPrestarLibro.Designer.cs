namespace Proyecto2GUI
{
    partial class LectorPrestarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LectorPrestarLibro));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            btnBuscarLibro = new Button();
            RecibirBuscar = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            lblRecibirDisponibilidad = new Label();
            label9 = new Label();
            lblRecibirGenero = new Label();
            label7 = new Label();
            lblRecibirAutor = new Label();
            label5 = new Label();
            lblRecibirTitulo = new Label();
            label3 = new Label();
            btnSolicitarLibro = new Button();
            lblMensajeUsuario = new Label();
            datosLibros = new DataGridView();
            ISBN = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Disponibilidad = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosLibros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Aston Script Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 87);
            label1.TabIndex = 12;
            label1.Text = "Prestar Libro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscarLibro
            // 
            btnBuscarLibro.BackColor = Color.FromArgb(230, 165, 36);
            btnBuscarLibro.Cursor = Cursors.Hand;
            btnBuscarLibro.FlatAppearance.BorderSize = 0;
            btnBuscarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnBuscarLibro.FlatStyle = FlatStyle.Flat;
            btnBuscarLibro.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnBuscarLibro.Image = (Image)resources.GetObject("btnBuscarLibro.Image");
            btnBuscarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarLibro.Location = new Point(740, 33);
            btnBuscarLibro.Name = "btnBuscarLibro";
            btnBuscarLibro.Size = new Size(146, 40);
            btnBuscarLibro.TabIndex = 11;
            btnBuscarLibro.Text = "Buscar Libro";
            btnBuscarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarLibro.UseVisualStyleBackColor = false;
            btnBuscarLibro.Click += btnBuscarLibro_Click;
            // 
            // RecibirBuscar
            // 
            RecibirBuscar.BorderStyle = BorderStyle.None;
            RecibirBuscar.Cursor = Cursors.IBeam;
            RecibirBuscar.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecibirBuscar.Location = new Point(269, 40);
            RecibirBuscar.Name = "RecibirBuscar";
            RecibirBuscar.Size = new Size(440, 27);
            RecibirBuscar.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label2.Location = new Point(189, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 27);
            label2.TabIndex = 0;
            label2.Text = "ISBN:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRecibirDisponibilidad);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblRecibirGenero);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblRecibirAutor);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblRecibirTitulo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnSolicitarLibro);
            panel1.Controls.Add(btnBuscarLibro);
            panel1.Controls.Add(RecibirBuscar);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 202);
            panel1.TabIndex = 13;
            // 
            // lblRecibirDisponibilidad
            // 
            lblRecibirDisponibilidad.AutoSize = true;
            lblRecibirDisponibilidad.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirDisponibilidad.Location = new Point(390, 162);
            lblRecibirDisponibilidad.Name = "lblRecibirDisponibilidad";
            lblRecibirDisponibilidad.Size = new Size(27, 27);
            lblRecibirDisponibilidad.TabIndex = 33;
            lblRecibirDisponibilidad.Text = "D";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label9.Location = new Point(269, 162);
            label9.Name = "label9";
            label9.Size = new Size(115, 27);
            label9.TabIndex = 32;
            label9.Text = "Disponible:";
            // 
            // lblRecibirGenero
            // 
            lblRecibirGenero.AutoSize = true;
            lblRecibirGenero.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirGenero.Location = new Point(360, 133);
            lblRecibirGenero.Name = "lblRecibirGenero";
            lblRecibirGenero.Size = new Size(26, 27);
            lblRecibirGenero.TabIndex = 31;
            lblRecibirGenero.Text = "G";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label7.Location = new Point(269, 133);
            label7.Name = "label7";
            label7.Size = new Size(85, 27);
            label7.TabIndex = 30;
            label7.Text = "Genero:";
            // 
            // lblRecibirAutor
            // 
            lblRecibirAutor.AutoSize = true;
            lblRecibirAutor.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirAutor.Location = new Point(346, 106);
            lblRecibirAutor.Name = "lblRecibirAutor";
            lblRecibirAutor.Size = new Size(26, 27);
            lblRecibirAutor.TabIndex = 29;
            lblRecibirAutor.Text = "A";
            lblRecibirAutor.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(269, 104);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 28;
            label5.Text = "Autor:";
            // 
            // lblRecibirTitulo
            // 
            lblRecibirTitulo.AutoSize = true;
            lblRecibirTitulo.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirTitulo.Location = new Point(346, 77);
            lblRecibirTitulo.Name = "lblRecibirTitulo";
            lblRecibirTitulo.Size = new Size(24, 27);
            lblRecibirTitulo.TabIndex = 27;
            lblRecibirTitulo.Text = "T";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label3.Location = new Point(269, 77);
            label3.Name = "label3";
            label3.Size = new Size(71, 27);
            label3.TabIndex = 26;
            label3.Text = "Titulo:";
            // 
            // btnSolicitarLibro
            // 
            btnSolicitarLibro.BackColor = Color.FromArgb(230, 165, 36);
            btnSolicitarLibro.Cursor = Cursors.Hand;
            btnSolicitarLibro.FlatAppearance.BorderSize = 0;
            btnSolicitarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnSolicitarLibro.FlatStyle = FlatStyle.Flat;
            btnSolicitarLibro.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnSolicitarLibro.Image = (Image)resources.GetObject("btnSolicitarLibro.Image");
            btnSolicitarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnSolicitarLibro.Location = new Point(740, 111);
            btnSolicitarLibro.Name = "btnSolicitarLibro";
            btnSolicitarLibro.Size = new Size(146, 40);
            btnSolicitarLibro.TabIndex = 12;
            btnSolicitarLibro.Text = "Solicitar Libro";
            btnSolicitarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnSolicitarLibro.UseVisualStyleBackColor = false;
            btnSolicitarLibro.Click += btnSolicitarLibro_Click;
            // 
            // lblMensajeUsuario
            // 
            lblMensajeUsuario.Dock = DockStyle.Bottom;
            lblMensajeUsuario.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeUsuario.ForeColor = Color.Goldenrod;
            lblMensajeUsuario.Location = new Point(0, 517);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 36);
            lblMensajeUsuario.TabIndex = 25;
            lblMensajeUsuario.Text = "Mensaje";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datosLibros
            // 
            datosLibros.AllowUserToAddRows = false;
            datosLibros.AllowUserToDeleteRows = false;
            datosLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datosLibros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datosLibros.BackgroundColor = SystemColors.Control;
            datosLibros.BorderStyle = BorderStyle.None;
            datosLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 53, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(184, 149, 93);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datosLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datosLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosLibros.Columns.AddRange(new DataGridViewColumn[] { ISBN, Titulo, Autor, Genero, Disponibilidad });
            datosLibros.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datosLibros.DefaultCellStyle = dataGridViewCellStyle2;
            datosLibros.EnableHeadersVisualStyles = false;
            datosLibros.GridColor = Color.FromArgb(49, 53, 56);
            datosLibros.Location = new Point(226, 301);
            datosLibros.Name = "datosLibros";
            datosLibros.ReadOnly = true;
            datosLibros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            datosLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            datosLibros.RowHeadersVisible = false;
            datosLibros.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Small", 10.2F);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 165, 36);
            datosLibros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            datosLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datosLibros.Size = new Size(592, 215);
            datosLibros.TabIndex = 26;
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.MinimumWidth = 6;
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            ISBN.Width = 85;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            Titulo.Width = 92;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 92;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 6;
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            Genero.Width = 107;
            // 
            // Disponibilidad
            // 
            Disponibilidad.HeaderText = "Disponibilidad";
            Disponibilidad.MinimumWidth = 6;
            Disponibilidad.Name = "Disponibilidad";
            Disponibilidad.ReadOnly = true;
            Disponibilidad.Width = 169;
            // 
            // LectorPrestarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(datosLibros);
            Controls.Add(lblMensajeUsuario);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "LectorPrestarLibro";
            Text = "LectorPrestarLibro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datosLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnBuscarLibro;
        private TextBox RecibirBuscar;
        private Label label2;
        private Panel panel1;
        private Button btnSolicitarLibro;
        private Label lblMensajeUsuario;
        private Label lblRecibirGenero;
        private Label label7;
        private Label lblRecibirAutor;
        private Label label5;
        private Label lblRecibirTitulo;
        private Label label3;
        private Label lblRecibirDisponibilidad;
        private Label label9;
        private DataGridView datosLibros;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Disponibilidad;
    }
}