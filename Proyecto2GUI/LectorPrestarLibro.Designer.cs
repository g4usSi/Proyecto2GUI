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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Aston Script Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 150);
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
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 286);
            panel1.TabIndex = 13;
            // 
            // lblRecibirDisponibilidad
            // 
            lblRecibirDisponibilidad.AutoSize = true;
            lblRecibirDisponibilidad.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirDisponibilidad.Location = new Point(390, 229);
            lblRecibirDisponibilidad.Name = "lblRecibirDisponibilidad";
            lblRecibirDisponibilidad.Size = new Size(27, 27);
            lblRecibirDisponibilidad.TabIndex = 33;
            lblRecibirDisponibilidad.Text = "D";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label9.Location = new Point(269, 229);
            label9.Name = "label9";
            label9.Size = new Size(115, 27);
            label9.TabIndex = 32;
            label9.Text = "Disponible:";
            // 
            // lblRecibirGenero
            // 
            lblRecibirGenero.AutoSize = true;
            lblRecibirGenero.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirGenero.Location = new Point(360, 184);
            lblRecibirGenero.Name = "lblRecibirGenero";
            lblRecibirGenero.Size = new Size(26, 27);
            lblRecibirGenero.TabIndex = 31;
            lblRecibirGenero.Text = "G";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label7.Location = new Point(269, 184);
            label7.Name = "label7";
            label7.Size = new Size(85, 27);
            label7.TabIndex = 30;
            label7.Text = "Genero:";
            // 
            // lblRecibirAutor
            // 
            lblRecibirAutor.AutoSize = true;
            lblRecibirAutor.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirAutor.Location = new Point(346, 143);
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
            label5.Location = new Point(269, 141);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 28;
            label5.Text = "Autor:";
            // 
            // lblRecibirTitulo
            // 
            lblRecibirTitulo.AutoSize = true;
            lblRecibirTitulo.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirTitulo.Location = new Point(346, 98);
            lblRecibirTitulo.Name = "lblRecibirTitulo";
            lblRecibirTitulo.Size = new Size(24, 27);
            lblRecibirTitulo.TabIndex = 27;
            lblRecibirTitulo.Text = "T";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label3.Location = new Point(269, 98);
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
            btnSolicitarLibro.Location = new Point(740, 154);
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
            lblMensajeUsuario.Location = new Point(0, 439);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 114);
            lblMensajeUsuario.TabIndex = 25;
            lblMensajeUsuario.Text = "Mensaje";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LectorPrestarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(lblMensajeUsuario);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "LectorPrestarLibro";
            Text = "LectorPrestarLibro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}