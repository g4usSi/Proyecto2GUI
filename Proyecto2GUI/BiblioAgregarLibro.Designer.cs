namespace Proyecto2GUI
{
    partial class BiblioAgregarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioAgregarLibro));
            label1 = new Label();
            panel1 = new Panel();
            lblMensajeUsuario = new Label();
            btnCancelar = new Button();
            btnRegistrarLibro = new Button();
            RecibirISBN = new TextBox();
            RecibirGenero = new TextBox();
            RecibirAutor = new TextBox();
            RecibirNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            label1.TabIndex = 8;
            label1.Text = "Agregar Libro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnRegistrarLibro);
            panel1.Controls.Add(RecibirISBN);
            panel1.Controls.Add(RecibirGenero);
            panel1.Controls.Add(RecibirAutor);
            panel1.Controls.Add(RecibirNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 293);
            panel1.TabIndex = 9;
            // 
            // lblMensajeUsuario
            // 
            lblMensajeUsuario.Dock = DockStyle.Bottom;
            lblMensajeUsuario.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeUsuario.ForeColor = Color.DarkRed;
            lblMensajeUsuario.Location = new Point(0, 446);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 107);
            lblMensajeUsuario.TabIndex = 22;
            lblMensajeUsuario.Text = "No puede repetir numero de ISBN";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(230, 165, 36);
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(733, 115);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(0, 0, 42, 0);
            btnCancelar.Size = new Size(151, 40);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Limpiar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseMnemonic = false;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrarLibro
            // 
            btnRegistrarLibro.BackColor = Color.FromArgb(230, 165, 36);
            btnRegistrarLibro.BackgroundImageLayout = ImageLayout.None;
            btnRegistrarLibro.Cursor = Cursors.Hand;
            btnRegistrarLibro.FlatAppearance.BorderSize = 0;
            btnRegistrarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnRegistrarLibro.FlatStyle = FlatStyle.Flat;
            btnRegistrarLibro.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnRegistrarLibro.Image = (Image)resources.GetObject("btnRegistrarLibro.Image");
            btnRegistrarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarLibro.Location = new Point(733, 60);
            btnRegistrarLibro.Name = "btnRegistrarLibro";
            btnRegistrarLibro.Size = new Size(151, 40);
            btnRegistrarLibro.TabIndex = 9;
            btnRegistrarLibro.Text = "Agregar Libro";
            btnRegistrarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarLibro.UseVisualStyleBackColor = false;
            btnRegistrarLibro.Click += btnRegistrarLibro_Click;
            // 
            // RecibirISBN
            // 
            RecibirISBN.BorderStyle = BorderStyle.None;
            RecibirISBN.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirISBN.Location = new Point(236, 156);
            RecibirISBN.Name = "RecibirISBN";
            RecibirISBN.Size = new Size(437, 24);
            RecibirISBN.TabIndex = 8;
            // 
            // RecibirGenero
            // 
            RecibirGenero.BorderStyle = BorderStyle.None;
            RecibirGenero.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirGenero.Location = new Point(236, 115);
            RecibirGenero.Name = "RecibirGenero";
            RecibirGenero.Size = new Size(437, 24);
            RecibirGenero.TabIndex = 7;
            // 
            // RecibirAutor
            // 
            RecibirAutor.BorderStyle = BorderStyle.None;
            RecibirAutor.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirAutor.Location = new Point(236, 76);
            RecibirAutor.Name = "RecibirAutor";
            RecibirAutor.Size = new Size(437, 24);
            RecibirAutor.TabIndex = 6;
            // 
            // RecibirNombre
            // 
            RecibirNombre.BorderStyle = BorderStyle.None;
            RecibirNombre.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirNombre.Location = new Point(236, 40);
            RecibirNombre.Name = "RecibirNombre";
            RecibirNombre.Size = new Size(437, 24);
            RecibirNombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(140, 153);
            label5.Name = "label5";
            label5.Size = new Size(64, 27);
            label5.TabIndex = 3;
            label5.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label4.Location = new Point(140, 115);
            label4.Name = "label4";
            label4.Size = new Size(85, 27);
            label4.TabIndex = 2;
            label4.Text = "Genero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label3.Location = new Point(140, 76);
            label3.Name = "label3";
            label3.Size = new Size(76, 27);
            label3.TabIndex = 1;
            label3.Text = "Autor: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label2.Location = new Point(140, 37);
            label2.Name = "label2";
            label2.Size = new Size(76, 27);
            label2.TabIndex = 0;
            label2.Text = "Titulo: ";
            // 
            // BiblioAgregarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(lblMensajeUsuario);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BiblioAgregarLibro";
            Text = "BiblioAgregarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox RecibirAutor;
        private TextBox RecibirNombre;
        private TextBox RecibirISBN;
        private TextBox RecibirGenero;
        private Button btnCancelar;
        private Button btnRegistrarLibro;
        private Label lblMensajeUsuario;
    }
}