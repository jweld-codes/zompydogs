﻿namespace zompyDogs
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            dgvUsuarios = new DataGridView();
            pictureBox1 = new PictureBox();
            txtBuscarUsuario = new TextBox();
            groupBox1 = new GroupBox();
            dgvProveedor = new DataGridView();
            dgvEmpleados = new DataGridView();
            dgvAdminis = new DataGridView();
            btnNext = new Button();
            btnAtras = new Button();
            btnAgregarNuevoUsuario = new Button();
            lblTituloRegistroPanel = new Label();
            topBarMenu = new Panel();
            btnPrveedores = new Button();
            btnEmpleadoPanel = new Button();
            btnAdminPanel = new Button();
            pictureBox2 = new PictureBox();
            btnUsuarioPanel = new Button();
            lblTITULO = new Label();
            btnEditarUsuario = new Button();
            btnEliminarUsuario = new Button();
            lblBreadCrumbUser = new Label();
            label1 = new Label();
            btnVisualizarRegistro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdminis).BeginInit();
            topBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToOrderColumns = true;
            dgvUsuarios.AllowUserToResizeColumns = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.BackgroundColor = SystemColors.Window;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(15, 26);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(800, 338);
            dgvUsuarios.TabIndex = 69;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.lupa;
            pictureBox1.Location = new Point(339, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(379, 99);
            txtBuscarUsuario.Multiline = true;
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.PlaceholderText = "Buscar Usuario";
            txtBuscarUsuario.Size = new Size(479, 27);
            txtBuscarUsuario.TabIndex = 64;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvProveedor);
            groupBox1.Controls.Add(dgvEmpleados);
            groupBox1.Controls.Add(dgvAdminis);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnAtras);
            groupBox1.Controls.Add(dgvUsuarios);
            groupBox1.Location = new Point(21, 279);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(837, 405);
            groupBox1.TabIndex = 90;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.AllowUserToDeleteRows = false;
            dgvProveedor.AllowUserToOrderColumns = true;
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.AllowUserToResizeRows = false;
            dgvProveedor.BackgroundColor = SystemColors.Window;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Location = new Point(15, 26);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.ReadOnly = true;
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.Size = new Size(800, 338);
            dgvProveedor.TabIndex = 74;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AllowUserToOrderColumns = true;
            dgvEmpleados.AllowUserToResizeColumns = false;
            dgvEmpleados.AllowUserToResizeRows = false;
            dgvEmpleados.BackgroundColor = SystemColors.Window;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(15, 26);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(800, 338);
            dgvEmpleados.TabIndex = 73;
            // 
            // dgvAdminis
            // 
            dgvAdminis.AllowUserToAddRows = false;
            dgvAdminis.AllowUserToDeleteRows = false;
            dgvAdminis.AllowUserToOrderColumns = true;
            dgvAdminis.AllowUserToResizeColumns = false;
            dgvAdminis.AllowUserToResizeRows = false;
            dgvAdminis.BackgroundColor = SystemColors.Window;
            dgvAdminis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminis.Location = new Point(15, 26);
            dgvAdminis.Name = "dgvAdminis";
            dgvAdminis.ReadOnly = true;
            dgvAdminis.RowHeadersWidth = 51;
            dgvAdminis.Size = new Size(800, 338);
            dgvAdminis.TabIndex = 72;
            // 
            // btnNext
            // 
            btnNext.Image = Properties.Resources.arrow;
            btnNext.Location = new Point(51, 370);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 29);
            btnNext.TabIndex = 71;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            btnAtras.Image = Properties.Resources.left_arrow;
            btnAtras.Location = new Point(15, 370);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(36, 29);
            btnAtras.TabIndex = 70;
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnAgregarNuevoUsuario
            // 
            btnAgregarNuevoUsuario.Image = Properties.Resources.plus;
            btnAgregarNuevoUsuario.Location = new Point(36, 189);
            btnAgregarNuevoUsuario.Name = "btnAgregarNuevoUsuario";
            btnAgregarNuevoUsuario.Size = new Size(72, 72);
            btnAgregarNuevoUsuario.TabIndex = 95;
            btnAgregarNuevoUsuario.UseVisualStyleBackColor = true;
            btnAgregarNuevoUsuario.Click += btnAgregarNuevoUsuario_Click;
            // 
            // lblTituloRegistroPanel
            // 
            lblTituloRegistroPanel.AutoSize = true;
            lblTituloRegistroPanel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRegistroPanel.Location = new Point(36, 141);
            lblTituloRegistroPanel.Name = "lblTituloRegistroPanel";
            lblTituloRegistroPanel.Size = new Size(321, 41);
            lblTituloRegistroPanel.TabIndex = 96;
            lblTituloRegistroPanel.Text = "Registros de Usuarios";
            // 
            // topBarMenu
            // 
            topBarMenu.BackColor = Color.FromArgb(31, 19, 10);
            topBarMenu.Controls.Add(btnPrveedores);
            topBarMenu.Controls.Add(btnEmpleadoPanel);
            topBarMenu.Controls.Add(btnAdminPanel);
            topBarMenu.Controls.Add(pictureBox2);
            topBarMenu.Controls.Add(btnUsuarioPanel);
            topBarMenu.Controls.Add(lblTITULO);
            topBarMenu.Dock = DockStyle.Top;
            topBarMenu.Location = new Point(0, 0);
            topBarMenu.Name = "topBarMenu";
            topBarMenu.Size = new Size(901, 81);
            topBarMenu.TabIndex = 97;
            // 
            // btnPrveedores
            // 
            btnPrveedores.FlatAppearance.BorderSize = 0;
            btnPrveedores.FlatStyle = FlatStyle.Flat;
            btnPrveedores.ForeColor = SystemColors.ControlLightLight;
            btnPrveedores.Location = new Point(706, 45);
            btnPrveedores.Name = "btnPrveedores";
            btnPrveedores.Size = new Size(152, 36);
            btnPrveedores.TabIndex = 101;
            btnPrveedores.Text = "Proveedores";
            btnPrveedores.UseVisualStyleBackColor = true;
            //btnPrveedores.Click += btnPrveedores_Click;
            // 
            // btnEmpleadoPanel
            // 
            btnEmpleadoPanel.FlatAppearance.BorderSize = 0;
            btnEmpleadoPanel.FlatStyle = FlatStyle.Flat;
            btnEmpleadoPanel.ForeColor = SystemColors.ControlLightLight;
            btnEmpleadoPanel.Location = new Point(555, 47);
            btnEmpleadoPanel.Name = "btnEmpleadoPanel";
            btnEmpleadoPanel.Size = new Size(152, 36);
            btnEmpleadoPanel.TabIndex = 100;
            btnEmpleadoPanel.Text = "Empleados";
            btnEmpleadoPanel.UseVisualStyleBackColor = true;
          //  btnEmpleadoPanel.Click += btnEmpleadoPanel_Click;
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.FlatAppearance.BorderSize = 0;
            btnAdminPanel.FlatStyle = FlatStyle.Flat;
            btnAdminPanel.ForeColor = SystemColors.ControlLightLight;
            btnAdminPanel.Location = new Point(396, 47);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(152, 36);
            btnAdminPanel.TabIndex = 99;
            btnAdminPanel.Text = "Administradores";
            btnAdminPanel.UseVisualStyleBackColor = true;
          //  btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 97;
            pictureBox2.TabStop = false;
            // 
            // btnUsuarioPanel
            // 
            btnUsuarioPanel.BackColor = Color.White;
            btnUsuarioPanel.FlatAppearance.BorderSize = 0;
            btnUsuarioPanel.FlatStyle = FlatStyle.Flat;
            btnUsuarioPanel.ForeColor = SystemColors.ActiveCaptionText;
            btnUsuarioPanel.Location = new Point(237, 47);
            btnUsuarioPanel.Name = "btnUsuarioPanel";
            btnUsuarioPanel.Size = new Size(152, 36);
            btnUsuarioPanel.TabIndex = 98;
            btnUsuarioPanel.Text = "Usuarios";
            btnUsuarioPanel.UseVisualStyleBackColor = false;
          //  btnUsuarioPanel.Click += btnUsuarioPanel_Click;
            // 
            // lblTITULO
            // 
            lblTITULO.AutoSize = true;
            lblTITULO.BackColor = Color.Transparent;
            lblTITULO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTITULO.ForeColor = Color.Transparent;
            lblTITULO.Location = new Point(109, 34);
            lblTITULO.Name = "lblTITULO";
            lblTITULO.Size = new Size(78, 31);
            lblTITULO.TabIndex = 3;
            lblTITULO.Text = "STAFF";
            lblTITULO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Image = Properties.Resources.pen__1_;
            btnEditarUsuario.Location = new Point(182, 189);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(72, 72);
            btnEditarUsuario.TabIndex = 100;
            btnEditarUsuario.UseVisualStyleBackColor = true;
          //  btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Image = Properties.Resources.bin;
            btnEliminarUsuario.Location = new Point(260, 189);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(72, 72);
            btnEliminarUsuario.TabIndex = 99;
            btnEliminarUsuario.UseVisualStyleBackColor = true;
          //  btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // lblBreadCrumbUser
            // 
            lblBreadCrumbUser.AutoSize = true;
            lblBreadCrumbUser.BackColor = Color.Transparent;
            lblBreadCrumbUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreadCrumbUser.ForeColor = Color.LimeGreen;
            lblBreadCrumbUser.Location = new Point(101, 99);
            lblBreadCrumbUser.Name = "lblBreadCrumbUser";
            lblBreadCrumbUser.Size = new Size(84, 20);
            lblBreadCrumbUser.TabIndex = 98;
            lblBreadCrumbUser.Text = "USUARIOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 98);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 97;
            label1.Text = "STAFF /";
            // 
            // btnVisualizarRegistro
            // 
            btnVisualizarRegistro.Image = Properties.Resources.file__1_;
            btnVisualizarRegistro.Location = new Point(109, 189);
            btnVisualizarRegistro.Name = "btnVisualizarRegistro";
            btnVisualizarRegistro.Size = new Size(72, 72);
            btnVisualizarRegistro.TabIndex = 116;
            btnVisualizarRegistro.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(901, 725);
            Controls.Add(btnVisualizarRegistro);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(topBarMenu);
            Controls.Add(lblBreadCrumbUser);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnAgregarNuevoUsuario);
            Controls.Add(lblTituloRegistroPanel);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscarUsuario);
            Name = "Usuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdminis).EndInit();
            topBarMenu.ResumeLayout(false);
            topBarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvUsuarios;
        private PictureBox pictureBox1;
        private TextBox txtBuscarUsuario;
        private GroupBox groupBox1;
        private Button btnNext;
        private Button btnAtras;
        private Button btnAgregarNuevoUsuario;
        private Label lblTituloRegistroPanel;
        private Panel topBarMenu;
        private Label lblTITULO;
        private Button btnUsuarioPanel;
        private PictureBox pictureBox2;
        private Label lblBreadCrumbUser;
        private Label label1;
        private Button btnEditarUsuario;
        private Button btnEliminarUsuario;
        private Button btnEmpleadoPanel;
        private Button btnAdminPanel;
        private DataGridView dgvEmpleados;
        private DataGridView dgvAdminis;
        private DataGridView dgvProveedor;
        private Button btnPrveedores;
        private Button btnVisualizarRegistro;
    }
}