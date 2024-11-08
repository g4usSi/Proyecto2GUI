namespace Proyecto2GUI
{
    partial class BiblioPrestamosActivos
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
            datosPrestamos = new DataGridView();
            LectorNombre = new DataGridViewTextBoxColumn();
            LibroPrestado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            FechaPrestamo = new DataGridViewTextBoxColumn();
            lblMensajeUsuario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosPrestamos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Aston Script Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 150);
            label1.TabIndex = 10;
            label1.Text = "Prestamos Activos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(datosPrestamos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 403);
            panel1.TabIndex = 11;
            // 
            // datosPrestamos
            // 
            datosPrestamos.AllowUserToAddRows = false;
            datosPrestamos.AllowUserToDeleteRows = false;
            datosPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datosPrestamos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datosPrestamos.BackgroundColor = SystemColors.Control;
            datosPrestamos.BorderStyle = BorderStyle.None;
            datosPrestamos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 53, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(184, 149, 93);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datosPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datosPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosPrestamos.Columns.AddRange(new DataGridViewColumn[] { LectorNombre, LibroPrestado, Fecha, FechaPrestamo });
            datosPrestamos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datosPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            datosPrestamos.EnableHeadersVisualStyles = false;
            datosPrestamos.GridColor = Color.FromArgb(49, 53, 56);
            datosPrestamos.Location = new Point(149, 0);
            datosPrestamos.Name = "datosPrestamos";
            datosPrestamos.ReadOnly = true;
            datosPrestamos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            datosPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            datosPrestamos.RowHeadersVisible = false;
            datosPrestamos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Small", 10.2F);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 165, 36);
            datosPrestamos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            datosPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datosPrestamos.Size = new Size(627, 340);
            datosPrestamos.TabIndex = 0;
            // 
            // LectorNombre
            // 
            LectorNombre.HeaderText = "Lector";
            LectorNombre.MinimumWidth = 6;
            LectorNombre.Name = "LectorNombre";
            LectorNombre.ReadOnly = true;
            // 
            // LibroPrestado
            // 
            LibroPrestado.HeaderText = "ISBN";
            LibroPrestado.MinimumWidth = 6;
            LibroPrestado.Name = "LibroPrestado";
            LibroPrestado.ReadOnly = true;
            LibroPrestado.Width = 85;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Libro Prestado";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 173;
            // 
            // FechaPrestamo
            // 
            FechaPrestamo.HeaderText = "Fecha Prestamo";
            FechaPrestamo.MinimumWidth = 6;
            FechaPrestamo.Name = "FechaPrestamo";
            FechaPrestamo.ReadOnly = true;
            FechaPrestamo.Width = 185;
            // 
            // lblMensajeUsuario
            // 
            lblMensajeUsuario.Dock = DockStyle.Bottom;
            lblMensajeUsuario.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeUsuario.ForeColor = Color.DarkRed;
            lblMensajeUsuario.Location = new Point(0, 493);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 60);
            lblMensajeUsuario.TabIndex = 24;
            lblMensajeUsuario.Text = "Mensaje";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BiblioPrestamosActivos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(lblMensajeUsuario);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BiblioPrestamosActivos";
            Text = "BiblioPrestamosActivos";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datosPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView2;
        private DataGridView datosPrestamos;
        private DataGridViewTextBoxColumn LectorNombre;
        private DataGridViewTextBoxColumn LibroPrestado;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn FechaPrestamo;
        private Label lblMensajeUsuario;
    }
}