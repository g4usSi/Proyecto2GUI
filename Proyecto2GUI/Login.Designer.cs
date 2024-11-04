namespace Proyecto2GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            NombreUser = new Label();
            PassUser = new Label();
            txtNombre = new TextBox();
            txtPassword = new TextBox();
            lblSignIn = new Label();
            BtnEntrar = new Button();
            btnSalir = new Button();
            BtnCerrar = new PictureBox();
            imgLogin = new Panel();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            SuspendLayout();
            // 
            // NombreUser
            // 
            NombreUser.AutoSize = true;
            NombreUser.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreUser.Location = new Point(153, 132);
            NombreUser.Name = "NombreUser";
            NombreUser.Size = new Size(101, 35);
            NombreUser.TabIndex = 0;
            NombreUser.Text = "Nombre:";
            // 
            // PassUser
            // 
            PassUser.AutoSize = true;
            PassUser.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassUser.Location = new Point(153, 212);
            PassUser.Name = "PassUser";
            PassUser.Size = new Size(133, 35);
            PassUser.TabIndex = 1;
            PassUser.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(290, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 30);
            txtNombre.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(290, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(285, 30);
            txtPassword.TabIndex = 3;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignIn.Location = new Point(221, 53);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(254, 50);
            lblSignIn.TabIndex = 4;
            lblSignIn.Text = "INICIAR SESION";
            // 
            // BtnEntrar
            // 
            BtnEntrar.Cursor = Cursors.Hand;
            BtnEntrar.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEntrar.Location = new Point(307, 271);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(105, 33);
            BtnEntrar.TabIndex = 5;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(446, 271);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 33);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button2_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Cursor = Cursors.Hand;
            BtnCerrar.Image = (Image)resources.GetObject("BtnCerrar.Image");
            BtnCerrar.Location = new Point(613, 12);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(25, 25);
            BtnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnCerrar.TabIndex = 7;
            BtnCerrar.TabStop = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // imgLogin
            // 
            imgLogin.BackgroundImage = (Image)resources.GetObject("imgLogin.BackgroundImage");
            imgLogin.Dock = DockStyle.Left;
            imgLogin.Location = new Point(0, 0);
            imgLogin.Name = "imgLogin";
            imgLogin.Size = new Size(145, 400);
            imgLogin.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(650, 400);
            Controls.Add(imgLogin);
            Controls.Add(BtnCerrar);
            Controls.Add(btnSalir);
            Controls.Add(BtnEntrar);
            Controls.Add(lblSignIn);
            Controls.Add(txtPassword);
            Controls.Add(txtNombre);
            Controls.Add(PassUser);
            Controls.Add(NombreUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreUser;
        private Label PassUser;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private Label lblSignIn;
        private Button BtnEntrar;
        private Button btnSalir;
        private PictureBox BtnCerrar;
        private Panel imgLogin;
    }
}