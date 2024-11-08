namespace Proyecto2GUI
{
    partial class BiblioBuscarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioBuscarLibro));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnBuscarLibro = new Button();
            TablaLibrosBuscados = new DataGridView();
            RecibirBuscar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblMensajeUsuario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaLibrosBuscados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBuscarLibro);
            panel1.Controls.Add(TablaLibrosBuscados);
            panel1.Controls.Add(RecibirBuscar);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 343);
            panel1.TabIndex = 11;
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
            // TablaLibrosBuscados
            // 
            TablaLibrosBuscados.AllowUserToAddRows = false;
            TablaLibrosBuscados.AllowUserToDeleteRows = false;
            TablaLibrosBuscados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TablaLibrosBuscados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TablaLibrosBuscados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TablaLibrosBuscados.BackgroundColor = SystemColors.Control;
            TablaLibrosBuscados.BorderStyle = BorderStyle.None;
            TablaLibrosBuscados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 53, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(184, 149, 93);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TablaLibrosBuscados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TablaLibrosBuscados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaLibrosBuscados.Cursor = Cursors.Hand;
            TablaLibrosBuscados.EnableHeadersVisualStyles = false;
            TablaLibrosBuscados.GridColor = Color.FromArgb(49, 53, 56);
            TablaLibrosBuscados.Location = new Point(239, 93);
            TablaLibrosBuscados.Name = "TablaLibrosBuscados";
            TablaLibrosBuscados.ReadOnly = true;
            TablaLibrosBuscados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TablaLibrosBuscados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TablaLibrosBuscados.RowHeadersVisible = false;
            TablaLibrosBuscados.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 165, 36);
            TablaLibrosBuscados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            TablaLibrosBuscados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaLibrosBuscados.Size = new Size(632, 187);
            TablaLibrosBuscados.TabIndex = 10;
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
            label2.Location = new Point(99, 37);
            label2.Name = "label2";
            label2.Size = new Size(152, 27);
            label2.TabIndex = 0;
            label2.Text = "Titulo o Autor: ";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Aston Script Bold", 22F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 150);
            label1.TabIndex = 10;
            label1.Text = "Buscar Libro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMensajeUsuario
            // 
            lblMensajeUsuario.Dock = DockStyle.Bottom;
            lblMensajeUsuario.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeUsuario.ForeColor = Color.Goldenrod;
            lblMensajeUsuario.Location = new Point(0, 496);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 57);
            lblMensajeUsuario.TabIndex = 29;
            lblMensajeUsuario.Text = "Mensaje";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BiblioBuscarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(lblMensajeUsuario);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BiblioBuscarLibro";
            Text = "Buscar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TablaLibrosBuscados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnRegistrarLibro;
        private TextBox RecibirISBN;
        private TextBox RecibirGenero;
        private TextBox RecibirAutor;
        private TextBox RecibirBuscar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView TablaLibrosBuscados;
        private Button btnBuscarLibro;
        private Label lblMensajeUsuario;
    }
}