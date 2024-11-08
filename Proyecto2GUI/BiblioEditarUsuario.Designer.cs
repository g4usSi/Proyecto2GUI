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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            lblRecibirRol = new Label();
            label3 = new Label();
            btnEliminarUsuario = new Button();
            lblRecibirIDUser = new Label();
            lblTituloID = new Label();
            btnEditarUsuario = new Button();
            btnBuscarUsuario = new Button();
            RecibirBuscar = new TextBox();
            label5 = new Label();
            RecibirContraseña = new TextBox();
            RecibirNombre = new TextBox();
            label4 = new Label();
            label2 = new Label();
            lblMensajeUsuario = new Label();
            datosUsuarios = new DataGridView();
            ISBN = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Aston Script Bold", 22F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 87);
            label1.TabIndex = 9;
            label1.Text = "Editar / Eliminar Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRecibirRol);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnEliminarUsuario);
            panel1.Controls.Add(lblRecibirIDUser);
            panel1.Controls.Add(lblTituloID);
            panel1.Controls.Add(btnEditarUsuario);
            panel1.Controls.Add(btnBuscarUsuario);
            panel1.Controls.Add(RecibirBuscar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(RecibirContraseña);
            panel1.Controls.Add(RecibirNombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 217);
            panel1.TabIndex = 10;
            // 
            // lblRecibirRol
            // 
            lblRecibirRol.AutoSize = true;
            lblRecibirRol.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirRol.Location = new Point(324, 176);
            lblRecibirRol.Name = "lblRecibirRol";
            lblRecibirRol.Size = new Size(25, 27);
            lblRecibirRol.TabIndex = 25;
            lblRecibirRol.Text = "R";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label3.Location = new Point(263, 176);
            label3.Name = "label3";
            label3.Size = new Size(46, 27);
            label3.TabIndex = 24;
            label3.Text = "Rol:";
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
            btnEliminarUsuario.Location = new Point(730, 138);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(141, 40);
            btnEliminarUsuario.TabIndex = 16;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // lblRecibirIDUser
            // 
            lblRecibirIDUser.AutoSize = true;
            lblRecibirIDUser.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblRecibirIDUser.Location = new Point(446, 54);
            lblRecibirIDUser.Name = "lblRecibirIDUser";
            lblRecibirIDUser.Size = new Size(33, 27);
            lblRecibirIDUser.TabIndex = 18;
            lblRecibirIDUser.Text = "ID";
            // 
            // lblTituloID
            // 
            lblTituloID.AutoSize = true;
            lblTituloID.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblTituloID.Location = new Point(373, 54);
            lblTituloID.Name = "lblTituloID";
            lblTituloID.Size = new Size(33, 27);
            lblTituloID.TabIndex = 17;
            lblTituloID.Text = "ID";
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
            btnEditarUsuario.Location = new Point(738, 86);
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
            btnBuscarUsuario.Location = new Point(722, 16);
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
            RecibirBuscar.Location = new Point(263, 22);
            RecibirBuscar.Name = "RecibirBuscar";
            RecibirBuscar.Size = new Size(440, 27);
            RecibirBuscar.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(141, 20);
            label5.Name = "label5";
            label5.Size = new Size(112, 27);
            label5.TabIndex = 12;
            label5.Text = "Ingrese ID:";
            // 
            // RecibirContraseña
            // 
            RecibirContraseña.BorderStyle = BorderStyle.None;
            RecibirContraseña.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirContraseña.Location = new Point(386, 141);
            RecibirContraseña.Name = "RecibirContraseña";
            RecibirContraseña.Size = new Size(280, 24);
            RecibirContraseña.TabIndex = 7;
            // 
            // RecibirNombre
            // 
            RecibirNombre.BorderStyle = BorderStyle.None;
            RecibirNombre.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirNombre.Location = new Point(386, 101);
            RecibirNombre.Name = "RecibirNombre";
            RecibirNombre.Size = new Size(280, 24);
            RecibirNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label4.Location = new Point(255, 138);
            label4.Name = "label4";
            label4.Size = new Size(125, 27);
            label4.TabIndex = 2;
            label4.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label2.Location = new Point(255, 98);
            label2.Name = "label2";
            label2.Size = new Size(94, 27);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // lblMensajeUsuario
            // 
            lblMensajeUsuario.Dock = DockStyle.Bottom;
            lblMensajeUsuario.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeUsuario.ForeColor = Color.DarkRed;
            lblMensajeUsuario.Location = new Point(0, 518);
            lblMensajeUsuario.Name = "lblMensajeUsuario";
            lblMensajeUsuario.Size = new Size(982, 35);
            lblMensajeUsuario.TabIndex = 23;
            lblMensajeUsuario.Text = "Se ha eliminado al usuario";
            lblMensajeUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datosUsuarios
            // 
            datosUsuarios.AllowUserToAddRows = false;
            datosUsuarios.AllowUserToDeleteRows = false;
            datosUsuarios.AllowUserToResizeColumns = false;
            datosUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datosUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datosUsuarios.BackgroundColor = SystemColors.Control;
            datosUsuarios.BorderStyle = BorderStyle.None;
            datosUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 53, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(184, 149, 93);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datosUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datosUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosUsuarios.Columns.AddRange(new DataGridViewColumn[] { ISBN, Titulo, Autor, Rol });
            datosUsuarios.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datosUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            datosUsuarios.EnableHeadersVisualStyles = false;
            datosUsuarios.GridColor = Color.FromArgb(49, 53, 56);
            datosUsuarios.Location = new Point(225, 310);
            datosUsuarios.Name = "datosUsuarios";
            datosUsuarios.ReadOnly = true;
            datosUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 165, 36);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            datosUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            datosUsuarios.RowHeadersVisible = false;
            datosUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Small", 10.2F);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 165, 36);
            datosUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            datosUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datosUsuarios.Size = new Size(532, 205);
            datosUsuarios.TabIndex = 27;
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ID";
            ISBN.MinimumWidth = 6;
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            ISBN.Width = 60;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Nombre";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            Titulo.Width = 116;
            // 
            // Autor
            // 
            Autor.HeaderText = "Contraseña";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 144;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 68;
            // 
            // BiblioEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(datosUsuarios);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lblMensajeUsuario);
            Name = "BiblioEditarUsuario";
            Text = "BiblioEditarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datosUsuarios).EndInit();
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
        private DataGridView datosUsuarios;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Rol;
    }
}