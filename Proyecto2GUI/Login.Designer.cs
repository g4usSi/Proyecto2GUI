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
            NombreUser = new Label();
            PassUser = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            NombreUser.Location = new Point(72, 139);
            NombreUser.Name = "NombreUser";
            NombreUser.Size = new Size(67, 20);
            NombreUser.TabIndex = 0;
            NombreUser.Text = "Nombre:";
            // 
            // PassUser
            // 
            PassUser.AutoSize = true;
            PassUser.Location = new Point(72, 223);
            PassUser.Name = "PassUser";
            PassUser.Size = new Size(86, 20);
            PassUser.TabIndex = 1;
            PassUser.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(285, 27);
            textBox2.TabIndex = 3;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Location = new Point(275, 81);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(96, 20);
            lblSignIn.TabIndex = 4;
            lblSignIn.Text = "Iniciar Sesion";
            // 
            // BtnEntrar
            // 
            BtnEntrar.Location = new Point(213, 273);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(105, 33);
            BtnEntrar.TabIndex = 5;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
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
            BtnCerrar.Location = new Point(613, 12);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(25, 25);
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
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblSignIn;
        private Button BtnEntrar;
        private Button button2;
        private PictureBox BtnCerrar;
    }
}