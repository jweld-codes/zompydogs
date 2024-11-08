namespace zompyDogs
{
    partial class PanelAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdmin));
            label4 = new Label();
            panel2 = new Panel();
            lblNombreUsuario_Panel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblHistorial = new Label();
            dgvPedidosPanel = new DataGridView();
            topBarMenu = new Panel();
            lblTITULO = new Label();
            dgvPeticionesPendientes = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosPanel).BeginInit();
            topBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeticionesPendientes).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(388, 244);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 26;
            label4.Text = "Peticiones Pendientes";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblNombreUsuario_Panel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(6, 64);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 148);
            panel2.TabIndex = 20;
            // 
            // lblNombreUsuario_Panel
            // 
            lblNombreUsuario_Panel.AutoSize = true;
            lblNombreUsuario_Panel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUsuario_Panel.Location = new Point(155, 59);
            lblNombreUsuario_Panel.Name = "lblNombreUsuario_Panel";
            lblNombreUsuario_Panel.Size = new Size(38, 37);
            lblNombreUsuario_Panel.TabIndex = 5;
            lblNombreUsuario_Panel.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 23);
            label1.Name = "label1";
            label1.Size = new Size(264, 30);
            label1.TabIndex = 4;
            label1.Text = "Bienvenido Administrador";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 23);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorial.Location = new Point(12, 244);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(108, 15);
            lblHistorial.TabIndex = 19;
            lblHistorial.Text = "Pedidos Recientes";
            // 
            // dgvPedidosPanel
            // 
            dgvPedidosPanel.AllowUserToAddRows = false;
            dgvPedidosPanel.AllowUserToDeleteRows = false;
            dgvPedidosPanel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidosPanel.BackgroundColor = Color.FromArgb(239, 239, 239);
            dgvPedidosPanel.BorderStyle = BorderStyle.Fixed3D;
            dgvPedidosPanel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPedidosPanel.ColumnHeadersHeight = 42;
            dgvPedidosPanel.Location = new Point(12, 261);
            dgvPedidosPanel.Margin = new Padding(3, 2, 3, 2);
            dgvPedidosPanel.Name = "dgvPedidosPanel";
            dgvPedidosPanel.RowHeadersWidth = 51;
            dgvPedidosPanel.Size = new Size(345, 138);
            dgvPedidosPanel.TabIndex = 18;
            // 
            // topBarMenu
            // 
            topBarMenu.BackColor = Color.FromArgb(31, 19, 10);
            topBarMenu.Controls.Add(lblTITULO);
            topBarMenu.Dock = DockStyle.Top;
            topBarMenu.Location = new Point(0, 0);
            topBarMenu.Margin = new Padding(3, 2, 3, 2);
            topBarMenu.Name = "topBarMenu";
            topBarMenu.Size = new Size(788, 61);
            topBarMenu.TabIndex = 98;
            // 
            // lblTITULO
            // 
            lblTITULO.AutoSize = true;
            lblTITULO.BackColor = Color.Transparent;
            lblTITULO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTITULO.ForeColor = Color.Transparent;
            lblTITULO.Location = new Point(354, 22);
            lblTITULO.Name = "lblTITULO";
            lblTITULO.Size = new Size(138, 25);
            lblTITULO.TabIndex = 3;
            lblTITULO.Text = "ZOMPY DOGS";
            lblTITULO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPeticionesPendientes
            // 
            dgvPeticionesPendientes.AllowUserToAddRows = false;
            dgvPeticionesPendientes.AllowUserToDeleteRows = false;
            dgvPeticionesPendientes.BackgroundColor = Color.FromArgb(239, 239, 239);
            dgvPeticionesPendientes.BorderStyle = BorderStyle.Fixed3D;
            dgvPeticionesPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeticionesPendientes.Location = new Point(388, 261);
            dgvPeticionesPendientes.Margin = new Padding(3, 2, 3, 2);
            dgvPeticionesPendientes.Name = "dgvPeticionesPendientes";
            dgvPeticionesPendientes.ReadOnly = true;
            dgvPeticionesPendientes.RowHeadersWidth = 51;
            dgvPeticionesPendientes.ScrollBars = ScrollBars.Vertical;
            dgvPeticionesPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeticionesPendientes.Size = new Size(386, 138);
            dgvPeticionesPendientes.TabIndex = 99;
            // 
            // PanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(788, 590);
            Controls.Add(dgvPeticionesPendientes);
            Controls.Add(topBarMenu);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(lblHistorial);
            Controls.Add(dgvPedidosPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PanelAdmin";
            Text = "PanelAdmin";
            Load += PanelAdmin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosPanel).EndInit();
            topBarMenu.ResumeLayout(false);
            topBarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeticionesPendientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Panel panel2;
        public Label lblNombreUsuario_Panel;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblHistorial;
        private DataGridView dgvPedidosPanel;
        private Panel topBarMenu;
        private Label lblTITULO;
        private DataGridView dgvPeticionesPendientes;
    }
}