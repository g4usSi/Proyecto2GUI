namespace Proyecto2GUI
{
    partial class BiblioEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioEditarUsuario));
            label1 = new Label();
            panel1 = new Panel();
            lblRecibirRol = new Label();
            label3 = new Label();
            lblMensajeUsuario = new Label();
            lblRecibirIDUser = new Label();
            lblTituloID = new Label();
            btnEliminarUsuario = new Button();
            btnEditarUsuario = new Button();
            btnBuscarUsuario = new Button();
            RecibirBuscar = new TextBox();
            label5 = new Label();
            RecibirContraseña = new TextBox();
            RecibirNombre = new TextBox();
            label4 = new Label();
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
            label1.Text = "Editar / Eliminar Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRecibirRol);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblMensajeUsuario);
            panel1.Controls.Add(lblRecibirIDUser);
            panel1.Controls.Add(lblTituloID);
            panel1.Controls.Add(btnEliminarUsuario);
            panel1.Controls.Add(btnEditarUsuario);
            panel1.Controls.Add(btnBuscarUsuario);
            panel1.Controls.Add(RecibirBuscar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(RecibirContraseña);
            panel1.Controls.Add(RecibirNombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 404);
            panel1.TabIndex = 10;
            // 
            // lblRecibirRol
            // 
            lblRecibirRol.AutoSize = true;
            lblRecibirRol.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirRol.Location = new Point(400, 218);
            lblRecibirRol.Name = "lblRecibirRol";
            lblRecibirRol.Size = new Size(25, 27);
            lblRecibirRol.TabIndex = 25;
            lblRecibirRol.Text = "R";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label3.Location = new Point(270, 218);
            label3.Name = "label3";
            label3.Size = new Size(46, 27);
            label3.TabIndex = 24;
            label3.Text = "Rol:";
            // 
            // lblMensajeUsuario
            // 
            lblMensajeUsuario.Dock = DockStyle.Bottom;
            lblMensajeUsuario.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeUsuario.ForeColor = Color.DarkRed;
            lblMensajeUsuario.Location = new Point(0, 308);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 96);
            lblMensajeUsuario.TabIndex = 23;
            lblMensajeUsuario.Text = "Se ha eliminado al usuario";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecibirIDUser
            // 
            lblRecibirIDUser.AutoSize = true;
            lblRecibirIDUser.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirIDUser.Location = new Point(446, 80);
            lblRecibirIDUser.Name = "lblRecibirIDUser";
            lblRecibirIDUser.Size = new Size(33, 27);
            lblRecibirIDUser.TabIndex = 18;
            lblRecibirIDUser.Text = "ID";
            // 
            // lblTituloID
            // 
            lblTituloID.AutoSize = true;
            lblTituloID.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblTituloID.Location = new Point(373, 80);
            lblTituloID.Name = "lblTituloID";
            lblTituloID.Size = new Size(33, 27);
            lblTituloID.TabIndex = 17;
            lblTituloID.Text = "ID";
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.Maroon;
            btnEliminarUsuario.Cursor = Cursors.Hand;
            btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            btnEliminarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnEliminarUsuario.FlatStyle = FlatStyle.Flat;
            btnEliminarUsuario.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnEliminarUsuario.ForeColor = Color.White;
            btnEliminarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarUsuario.Location = new Point(509, 265);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(141, 40);
            btnEliminarUsuario.TabIndex = 16;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.FromArgb(230, 165, 36);
            btnEditarUsuario.Cursor = Cursors.Hand;
            btnEditarUsuario.FlatAppearance.BorderSize = 0;
            btnEditarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnEditarUsuario.FlatStyle = FlatStyle.Flat;
            btnEditarUsuario.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnEditarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarUsuario.Location = new Point(355, 265);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(124, 40);
            btnEditarUsuario.TabIndex = 15;
            btnEditarUsuario.Text = "Editar Usuario";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.FromArgb(230, 165, 36);
            btnBuscarUsuario.Cursor = Cursors.Hand;
            btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            btnBuscarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnBuscarUsuario.FlatStyle = FlatStyle.Flat;
            btnBuscarUsuario.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnBuscarUsuario.Image = (Image)resources.GetObject("btnBuscarUsuario.Image");
            btnBuscarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarUsuario.Location = new Point(722, 24);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(156, 40);
            btnBuscarUsuario.TabIndex = 14;
            btnBuscarUsuario.Text = "Buscar Usuario";
            btnBuscarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarLibro_Click;
            // 
            // RecibirBuscar
            // 
            RecibirBuscar.BorderStyle = BorderStyle.None;
            RecibirBuscar.Cursor = Cursors.IBeam;
            RecibirBuscar.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecibirBuscar.Location = new Point(263, 30);
            RecibirBuscar.Name = "RecibirBuscar";
            RecibirBuscar.Size = new Size(440, 27);
            RecibirBuscar.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(141, 28);
            label5.Name = "label5";
            label5.Size = new Size(112, 27);
            label5.TabIndex = 12;
            label5.Text = "Ingrese ID:";
            // 
            // RecibirContraseña
            // 
            RecibirContraseña.BorderStyle = BorderStyle.None;
            RecibirContraseña.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirContraseña.Location = new Point(400, 177);
            RecibirContraseña.Name = "RecibirContraseña";
            RecibirContraseña.Size = new Size(280, 24);
            RecibirContraseña.TabIndex = 7;
            // 
            // RecibirNombre
            // 
            RecibirNombre.BorderStyle = BorderStyle.None;
            RecibirNombre.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirNombre.Location = new Point(400, 134);
            RecibirNombre.Name = "RecibirNombre";
            RecibirNombre.Size = new Size(280, 24);
            RecibirNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label4.Location = new Point(270, 174);
            label4.Name = "label4";
            label4.Size = new Size(125, 27);
            label4.TabIndex = 2;
            label4.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label2.Location = new Point(270, 131);
            label2.Name = "label2";
            label2.Size = new Size(94, 27);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // BiblioEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BiblioEditarUsuario";
            Text = "BiblioEditarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox RecibirContraseña;
        private TextBox RecibirNombre;
        private Label label4;
        private Label label2;
        private Button btnBuscarUsuario;
        private TextBox RecibirBuscar;
        private Label label5;
        private Label lblRecibirIDUser;
        private Label lblTituloID;
        private Button btnEliminarUsuario;
        private Button btnEditarUsuario;
        private Label lblMensajeUsuario;
        private Label lblRecibirRol;
        private Label label3;
    }
}