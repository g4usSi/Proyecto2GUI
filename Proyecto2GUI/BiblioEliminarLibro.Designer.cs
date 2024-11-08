namespace Proyecto2GUI
{
    partial class BiblioEliminarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioEliminarLibro));
            label1 = new Label();
            panel1 = new Panel();
            lblRecibirDisponibilidad = new Label();
            lblRecibirAutor = new Label();
            lblRecibirTitulo = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblISBN = new Label();
            button2 = new Button();
            btnEliminarLibro = new Button();
            btnBuscarLibro = new Button();
            RecibirBuscar = new TextBox();
            label2 = new Label();
            lblMensajeUsuario = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Aston Script Bold", 22F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 150);
            label1.TabIndex = 11;
            label1.Text = "Eliminar Libro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRecibirDisponibilidad);
            panel1.Controls.Add(lblRecibirAutor);
            panel1.Controls.Add(lblRecibirTitulo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblISBN);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnEliminarLibro);
            panel1.Controls.Add(btnBuscarLibro);
            panel1.Controls.Add(RecibirBuscar);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 305);
            panel1.TabIndex = 12;
            // 
            // lblRecibirDisponibilidad
            // 
            lblRecibirDisponibilidad.AutoSize = true;
            lblRecibirDisponibilidad.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirDisponibilidad.Location = new Point(317, 185);
            lblRecibirDisponibilidad.Name = "lblRecibirDisponibilidad";
            lblRecibirDisponibilidad.Size = new Size(27, 27);
            lblRecibirDisponibilidad.TabIndex = 20;
            lblRecibirDisponibilidad.Text = "D";
            // 
            // lblRecibirAutor
            // 
            lblRecibirAutor.AutoSize = true;
            lblRecibirAutor.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirAutor.Location = new Point(317, 157);
            lblRecibirAutor.Name = "lblRecibirAutor";
            lblRecibirAutor.Size = new Size(26, 27);
            lblRecibirAutor.TabIndex = 19;
            lblRecibirAutor.Text = "A";
            // 
            // lblRecibirTitulo
            // 
            lblRecibirTitulo.AutoSize = true;
            lblRecibirTitulo.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirTitulo.Location = new Point(317, 126);
            lblRecibirTitulo.Name = "lblRecibirTitulo";
            lblRecibirTitulo.Size = new Size(24, 27);
            lblRecibirTitulo.TabIndex = 18;
            lblRecibirTitulo.Text = "T";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label6.Location = new Point(150, 185);
            label6.Name = "label6";
            label6.Size = new Size(149, 27);
            label6.TabIndex = 17;
            label6.Text = "Disponibilidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(150, 158);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 16;
            label5.Text = "Autor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label4.Location = new Point(150, 127);
            label4.Name = "label4";
            label4.Size = new Size(71, 27);
            label4.TabIndex = 15;
            label4.Text = "Titulo:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblISBN.Location = new Point(389, 88);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(59, 27);
            lblISBN.TabIndex = 14;
            lblISBN.Text = "ISBN";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 165, 36);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(730, 188);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 0, 38, 0);
            button2.Size = new Size(146, 40);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.BackColor = Color.DarkRed;
            btnEliminarLibro.Cursor = Cursors.Hand;
            btnEliminarLibro.FlatAppearance.BorderSize = 0;
            btnEliminarLibro.FlatAppearance.MouseOverBackColor = Color.Tomato;
            btnEliminarLibro.FlatStyle = FlatStyle.Flat;
            btnEliminarLibro.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnEliminarLibro.ForeColor = Color.White;
            btnEliminarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarLibro.Location = new Point(730, 129);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(146, 40);
            btnEliminarLibro.TabIndex = 12;
            btnEliminarLibro.Text = "Eliminar Libro";
            btnEliminarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarLibro.UseVisualStyleBackColor = false;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
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
            btnBuscarLibro.Location = new Point(730, 34);
            btnBuscarLibro.Name = "btnBuscarLibro";
            btnBuscarLibro.Size = new Size(146, 40);
            btnBuscarLibro.TabIndex = 11;
            btnBuscarLibro.Text = "Buscar Libro";
            btnBuscarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarLibro.UseVisualStyleBackColor = false;
            btnBuscarLibro.Click += btnBuscarLibro_Click_1;
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
            label2.Location = new Point(112, 38);
            label2.Name = "label2";
            label2.Size = new Size(138, 27);
            label2.TabIndex = 0;
            label2.Text = "Ingrese ISBN:";
            // 
            // lblMensajeUsuario
            // 
            lblMensajeUsuario.Dock = DockStyle.Bottom;
            lblMensajeUsuario.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeUsuario.ForeColor = Color.DarkRed;
            lblMensajeUsuario.Location = new Point(0, 458);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 95);
            lblMensajeUsuario.TabIndex = 21;
            lblMensajeUsuario.Text = "Error no se encontro el libro";
            lblMensajeUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // BiblioEliminarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(lblMensajeUsuario);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BiblioEliminarLibro";
            Text = "BiblioEliminarLibro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button2;
        private Button btnEliminarLibro;
        private Button btnBuscarLibro;
        private TextBox RecibirBuscar;
        private Label label2;
        private Label lblISBN;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblMensajeUsuario;
        private Label lblRecibirDisponibilidad;
        private Label lblRecibirAutor;
        private Label lblRecibirTitulo;
    }
}