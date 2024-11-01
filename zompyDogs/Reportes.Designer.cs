namespace zompyDogs
{
    partial class Reportes
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
            topBarMenu = new Panel();
            pictureBox2 = new PictureBox();
            btnUsuarioPanel = new Button();
            lblTITULO = new Label();
            button1 = new Button();
            gbxActividades = new GroupBox();
            dgvActividadesAuditoria = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            btnVisualizarRegistro = new Button();
            btnEditarUsuario = new Button();
            btnEliminarUsuario = new Button();
            lblBreadCrumbUser = new Label();
            label1 = new Label();
            btnAgregarNuevoUsuario = new Button();
            lblTituloRegistroPanel = new Label();
            pictureBox1 = new PictureBox();
            txtBuscarUsuario = new TextBox();
            topBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbxActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividadesAuditoria).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // topBarMenu
            // 
            topBarMenu.BackColor = Color.FromArgb(31, 19, 10);
            topBarMenu.Controls.Add(button1);
            topBarMenu.Controls.Add(pictureBox2);
            topBarMenu.Controls.Add(btnUsuarioPanel);
            topBarMenu.Controls.Add(lblTITULO);
            topBarMenu.Dock = DockStyle.Top;
            topBarMenu.Location = new Point(0, 0);
            topBarMenu.Name = "topBarMenu";
            topBarMenu.Size = new Size(901, 81);
            topBarMenu.TabIndex = 107;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.diet1;
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
            btnUsuarioPanel.Location = new Point(579, 45);
            btnUsuarioPanel.Name = "btnUsuarioPanel";
            btnUsuarioPanel.Size = new Size(152, 36);
            btnUsuarioPanel.TabIndex = 98;
            btnUsuarioPanel.Text = "INICIO";
            btnUsuarioPanel.UseVisualStyleBackColor = false;
            // 
            // lblTITULO
            // 
            lblTITULO.AutoSize = true;
            lblTITULO.BackColor = Color.Transparent;
            lblTITULO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTITULO.ForeColor = Color.Transparent;
            lblTITULO.Location = new Point(109, 34);
            lblTITULO.Name = "lblTITULO";
            lblTITULO.Size = new Size(125, 31);
            lblTITULO.TabIndex = 3;
            lblTITULO.Text = "REPORTES";
            lblTITULO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(737, 45);
            button1.Name = "button1";
            button1.Size = new Size(152, 36);
            button1.TabIndex = 99;
            button1.Text = "Facturas";
            button1.UseVisualStyleBackColor = false;
            // 
            // gbxActividades
            // 
            gbxActividades.Controls.Add(dgvActividadesAuditoria);
            gbxActividades.Location = new Point(12, 24);
            gbxActividades.Name = "gbxActividades";
            gbxActividades.Size = new Size(865, 408);
            gbxActividades.TabIndex = 118;
            gbxActividades.TabStop = false;
            gbxActividades.Text = "Actividades";
            // 
            // dgvActividadesAuditoria
            // 
            dgvActividadesAuditoria.AllowUserToAddRows = false;
            dgvActividadesAuditoria.AllowUserToDeleteRows = false;
            dgvActividadesAuditoria.AllowUserToOrderColumns = true;
            dgvActividadesAuditoria.AllowUserToResizeColumns = false;
            dgvActividadesAuditoria.AllowUserToResizeRows = false;
            dgvActividadesAuditoria.BackgroundColor = SystemColors.Window;
            dgvActividadesAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividadesAuditoria.Location = new Point(23, 32);
            dgvActividadesAuditoria.Name = "dgvActividadesAuditoria";
            dgvActividadesAuditoria.ReadOnly = true;
            dgvActividadesAuditoria.RowHeadersWidth = 51;
            dgvActividadesAuditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividadesAuditoria.Size = new Size(814, 331);
            dgvActividadesAuditoria.TabIndex = 70;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVisualizarRegistro);
            panel1.Controls.Add(btnEditarUsuario);
            panel1.Controls.Add(btnEliminarUsuario);
            panel1.Controls.Add(lblBreadCrumbUser);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAgregarNuevoUsuario);
            panel1.Controls.Add(lblTituloRegistroPanel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtBuscarUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 218);
            panel1.TabIndex = 119;
            // 
            // panel2
            // 
            panel2.Controls.Add(gbxActividades);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 299);
            panel2.Name = "panel2";
            panel2.Size = new Size(901, 426);
            panel2.TabIndex = 120;
            // 
            // btnVisualizarRegistro
            // 
            btnVisualizarRegistro.Image = Properties.Resources.file__1_;
            btnVisualizarRegistro.Location = new Point(114, 122);
            btnVisualizarRegistro.Name = "btnVisualizarRegistro";
            btnVisualizarRegistro.Size = new Size(72, 72);
            btnVisualizarRegistro.TabIndex = 124;
            btnVisualizarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.FlatAppearance.BorderSize = 0;
            btnEditarUsuario.Image = Properties.Resources.pen__1_;
            btnEditarUsuario.Location = new Point(192, 122);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(72, 72);
            btnEditarUsuario.TabIndex = 123;
            btnEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            btnEliminarUsuario.Image = Properties.Resources.bin;
            btnEliminarUsuario.Location = new Point(270, 122);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(72, 72);
            btnEliminarUsuario.TabIndex = 122;
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // lblBreadCrumbUser
            // 
            lblBreadCrumbUser.AutoSize = true;
            lblBreadCrumbUser.BackColor = Color.Transparent;
            lblBreadCrumbUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreadCrumbUser.ForeColor = Color.LimeGreen;
            lblBreadCrumbUser.Location = new Point(129, 18);
            lblBreadCrumbUser.Name = "lblBreadCrumbUser";
            lblBreadCrumbUser.Size = new Size(56, 20);
            lblBreadCrumbUser.TabIndex = 121;
            lblBreadCrumbUser.Text = "INICIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 17);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 120;
            label1.Text = "REPORTES /";
            // 
            // btnAgregarNuevoUsuario
            // 
            btnAgregarNuevoUsuario.FlatAppearance.BorderSize = 0;
            btnAgregarNuevoUsuario.Image = Properties.Resources.plus;
            btnAgregarNuevoUsuario.Location = new Point(36, 123);
            btnAgregarNuevoUsuario.Name = "btnAgregarNuevoUsuario";
            btnAgregarNuevoUsuario.Size = new Size(72, 72);
            btnAgregarNuevoUsuario.TabIndex = 118;
            btnAgregarNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // lblTituloRegistroPanel
            // 
            lblTituloRegistroPanel.AutoSize = true;
            lblTituloRegistroPanel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRegistroPanel.Location = new Point(36, 75);
            lblTituloRegistroPanel.Name = "lblTituloRegistroPanel";
            lblTituloRegistroPanel.Size = new Size(165, 41);
            lblTituloRegistroPanel.TabIndex = 119;
            lblTituloRegistroPanel.Text = "REPORTES";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.lupa;
            pictureBox1.Location = new Point(343, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 117;
            pictureBox1.TabStop = false;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(383, 19);
            txtBuscarUsuario.Multiline = true;
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.PlaceholderText = "Buscar Producto";
            txtBuscarUsuario.Size = new Size(479, 27);
            txtBuscarUsuario.TabIndex = 116;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 725);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(topBarMenu);
            Name = "Reportes";
            Text = "Reportes";
            topBarMenu.ResumeLayout(false);
            topBarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbxActividades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActividadesAuditoria).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topBarMenu;
        private PictureBox pictureBox2;
        private Button btnUsuarioPanel;
        private Label lblTITULO;
        public Button button1;
        private GroupBox gbxActividades;
        public DataGridView dgvActividadesAuditoria;
        private Panel panel1;
        private Panel panel2;
        private Button btnVisualizarRegistro;
        private Button btnEditarUsuario;
        private Button btnEliminarUsuario;
        private Label lblBreadCrumbUser;
        private Label label1;
        private Button btnAgregarNuevoUsuario;
        private Label lblTituloRegistroPanel;
        private PictureBox pictureBox1;
        private TextBox txtBuscarUsuario;
    }
}