using System.Drawing.Drawing2D;

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
            BtnEntrar = new Button();
            btnSalir = new Button();
            BtnCerrar = new PictureBox();
            imgLogin = new Panel();
            label1 = new Label();
            lblSignIn = new Label();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            SuspendLayout();
            // 
            // NombreUser
            // 
            NombreUser.AutoSize = true;
            NombreUser.Font = new Font("Segoe UI Variable Small Semilig", 12F);
            NombreUser.Location = new Point(154, 137);
            NombreUser.Name = "NombreUser";
            NombreUser.Size = new Size(92, 27);
            NombreUser.TabIndex = 0;
            NombreUser.Text = "Nombre:";
            // 
            // PassUser
            // 
            PassUser.AutoSize = true;
            PassUser.Font = new Font("Segoe UI Variable Small Semilig", 12F);
            PassUser.Location = new Point(154, 217);
            PassUser.Name = "PassUser";
            PassUser.Size = new Size(120, 27);
            PassUser.TabIndex = 1;
            PassUser.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(284, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 30);
            txtNombre.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(284, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(285, 30);
            txtPassword.TabIndex = 3;
            // 
            // BtnEntrar
            // 
            BtnEntrar.Cursor = Cursors.Hand;
            BtnEntrar.Font = new Font("Segoe UI Variable Small Semilig", 10F);
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
            btnSalir.Font = new Font("Segoe UI Variable Small Semilig", 10F);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aston Script Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 26);
            label1.Name = "label1";
            label1.Size = new Size(226, 59);
            label1.TabIndex = 9;
            label1.Text = "Bienvenido a";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Aston Script Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignIn.Location = new Point(366, 66);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(185, 59);
            lblSignIn.TabIndex = 4;
            lblSignIn.Text = "Biblioteca";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(650, 400);
            Controls.Add(lblSignIn);
            Controls.Add(label1);
            Controls.Add(imgLogin);
            Controls.Add(BtnCerrar);
            Controls.Add(btnSalir);
            Controls.Add(BtnEntrar);
            Controls.Add(txtPassword);
            Controls.Add(txtNombre);
            Controls.Add(PassUser);
            Controls.Add(NombreUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreUser;
        private Label PassUser;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private Button BtnEntrar;
        private Button btnSalir;
        private PictureBox BtnCerrar;
        private Panel imgLogin;
        private Label label1;
        private Label lblSignIn;
    }
}