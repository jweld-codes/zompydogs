namespace zompyDogs
{
    partial class PanelEmpleado
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
            panel2 = new Panel();
            lblFechaActual = new Label();
            lblNombreUser = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dtgHistorialPedidos = new DataGridView();
            lblHistorial = new Label();
            topBarMenu = new Panel();
            pictureBox2 = new PictureBox();
            lblTITULO = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgHistorialPedidos).BeginInit();
            topBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblFechaActual);
            panel2.Controls.Add(lblNombreUser);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(39, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 208);
            panel2.TabIndex = 31;
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaActual.Location = new Point(186, 12);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(119, 20);
            lblFechaActual.TabIndex = 19;
            lblFechaActual.Text = "FECHA ACTUAL";
            // 
            // lblNombreUser
            // 
            lblNombreUser.AutoSize = true;
            lblNombreUser.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUser.Location = new Point(180, 74);
            lblNombreUser.Name = "lblNombreUser";
            lblNombreUser.Size = new Size(47, 46);
            lblNombreUser.TabIndex = 5;
            lblNombreUser.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 32);
            label1.Name = "label1";
            label1.Size = new Size(284, 38);
            label1.TabIndex = 4;
            label1.Text = "Bienvenido Empleado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.team;
            pictureBox1.Location = new Point(25, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // dtgHistorialPedidos
            // 
            dtgHistorialPedidos.AllowUserToAddRows = false;
            dtgHistorialPedidos.AllowUserToDeleteRows = false;
            dtgHistorialPedidos.BackgroundColor = Color.FromArgb(239, 239, 239);
            dtgHistorialPedidos.BorderStyle = BorderStyle.Fixed3D;
            dtgHistorialPedidos.ColumnHeadersHeight = 42;
            dtgHistorialPedidos.Location = new Point(36, 391);
            dtgHistorialPedidos.Name = "dtgHistorialPedidos";
            dtgHistorialPedidos.RowHeadersWidth = 51;
            dtgHistorialPedidos.Size = new Size(622, 224);
            dtgHistorialPedidos.TabIndex = 33;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorial.Location = new Point(39, 369);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(135, 20);
            lblHistorial.TabIndex = 34;
            lblHistorial.Text = "Pedidos Recientes";
            // 
            // topBarMenu
            // 
            topBarMenu.BackColor = Color.FromArgb(31, 19, 10);
            topBarMenu.Controls.Add(pictureBox2);
            topBarMenu.Controls.Add(lblTITULO);
            topBarMenu.Dock = DockStyle.Top;
            topBarMenu.Location = new Point(0, 0);
            topBarMenu.Name = "topBarMenu";
            topBarMenu.Size = new Size(901, 81);
            topBarMenu.TabIndex = 117;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.home__4_;
            pictureBox2.Location = new Point(36, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 97;
            pictureBox2.TabStop = false;
            // 
            // lblTITULO
            // 
            lblTITULO.AutoSize = true;
            lblTITULO.BackColor = Color.Transparent;
            lblTITULO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTITULO.ForeColor = Color.Transparent;
            lblTITULO.Location = new Point(108, 34);
            lblTITULO.Name = "lblTITULO";
            lblTITULO.Size = new Size(84, 31);
            lblTITULO.TabIndex = 3;
            lblTITULO.Text = "INICIO";
            lblTITULO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(901, 725);
            Controls.Add(topBarMenu);
            Controls.Add(panel2);
            Controls.Add(dtgHistorialPedidos);
            Controls.Add(lblHistorial);
            ForeColor = Color.Black;
            Name = "PanelEmpleado";
            Text = "PanelEmpleado";
            Load += PanelEmpleado_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgHistorialPedidos).EndInit();
            topBarMenu.ResumeLayout(false);
            topBarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label lblFechaActual;
        public Label lblNombreUser;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dtgHistorialPedidos;
        private Label lblHistorial;
        private Panel topBarMenu;
        private PictureBox pictureBox2;
        private Label lblTITULO;
    }
}