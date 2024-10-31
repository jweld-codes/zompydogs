namespace zompyDogs
{
    partial class Factura
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
            btnEliminarUsuario = new Button();
            groupBox1 = new GroupBox();
            btnNext = new Button();
            btnAtras = new Button();
            dgvPedidos = new DataGridView();
            lblTituloRegistroPanel = new Label();
            pictureBox1 = new PictureBox();
            txtBuscarUsuario = new TextBox();
            btnVisualizarRegistro = new Button();
            topBarMenu = new Panel();
            btnFactura = new Button();
            pictureBox2 = new PictureBox();
            btnPDVPanel = new Button();
            lblTITULO = new Label();
            btnRefreshDG = new Button();
            cbxFiltro = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            topBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            btnEliminarUsuario.Image = Properties.Resources.bin;
            btnEliminarUsuario.Location = new Point(114, 199);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(72, 72);
            btnEliminarUsuario.TabIndex = 119;
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnAtras);
            groupBox1.Controls.Add(dgvPedidos);
            groupBox1.Location = new Point(21, 289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(837, 405);
            groupBox1.TabIndex = 113;
            groupBox1.TabStop = false;
            groupBox1.Text = "Facturas";
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
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AllowUserToOrderColumns = true;
            dgvPedidos.AllowUserToResizeColumns = false;
            dgvPedidos.AllowUserToResizeRows = false;
            dgvPedidos.BackgroundColor = SystemColors.Window;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(15, 26);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(800, 338);
            dgvPedidos.TabIndex = 69;
            // 
            // lblTituloRegistroPanel
            // 
            lblTituloRegistroPanel.AutoSize = true;
            lblTituloRegistroPanel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRegistroPanel.Location = new Point(36, 151);
            lblTituloRegistroPanel.Name = "lblTituloRegistroPanel";
            lblTituloRegistroPanel.Size = new Size(316, 41);
            lblTituloRegistroPanel.TabIndex = 115;
            lblTituloRegistroPanel.Text = "Registros de Facturas";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.lupa;
            pictureBox1.Location = new Point(339, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 112;
            pictureBox1.TabStop = false;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(379, 109);
            txtBuscarUsuario.Multiline = true;
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.PlaceholderText = "Buscar Por Codigo";
            txtBuscarUsuario.Size = new Size(479, 27);
            txtBuscarUsuario.TabIndex = 111;
            // 
            // btnVisualizarRegistro
            // 
            btnVisualizarRegistro.Image = Properties.Resources.file__1_;
            btnVisualizarRegistro.Location = new Point(36, 199);
            btnVisualizarRegistro.Name = "btnVisualizarRegistro";
            btnVisualizarRegistro.Size = new Size(72, 72);
            btnVisualizarRegistro.TabIndex = 121;
            btnVisualizarRegistro.UseVisualStyleBackColor = true;
            // 
            // topBarMenu
            // 
            topBarMenu.BackColor = Color.FromArgb(31, 19, 10);
            topBarMenu.Controls.Add(btnFactura);
            topBarMenu.Controls.Add(pictureBox2);
            topBarMenu.Controls.Add(btnPDVPanel);
            topBarMenu.Controls.Add(lblTITULO);
            topBarMenu.Dock = DockStyle.Top;
            topBarMenu.Location = new Point(0, 0);
            topBarMenu.Name = "topBarMenu";
            topBarMenu.Size = new Size(901, 81);
            topBarMenu.TabIndex = 122;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.White;
            btnFactura.FlatAppearance.BorderSize = 0;
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.ForeColor = SystemColors.ActiveCaptionText;
            btnFactura.Location = new Point(716, 45);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(152, 36);
            btnFactura.TabIndex = 99;
            btnFactura.Text = "FACTURAS";
            btnFactura.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.invoice;
            pictureBox2.Location = new Point(36, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 97;
            pictureBox2.TabStop = false;
            // 
            // btnPDVPanel
            // 
            btnPDVPanel.BackColor = Color.Transparent;
            btnPDVPanel.FlatAppearance.BorderSize = 0;
            btnPDVPanel.FlatStyle = FlatStyle.Flat;
            btnPDVPanel.ForeColor = Color.WhiteSmoke;
            btnPDVPanel.Location = new Point(558, 45);
            btnPDVPanel.Name = "btnPDVPanel";
            btnPDVPanel.Size = new Size(152, 36);
            btnPDVPanel.TabIndex = 98;
            btnPDVPanel.Text = "PUNTO DE VENTA";
            btnPDVPanel.UseVisualStyleBackColor = false;
            btnPDVPanel.Click += btnUsuarioPanel_Click;
            // 
            // lblTITULO
            // 
            lblTITULO.AutoSize = true;
            lblTITULO.BackColor = Color.Transparent;
            lblTITULO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTITULO.ForeColor = Color.Transparent;
            lblTITULO.Location = new Point(109, 34);
            lblTITULO.Name = "lblTITULO";
            lblTITULO.Size = new Size(129, 31);
            lblTITULO.TabIndex = 3;
            lblTITULO.Text = "FACTURAS";
            lblTITULO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRefreshDG
            // 
            btnRefreshDG.FlatAppearance.BorderSize = 0;
            btnRefreshDG.FlatStyle = FlatStyle.Flat;
            btnRefreshDG.Image = Properties.Resources.refresh;
            btnRefreshDG.Location = new Point(683, 256);
            btnRefreshDG.Name = "btnRefreshDG";
            btnRefreshDG.Size = new Size(29, 29);
            btnRefreshDG.TabIndex = 124;
            btnRefreshDG.UseVisualStyleBackColor = true;
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Location = new Point(720, 255);
            cbxFiltro.Margin = new Padding(3, 3, 6, 3);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.RightToLeft = RightToLeft.Yes;
            cbxFiltro.Size = new Size(138, 28);
            cbxFiltro.Sorted = true;
            cbxFiltro.TabIndex = 123;
            cbxFiltro.Text = "Filtro";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 725);
            Controls.Add(btnRefreshDG);
            Controls.Add(cbxFiltro);
            Controls.Add(topBarMenu);
            Controls.Add(btnVisualizarRegistro);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(groupBox1);
            Controls.Add(lblTituloRegistroPanel);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscarUsuario);
            Name = "Factura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            topBarMenu.ResumeLayout(false);
            topBarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEliminarUsuario;
        private GroupBox groupBox1;
        private Button btnNext;
        private Button btnAtras;
        private DataGridView dgvPedidos;
        private Label lblTituloRegistroPanel;
        private PictureBox pictureBox1;
        private TextBox txtBuscarUsuario;
        private Button btnVisualizarRegistro;
        private Panel topBarMenu;
        private Button btnFactura;
        private PictureBox pictureBox2;
        private Button btnPDVPanel;
        private Label lblTITULO;
        public Button btnRefreshDG;
        public ComboBox cbxFiltro;
    }
}