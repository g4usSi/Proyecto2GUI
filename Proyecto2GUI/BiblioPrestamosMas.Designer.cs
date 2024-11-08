namespace Proyecto2GUI
{
    partial class BiblioPrestamosMas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioPrestamosMas));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            dataMasPrestados = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            datosLibrosBiblio = new DataGridView();
            LectorNombre = new DataGridViewTextBoxColumn();
            LibroPrestado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            FechaPrestamo = new DataGridViewTextBoxColumn();
            CantPrestamos = new DataGridViewTextBoxColumn();
            lblMensajeUsuario = new Label();
            btnOrdenarLibros = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMasPrestados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datosLibrosBiblio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Aston Script Bold", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 97);
            label1.TabIndex = 10;
            label1.Text = "Libros en la Biblioteca";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOrdenarLibros);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataMasPrestados);
            panel1.Controls.Add(datosLibrosBiblio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 417);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Aston Script Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(367, 222);
            label2.Name = "label2";
            label2.Size = new Size(248, 42);
            label2.TabIndex = 2;
            label2.Text = "Libros mas Prestados";
            // 
            // dataMasPrestados
            // 
            dataMasPrestados.AllowUserToAddRows = false;
            dataMasPrestados.AllowUserToDeleteRows = false;
            dataMasPrestados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataMasPrestados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataMasPrestados.BackgroundColor = SystemColors.Control;
            dataMasPrestados.BorderStyle = BorderStyle.None;
            dataMasPrestados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 53, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(184, 149, 93);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataMasPrestados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataMasPrestados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMasPrestados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5 });
            dataMasPrestados.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataMasPrestados.DefaultCellStyle = dataGridViewCellStyle2;
            dataMasPrestados.EnableHeadersVisualStyles = false;
            dataMasPrestados.GridColor = Color.FromArgb(49, 53, 56);
            dataMasPrestados.Location = new Point(286, 267);
            dataMasPrestados.Name = "dataMasPrestados";
            dataMasPrestados.ReadOnly = true;
            dataMasPrestados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataMasPrestados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataMasPrestados.RowHeadersVisible = false;
            dataMasPrestados.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Small", 10.2F);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataMasPrestados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataMasPrestados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataMasPrestados.Size = new Size(468, 147);
            dataMasPrestados.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 92;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Genero";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 107;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Cantidad Prestamos";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 203;
            // 
            // datosLibrosBiblio
            // 
            datosLibrosBiblio.AllowUserToAddRows = false;
            datosLibrosBiblio.AllowUserToDeleteRows = false;
            datosLibrosBiblio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datosLibrosBiblio.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datosLibrosBiblio.BackgroundColor = SystemColors.Control;
            datosLibrosBiblio.BorderStyle = BorderStyle.None;
            datosLibrosBiblio.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(49, 53, 56);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(184, 149, 93);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            datosLibrosBiblio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            datosLibrosBiblio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosLibrosBiblio.Columns.AddRange(new DataGridViewColumn[] { LectorNombre, LibroPrestado, Fecha, FechaPrestamo, CantPrestamos });
            datosLibrosBiblio.Cursor = Cursors.Hand;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            datosLibrosBiblio.DefaultCellStyle = dataGridViewCellStyle6;
            datosLibrosBiblio.EnableHeadersVisualStyles = false;
            datosLibrosBiblio.GridColor = Color.FromArgb(49, 53, 56);
            datosLibrosBiblio.Location = new Point(171, 0);
            datosLibrosBiblio.Name = "datosLibrosBiblio";
            datosLibrosBiblio.ReadOnly = true;
            datosLibrosBiblio.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            datosLibrosBiblio.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            datosLibrosBiblio.RowHeadersVisible = false;
            datosLibrosBiblio.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Variable Small", 10.2F);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(230, 165, 36);
            datosLibrosBiblio.RowsDefaultCellStyle = dataGridViewCellStyle8;
            datosLibrosBiblio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datosLibrosBiblio.Size = new Size(703, 211);
            datosLibrosBiblio.TabIndex = 0;
            // 
            // LectorNombre
            // 
            LectorNombre.HeaderText = "ISBN";
            LectorNombre.MinimumWidth = 6;
            LectorNombre.Name = "LectorNombre";
            LectorNombre.ReadOnly = true;
            LectorNombre.Width = 85;
            // 
            // LibroPrestado
            // 
            LibroPrestado.HeaderText = "Titulo";
            LibroPrestado.MinimumWidth = 6;
            LibroPrestado.Name = "LibroPrestado";
            LibroPrestado.ReadOnly = true;
            LibroPrestado.Width = 92;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Genero";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 107;
            // 
            // FechaPrestamo
            // 
            FechaPrestamo.HeaderText = "Disponible";
            FechaPrestamo.MinimumWidth = 6;
            FechaPrestamo.Name = "FechaPrestamo";
            FechaPrestamo.ReadOnly = true;
            FechaPrestamo.Width = 136;
            // 
            // CantPrestamos
            // 
            CantPrestamos.HeaderText = "Cantidad Prestamos";
            CantPrestamos.MinimumWidth = 6;
            CantPrestamos.Name = "CantPrestamos";
            CantPrestamos.ReadOnly = true;
            CantPrestamos.Width = 203;
            // 
            // lblMensajeUsuario
            // 
            lblMensajeUsuario.Dock = DockStyle.Bottom;
            lblMensajeUsuario.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeUsuario.ForeColor = Color.Goldenrod;
            lblMensajeUsuario.Location = new Point(0, 517);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 36);
            lblMensajeUsuario.TabIndex = 24;
            lblMensajeUsuario.Text = "No hay Libros en la Biblioteca";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOrdenarLibros
            // 
            btnOrdenarLibros.BackColor = Color.FromArgb(230, 165, 36);
            btnOrdenarLibros.Cursor = Cursors.Hand;
            btnOrdenarLibros.FlatAppearance.BorderSize = 0;
            btnOrdenarLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnOrdenarLibros.FlatStyle = FlatStyle.Flat;
            btnOrdenarLibros.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnOrdenarLibros.Image = (Image)resources.GetObject("btnOrdenarLibros.Image");
            btnOrdenarLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrdenarLibros.Location = new Point(827, 94);
            btnOrdenarLibros.Name = "btnOrdenarLibros";
            btnOrdenarLibros.Size = new Size(155, 40);
            btnOrdenarLibros.TabIndex = 12;
            btnOrdenarLibros.Text = "Ordenar Libros";
            btnOrdenarLibros.TextAlign = ContentAlignment.MiddleRight;
            btnOrdenarLibros.UseVisualStyleBackColor = false;
            btnOrdenarLibros.Click += btnOrdenarLibros_Click;
            // 
            // BiblioPrestamosMas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(lblMensajeUsuario);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BiblioPrestamosMas";
            Text = "BiblioPrestamosMas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataMasPrestados).EndInit();
            ((System.ComponentModel.ISupportInitialize)datosLibrosBiblio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView datosLibrosBiblio;
        private DataGridViewTextBoxColumn LectorNombre;
        private DataGridViewTextBoxColumn LibroPrestado;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn FechaPrestamo;
        private DataGridViewTextBoxColumn CantPrestamos;
        private Label lblMensajeUsuario;
        private Label label2;
        private DataGridView dataMasPrestados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button btnOrdenarLibros;
    }
}