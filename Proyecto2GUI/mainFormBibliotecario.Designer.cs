﻿namespace Proyecto2GUI
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnDelBook = new Button();
            btnFindBook = new Button();
            btnAddBook = new Button();
            lblTituloApp = new Label();
            pictureBox1 = new PictureBox();
            btnLibros = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            button4 = new Button();
            panel5 = new Panel();
            button2 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            button6 = new Button();
            brraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            pnelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
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
            pnelMenu.Controls.Add(panel6);
            pnelMenu.Controls.Add(panel5);
            pnelMenu.Controls.Add(button2);
            pnelMenu.Controls.Add(panel4);
            pnelMenu.Controls.Add(panel3);
            pnelMenu.Controls.Add(button1);
            pnelMenu.Controls.Add(panel1);
            pnelMenu.Controls.Add(panel2);
            pnelMenu.Controls.Add(lblTituloApp);
            pnelMenu.Controls.Add(pictureBox1);
            pnelMenu.Controls.Add(btnLibros);
            pnelMenu.Dock = DockStyle.Left;
            pnelMenu.Location = new Point(0, 65);
            pnelMenu.Name = "pnelMenu";
            pnelMenu.Size = new Size(280, 715);
            pnelMenu.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 165, 36);
            panel1.Location = new Point(0, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(13, 59);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(202, 155, 66);
            panel2.Controls.Add(btnDelBook);
            panel2.Controls.Add(btnFindBook);
            panel2.Controls.Add(btnAddBook);
            panel2.Location = new Point(12, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 136);
            panel2.TabIndex = 2;
            // 
            // btnDelBook
            // 
            btnDelBook.BackColor = Color.FromArgb(230, 165, 36);
            btnDelBook.FlatAppearance.BorderSize = 0;
            btnDelBook.FlatStyle = FlatStyle.Flat;
            btnDelBook.Image = (Image)resources.GetObject("btnDelBook.Image");
            btnDelBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelBook.Location = new Point(0, 91);
            btnDelBook.Name = "btnDelBook";
            btnDelBook.Padding = new Padding(30, 0, 70, 0);
            btnDelBook.Size = new Size(268, 40);
            btnDelBook.TabIndex = 4;
            btnDelBook.Text = "Eliminar Libro";
            btnDelBook.TextAlign = ContentAlignment.MiddleRight;
            btnDelBook.UseVisualStyleBackColor = false;
            // 
            // btnFindBook
            // 
            btnFindBook.BackColor = Color.FromArgb(230, 165, 36);
            btnFindBook.FlatAppearance.BorderSize = 0;
            btnFindBook.FlatStyle = FlatStyle.Flat;
            btnFindBook.Image = (Image)resources.GetObject("btnFindBook.Image");
            btnFindBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnFindBook.Location = new Point(0, 46);
            btnFindBook.Name = "btnFindBook";
            btnFindBook.Padding = new Padding(30, 0, 82, 0);
            btnFindBook.Size = new Size(268, 40);
            btnFindBook.TabIndex = 3;
            btnFindBook.Text = "Buscar Libro";
            btnFindBook.TextAlign = ContentAlignment.MiddleRight;
            btnFindBook.UseVisualStyleBackColor = false;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.FromArgb(230, 165, 36);
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Image = (Image)resources.GetObject("btnAddBook.Image");
            btnAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBook.Location = new Point(0, 0);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Padding = new Padding(30, 0, 71, 0);
            btnAddBook.Size = new Size(268, 40);
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
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 153);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnLibros
            // 
            btnLibros.BackgroundImageLayout = ImageLayout.Zoom;
            btnLibros.Cursor = Cursors.Hand;
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 155, 66);
            btnLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 155, 66);
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 11F);
            btnLibros.Image = (Image)resources.GetObject("btnLibros.Image");
            btnLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibros.Location = new Point(12, 159);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(268, 60);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Gestion Libros";
            btnLibros.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(230, 165, 36);
            panel3.Location = new Point(0, 355);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 59);
            panel3.TabIndex = 7;
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
            button1.Location = new Point(12, 355);
            button1.Name = "button1";
            button1.Size = new Size(268, 60);
            button1.TabIndex = 6;
            button1.Text = "Gestion Usuarios";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(202, 155, 66);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.Location = new Point(12, 415);
            panel4.Name = "panel4";
            panel4.Size = new Size(268, 92);
            panel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 165, 36);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 46);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 82, 0);
            button3.Size = new Size(268, 40);
            button3.TabIndex = 3;
            button3.Text = "Buscar Libro";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(230, 165, 36);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 71, 0);
            button4.Size = new Size(268, 40);
            button4.TabIndex = 2;
            button4.Text = "Agregar Libro";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(230, 165, 36);
            panel5.Location = new Point(0, 509);
            panel5.Name = "panel5";
            panel5.Size = new Size(13, 59);
            panel5.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 155, 66);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 155, 66);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 509);
            button2.Name = "button2";
            button2.Size = new Size(268, 60);
            button2.TabIndex = 8;
            button2.Text = "Informes";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(202, 155, 66);
            panel6.Controls.Add(button5);
            panel6.Controls.Add(button6);
            panel6.Location = new Point(12, 570);
            panel6.Name = "panel6";
            panel6.Size = new Size(268, 92);
            panel6.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(230, 165, 36);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 46);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 82, 0);
            button5.Size = new Size(268, 40);
            button5.TabIndex = 3;
            button5.Text = "Buscar Libro";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(230, 165, 36);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Padding = new Padding(30, 0, 71, 0);
            button6.Size = new Size(268, 40);
            button6.TabIndex = 2;
            button6.Text = "Agregar Libro";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            // 
            // mainFormBibliotecario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1380, 780);
            Controls.Add(pnelMenu);
            Controls.Add(brraTitulo);
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
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel brraTitulo;
        private Panel pnelMenu;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Button btnLibros;
        private PictureBox pictureBox1;
        private Label lblTituloApp;
        private Label tituloBarraBibliotecario;
        private Panel panel1;
        private Button btnAddBook;
        private Panel panel2;
        private Button btnDelBook;
        private Button btnFindBook;
        private Panel panel3;
        private Button button1;
        private Panel panel4;
        private Button button3;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private Button button6;
        private Panel panel5;
        private Button button2;
    }
}