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
            label1 = new Label();
            panel1 = new Panel();
            datosLibrosBiblio = new DataGridView();
            LectorNombre = new DataGridViewTextBoxColumn();
            LibroPrestado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            FechaPrestamo = new DataGridViewTextBoxColumn();
            CantPrestamos = new DataGridViewTextBoxColumn();
            lblMensajeUsuario = new Label();
            panel1.SuspendLayout();
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
            label1.Size = new Size(982, 126);
            label1.TabIndex = 10;
            label1.Text = "Libros en la Biblioteca";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(datosLibrosBiblio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 329);
            panel1.TabIndex = 12;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 53, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(184, 149, 93);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datosLibrosBiblio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datosLibrosBiblio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosLibrosBiblio.Columns.AddRange(new DataGridViewColumn[] { LectorNombre, LibroPrestado, Fecha, FechaPrestamo, CantPrestamos });
            datosLibrosBiblio.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datosLibrosBiblio.DefaultCellStyle = dataGridViewCellStyle2;
            datosLibrosBiblio.EnableHeadersVisualStyles = false;
            datosLibrosBiblio.GridColor = Color.FromArgb(49, 53, 56);
            datosLibrosBiblio.Location = new Point(171, 0);
            datosLibrosBiblio.Name = "datosLibrosBiblio";
            datosLibrosBiblio.ReadOnly = true;
            datosLibrosBiblio.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            datosLibrosBiblio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            datosLibrosBiblio.RowHeadersVisible = false;
            datosLibrosBiblio.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Small", 10.2F);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 165, 36);
            datosLibrosBiblio.RowsDefaultCellStyle = dataGridViewCellStyle4;
            datosLibrosBiblio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datosLibrosBiblio.Size = new Size(703, 326);
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
            lblMensajeUsuario.Location = new Point(0, 457);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 96);
            lblMensajeUsuario.TabIndex = 24;
            lblMensajeUsuario.Text = "No hay Libros en la Biblioteca";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
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
    }
}