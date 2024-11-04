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
            tituloBarraBibliotecario = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            pnelMenu = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            btnDelBook = new Button();
            btnFindBook = new Button();
            btnAddBook = new Button();
            lblTituloApp = new Label();
            imgLogo = new PictureBox();
            btnLibros = new Button();
            panel7 = new Panel();
            button7 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            brraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            pnelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // brraTitulo
            // 
            brraTitulo.BackColor = Color.FromArgb(49, 53, 56);
            brraTitulo.Controls.Add(tituloBarraBibliotecario);
            brraTitulo.Controls.Add(btnMinimizar);
            brraTitulo.Controls.Add(btnCerrar);
            brraTitulo.Dock = DockStyle.Top;
            brraTitulo.Location = new Point(0, 0);
            brraTitulo.Name = "brraTitulo";
            brraTitulo.Size = new Size(1380, 65);
            brraTitulo.TabIndex = 0;
            brraTitulo.MouseDown += brraTitulo_MouseDown;
            // 
            // tituloBarraBibliotecario
            // 
            tituloBarraBibliotecario.AutoSize = true;
            tituloBarraBibliotecario.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloBarraBibliotecario.ForeColor = Color.Transparent;
            tituloBarraBibliotecario.Location = new Point(604, 17);
            tituloBarraBibliotecario.Name = "tituloBarraBibliotecario";
            tituloBarraBibliotecario.Size = new Size(123, 27);
            tituloBarraBibliotecario.TabIndex = 2;
            tituloBarraBibliotecario.Text = "Bibliotecario";
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
            btnMinimizar.Click += btnMinimizar_Click;
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
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnelMenu
            // 
            pnelMenu.BackColor = Color.FromArgb(184, 149, 93);
            pnelMenu.Controls.Add(panel2);
            pnelMenu.Controls.Add(button7);
            pnelMenu.Controls.Add(panel1);
            pnelMenu.Controls.Add(panel7);
            pnelMenu.Controls.Add(btnLibros);
            pnelMenu.Controls.Add(lblTituloApp);
            pnelMenu.Controls.Add(imgLogo);
            pnelMenu.Dock = DockStyle.Left;
            pnelMenu.Location = new Point(0, 65);
            pnelMenu.Name = "pnelMenu";
            pnelMenu.Size = new Size(280, 715);
            pnelMenu.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 155, 66);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 155, 66);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(521, 158);
            button1.Name = "button1";
            button1.Size = new Size(268, 60);
            button1.TabIndex = 6;
            button1.Text = "Gestion Usuarios";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 165, 36);
            panel1.Location = new Point(0, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(13, 59);
            panel1.TabIndex = 2;
            // 
            // btnDelBook
            // 
            btnDelBook.BackColor = Color.FromArgb(230, 165, 36);
            btnDelBook.Dock = DockStyle.Top;
            btnDelBook.FlatAppearance.BorderSize = 0;
            btnDelBook.FlatStyle = FlatStyle.Flat;
            btnDelBook.Image = (Image)resources.GetObject("btnDelBook.Image");
            btnDelBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelBook.Location = new Point(0, 80);
            btnDelBook.Name = "btnDelBook";
            btnDelBook.Padding = new Padding(30, 0, 70, 0);
            btnDelBook.Size = new Size(280, 40);
            btnDelBook.TabIndex = 4;
            btnDelBook.Text = "Eliminar Libro";
            btnDelBook.TextAlign = ContentAlignment.MiddleRight;
            btnDelBook.UseVisualStyleBackColor = false;
            // 
            // btnFindBook
            // 
            btnFindBook.BackColor = Color.FromArgb(230, 165, 36);
            btnFindBook.Dock = DockStyle.Top;
            btnFindBook.FlatAppearance.BorderSize = 0;
            btnFindBook.FlatStyle = FlatStyle.Flat;
            btnFindBook.Image = (Image)resources.GetObject("btnFindBook.Image");
            btnFindBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnFindBook.Location = new Point(0, 0);
            btnFindBook.Name = "btnFindBook";
            btnFindBook.Padding = new Padding(30, 0, 82, 0);
            btnFindBook.Size = new Size(280, 40);
            btnFindBook.TabIndex = 3;
            btnFindBook.Text = "Buscar Libro";
            btnFindBook.TextAlign = ContentAlignment.MiddleRight;
            btnFindBook.UseVisualStyleBackColor = false;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.FromArgb(230, 165, 36);
            btnAddBook.Dock = DockStyle.Top;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Image = (Image)resources.GetObject("btnAddBook.Image");
            btnAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBook.Location = new Point(0, 40);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Padding = new Padding(30, 0, 71, 0);
            btnAddBook.Size = new Size(280, 40);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Agregar Libro";
            btnAddBook.TextAlign = ContentAlignment.MiddleRight;
            btnAddBook.UseVisualStyleBackColor = false;
            // 
            // lblTituloApp
            // 
            lblTituloApp.AutoSize = true;
            lblTituloApp.Font = new Font("Aston Script Bold", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloApp.Location = new Point(27, 41);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(221, 69);
            lblTituloApp.TabIndex = 5;
            lblTituloApp.Text = "Biblioteca";
            // 
            // imgLogo
            // 
            imgLogo.Dock = DockStyle.Top;
            imgLogo.Location = new Point(0, 0);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(280, 153);
            imgLogo.TabIndex = 1;
            imgLogo.TabStop = false;
            // 
            // btnLibros
            // 
            btnLibros.BackgroundImageLayout = ImageLayout.Zoom;
            btnLibros.Cursor = Cursors.Hand;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 155, 66);
            btnLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 155, 66);
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 12F);
            btnLibros.Image = (Image)resources.GetObject("btnLibros.Image");
            btnLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibros.Location = new Point(0, 153);
            btnLibros.Name = "btnLibros";
            btnLibros.Padding = new Padding(20, 0, 0, 0);
            btnLibros.Size = new Size(280, 60);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Gestion Libros";
            btnLibros.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(202, 155, 66);
            panel7.Controls.Add(btnDelBook);
            panel7.Controls.Add(btnAddBook);
            panel7.Controls.Add(btnFindBook);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 213);
            panel7.Name = "panel7";
            panel7.Size = new Size(280, 122);
            panel7.TabIndex = 10;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Cursor = Cursors.Hand;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 155, 66);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 155, 66);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 11F);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 335);
            button7.Name = "button7";
            button7.Size = new Size(280, 60);
            button7.TabIndex = 7;
            button7.Text = "Gestion Usuarios";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 125);
            panel2.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 165, 36);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(280, 40);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // mainFormBibliotecario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1380, 780);
            Controls.Add(pnelMenu);
            Controls.Add(brraTitulo);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainFormBibliotecario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainFormBibliotecario";
            brraTitulo.ResumeLayout(false);
            brraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            pnelMenu.ResumeLayout(false);
            pnelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel brraTitulo;
        private Panel pnelMenu;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Button btnLibros;
        private PictureBox imgLogo;
        private Label lblTituloApp;
        private Label tituloBarraBibliotecario;
        private Panel panel1;
        private Button btnAddBook;
        private Button btnDelBook;
        private Button btnFindBook;
        private Button button1;
        private Panel panel2;
        private Button button7;
        private Panel panel7;
        private Button button2;
    }
}