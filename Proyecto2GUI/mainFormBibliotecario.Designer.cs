namespace Proyecto2GUI
{
    partial class mainFormBibliotecario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormBibliotecario));
            brraTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            pnelMenu = new Panel();
            brraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // brraTitulo
            // 
            brraTitulo.Controls.Add(btnMinimizar);
            brraTitulo.Controls.Add(btnCerrar);
            brraTitulo.Dock = DockStyle.Top;
            brraTitulo.Location = new Point(0, 0);
            brraTitulo.Name = "brraTitulo";
            brraTitulo.Size = new Size(1380, 65);
            brraTitulo.TabIndex = 0;
            brraTitulo.MouseDown += brraTitulo_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1271, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(40, 40);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 9;
            btnMinimizar.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1328, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 8;
            btnCerrar.TabStop = false;
            // 
            // pnelMenu
            // 
            pnelMenu.Dock = DockStyle.Left;
            pnelMenu.Location = new Point(0, 65);
            pnelMenu.Name = "pnelMenu";
            pnelMenu.Size = new Size(250, 715);
            pnelMenu.TabIndex = 1;
            // 
            // mainFormBibliotecario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 209, 209);
            ClientSize = new Size(1380, 780);
            Controls.Add(pnelMenu);
            Controls.Add(brraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainFormBibliotecario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainFormBibliotecario";
            brraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel brraTitulo;
        private Panel pnelMenu;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
    }
}