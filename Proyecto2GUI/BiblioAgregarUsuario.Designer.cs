namespace Proyecto2GUI
{
    partial class BiblioAgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioAgregarUsuario));
            label1 = new Label();
            panel1 = new Panel();
            RecibirRol = new ComboBox();
            RecibirContraseña = new TextBox();
            RecibirNombre = new TextBox();
            RecibirID = new TextBox();
            lblConfirmacion = new Label();
            label5 = new Label();
            btnLimpiarCampos = new Button();
            lblMensajeUsuario = new Label();
            btnAgregarUsuario = new Button();
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
            label1.TabIndex = 9;
            label1.Text = "Agregar Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(RecibirRol);
            panel1.Controls.Add(RecibirContraseña);
            panel1.Controls.Add(RecibirNombre);
            panel1.Controls.Add(RecibirID);
            panel1.Controls.Add(lblConfirmacion);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLimpiarCampos);
            panel1.Controls.Add(lblMensajeUsuario);
            panel1.Controls.Add(btnAgregarUsuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 353);
            panel1.TabIndex = 11;
            // 
            // RecibirRol
            // 
            RecibirRol.DisplayMember = "0, 1";
            RecibirRol.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecibirRol.FormattingEnabled = true;
            RecibirRol.Items.AddRange(new object[] { "Bibliotecario", "Lector" });
            RecibirRol.Location = new Point(236, 192);
            RecibirRol.Name = "RecibirRol";
            RecibirRol.Size = new Size(437, 30);
            RecibirRol.TabIndex = 27;
            RecibirRol.ValueMember = "1, 2";
            // 
            // RecibirContraseña
            // 
            RecibirContraseña.BorderStyle = BorderStyle.None;
            RecibirContraseña.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirContraseña.Location = new Point(236, 143);
            RecibirContraseña.Name = "RecibirContraseña";
            RecibirContraseña.Size = new Size(437, 24);
            RecibirContraseña.TabIndex = 7;
            // 
            // RecibirNombre
            // 
            RecibirNombre.BorderStyle = BorderStyle.None;
            RecibirNombre.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirNombre.Location = new Point(236, 94);
            RecibirNombre.Name = "RecibirNombre";
            RecibirNombre.Size = new Size(437, 24);
            RecibirNombre.TabIndex = 5;
            // 
            // RecibirID
            // 
            RecibirID.BorderStyle = BorderStyle.None;
            RecibirID.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirID.Location = new Point(236, 43);
            RecibirID.Name = "RecibirID";
            RecibirID.Size = new Size(437, 24);
            RecibirID.TabIndex = 6;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmacion.ForeColor = Color.Goldenrod;
            lblConfirmacion.Location = new Point(391, 281);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(196, 27);
            lblConfirmacion.TabIndex = 28;
            lblConfirmacion.Text = "Usuario Registrado";
            lblConfirmacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(106, 189);
            label5.Name = "label5";
            label5.Size = new Size(46, 27);
            label5.TabIndex = 26;
            label5.Text = "Rol:";
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.FromArgb(230, 165, 36);
            btnLimpiarCampos.BackgroundImageLayout = ImageLayout.None;
            btnLimpiarCampos.Cursor = Cursors.Hand;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnLimpiarCampos.Image = (Image)resources.GetObject("btnLimpiarCampos.Image");
            btnLimpiarCampos.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarCampos.Location = new Point(717, 113);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(168, 40);
            btnLimpiarCampos.TabIndex = 25;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // lblMensajeUsuario
            // 
            lblMensajeUsuario.AutoSize = true;
            lblMensajeUsuario.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeUsuario.ForeColor = Color.DarkRed;
            lblMensajeUsuario.Location = new Point(319, 308);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(325, 27);
            lblMensajeUsuario.TabIndex = 24;
            lblMensajeUsuario.Text = "No puede repetir numeros de ID";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.FromArgb(230, 165, 36);
            btnAgregarUsuario.BackgroundImageLayout = ImageLayout.None;
            btnAgregarUsuario.Cursor = Cursors.Hand;
            btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            btnAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btnAgregarUsuario.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnAgregarUsuario.Image = (Image)resources.GetObject("btnAgregarUsuario.Image");
            btnAgregarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarUsuario.Location = new Point(717, 57);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(168, 40);
            btnAgregarUsuario.TabIndex = 9;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label4.Location = new Point(106, 140);
            label4.Name = "label4";
            label4.Size = new Size(125, 27);
            label4.TabIndex = 2;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label3.Location = new Point(106, 40);
            label3.Name = "label3";
            label3.Size = new Size(38, 27);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label2.Location = new Point(106, 90);
            label2.Name = "label2";
            label2.Size = new Size(94, 27);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // BiblioAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BiblioAgregarUsuario";
            Text = "BiblioAgregarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnAgregarUsuario;
        private TextBox RecibirContraseña;
        private TextBox RecibirID;
        private TextBox RecibirNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblMensajeUsuario;
        private Button btnLimpiarCampos;
        private Label label5;
        private ComboBox RecibirRol;
        private Label lblConfirmacion;
    }
}