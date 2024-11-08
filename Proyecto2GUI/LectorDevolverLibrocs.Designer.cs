namespace Proyecto2GUI
{
    partial class LectorDevolverLibrocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LectorDevolverLibrocs));
            lblMensajeUsuario = new Label();
            panel1 = new Panel();
            lblTituloLibro = new Label();
            lblRecibirDisponibilidad = new Label();
            label9 = new Label();
            lblRecibirGenero = new Label();
            label7 = new Label();
            lblRecibirAutor = new Label();
            label5 = new Label();
            btnSolicitarLibro = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMensajeUsuario
            // 
            lblMensajeUsuario.Dock = DockStyle.Bottom;
            lblMensajeUsuario.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeUsuario.ForeColor = Color.Goldenrod;
            lblMensajeUsuario.Location = new Point(0, 439);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 114);
            lblMensajeUsuario.TabIndex = 28;
            lblMensajeUsuario.Text = "Mensaje";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTituloLibro);
            panel1.Controls.Add(lblRecibirDisponibilidad);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblRecibirGenero);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblRecibirAutor);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnSolicitarLibro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 286);
            panel1.TabIndex = 27;
            // 
            // lblTituloLibro
            // 
            lblTituloLibro.Dock = DockStyle.Top;
            lblTituloLibro.Font = new Font("Aston Script Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLibro.Location = new Point(0, 0);
            lblTituloLibro.Name = "lblTituloLibro";
            lblTituloLibro.Size = new Size(982, 78);
            lblTituloLibro.TabIndex = 34;
            lblTituloLibro.Text = "Mensaje";
            lblTituloLibro.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRecibirDisponibilidad
            // 
            lblRecibirDisponibilidad.AutoSize = true;
            lblRecibirDisponibilidad.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirDisponibilidad.Location = new Point(462, 166);
            lblRecibirDisponibilidad.Name = "lblRecibirDisponibilidad";
            lblRecibirDisponibilidad.Size = new Size(27, 27);
            lblRecibirDisponibilidad.TabIndex = 33;
            lblRecibirDisponibilidad.Text = "D";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label9.Location = new Point(285, 166);
            label9.Name = "label9";
            label9.Size = new Size(171, 27);
            label9.TabIndex = 32;
            label9.Text = "Fecha Prestamo: ";
            // 
            // lblRecibirGenero
            // 
            lblRecibirGenero.AutoSize = true;
            lblRecibirGenero.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirGenero.Location = new Point(376, 121);
            lblRecibirGenero.Name = "lblRecibirGenero";
            lblRecibirGenero.Size = new Size(26, 27);
            lblRecibirGenero.TabIndex = 31;
            lblRecibirGenero.Text = "G";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label7.Location = new Point(285, 121);
            label7.Name = "label7";
            label7.Size = new Size(85, 27);
            label7.TabIndex = 30;
            label7.Text = "Genero:";
            // 
            // lblRecibirAutor
            // 
            lblRecibirAutor.AutoSize = true;
            lblRecibirAutor.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirAutor.Location = new Point(362, 78);
            lblRecibirAutor.Name = "lblRecibirAutor";
            lblRecibirAutor.Size = new Size(26, 27);
            lblRecibirAutor.TabIndex = 29;
            lblRecibirAutor.Text = "A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(285, 78);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 28;
            label5.Text = "Autor:";
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
            btnSolicitarLibro.Location = new Point(407, 230);
            btnSolicitarLibro.Name = "btnSolicitarLibro";
            btnSolicitarLibro.Size = new Size(157, 40);
            btnSolicitarLibro.TabIndex = 12;
            btnSolicitarLibro.Text = "Devolver Libro";
            btnSolicitarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnSolicitarLibro.UseVisualStyleBackColor = false;
            btnSolicitarLibro.Click += btnSolicitarLibro_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Aston Script Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 150);
            label1.TabIndex = 26;
            label1.Text = "Devolver Libro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LectorDevolverLibrocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(lblMensajeUsuario);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "LectorDevolverLibrocs";
            Text = "LectorDevolverLibrocs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMensajeUsuario;
        private Panel panel1;
        private Label lblRecibirDisponibilidad;
        private Label label9;
        private Label lblRecibirGenero;
        private Label label7;
        private Label lblRecibirAutor;
        private Label label5;
        private Button btnSolicitarLibro;
        private Label label1;
        private Label lblTituloLibro;
    }
}