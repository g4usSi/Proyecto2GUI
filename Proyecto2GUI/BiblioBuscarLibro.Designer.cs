namespace Proyecto2GUI
{
    partial class BiblioBuscarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioBuscarLibro));
            panel1 = new Panel();
            this.btnBuscar = new Button();
            RecibirBuscar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(this.btnBuscar);
            panel1.Controls.Add(RecibirBuscar);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 353);
            panel1.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = Color.FromArgb(230, 165, 36);
            this.btnBuscar.BackgroundImageLayout = ImageLayout.None;
            this.btnBuscar.Cursor = Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            this.btnBuscar.FlatStyle = FlatStyle.Flat;
            this.btnBuscar.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            this.btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            this.btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new Point(725, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new Size(151, 40);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // RecibirBuscar
            // 
            RecibirBuscar.BorderStyle = BorderStyle.None;
            RecibirBuscar.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirBuscar.Location = new Point(269, 40);
            RecibirBuscar.Name = "RecibirBuscar";
            RecibirBuscar.Size = new Size(437, 24);
            RecibirBuscar.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label2.Location = new Point(99, 37);
            label2.Name = "label2";
            label2.Size = new Size(152, 27);
            label2.TabIndex = 0;
            label2.Text = "Titulo o Autor: ";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Aston Script Bold", 22F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 150);
            label1.TabIndex = 10;
            label1.Text = "Buscar Libro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(777, 239);
            dataGridView1.TabIndex = 10;
            // 
            // BiblioBuscarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BiblioBuscarLibro";
            Text = "Buscar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnRegistrarLibro;
        private TextBox RecibirISBN;
        private TextBox RecibirGenero;
        private TextBox RecibirAutor;
        private TextBox RecibirBuscar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}