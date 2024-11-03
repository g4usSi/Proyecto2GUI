﻿namespace Proyecto2GUI
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
            button2 = new Button();
            BtnCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            SuspendLayout();
            // 
            // NombreUser
            // 
            NombreUser.AutoSize = true;
            NombreUser.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreUser.Location = new Point(59, 134);
            NombreUser.Name = "NombreUser";
            NombreUser.Size = new Size(101, 35);
            NombreUser.TabIndex = 0;
            NombreUser.Text = "Nombre:";
            // 
            // PassUser
            // 
            PassUser.AutoSize = true;
            PassUser.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassUser.Location = new Point(59, 214);
            PassUser.Name = "PassUser";
            PassUser.Size = new Size(133, 35);
            PassUser.TabIndex = 1;
            PassUser.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(196, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 30);
            txtNombre.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(196, 219);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(285, 30);
            txtPassword.TabIndex = 3;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignIn.Location = new Point(206, 61);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(254, 50);
            lblSignIn.TabIndex = 4;
            lblSignIn.Text = "INICIAR SESION";
            // 
            // BtnEntrar
            // 
            BtnEntrar.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEntrar.Location = new Point(213, 273);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(105, 33);
            BtnEntrar.TabIndex = 5;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(352, 273);
            button2.Name = "button2";
            button2.Size = new Size(105, 33);
            button2.TabIndex = 6;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Image = (Image)resources.GetObject("BtnCerrar.Image");
            BtnCerrar.Location = new Point(613, 12);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(25, 25);
            BtnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnCerrar.TabIndex = 7;
            BtnCerrar.TabStop = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(650, 400);
            Controls.Add(BtnCerrar);
            Controls.Add(button2);
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
        private Button button2;
        private PictureBox BtnCerrar;
    }
}