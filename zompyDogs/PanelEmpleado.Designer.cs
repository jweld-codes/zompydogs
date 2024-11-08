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
            topBarMenu = new Panel();
            pictureBox2 = new PictureBox();
            lblTITULO = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel2.Location = new Point(32, 67);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 156);
            panel2.TabIndex = 31;
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaActual.Location = new Point(163, 9);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(91, 15);
            lblFechaActual.TabIndex = 19;
            lblFechaActual.Text = "FECHA ACTUAL";
            // 
            // lblNombreUser
            // 
            lblNombreUser.AutoSize = true;
            lblNombreUser.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUser.Location = new Point(158, 56);
            lblNombreUser.Name = "lblNombreUser";
            lblNombreUser.Size = new Size(38, 37);
            lblNombreUser.TabIndex = 5;
            lblNombreUser.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 24);
            label1.Name = "label1";
            label1.Size = new Size(224, 30);
            label1.TabIndex = 4;
            label1.Text = "Bienvenido Empleado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.team;
            pictureBox1.Location = new Point(22, 33);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // topBarMenu
            // 
            topBarMenu.BackColor = Color.FromArgb(31, 19, 10);
            topBarMenu.Controls.Add(pictureBox2);
            topBarMenu.Controls.Add(lblTITULO);
            topBarMenu.Dock = DockStyle.Top;
            topBarMenu.Location = new Point(0, 0);
            topBarMenu.Margin = new Padding(3, 2, 3, 2);
            topBarMenu.Name = "topBarMenu";
            topBarMenu.Size = new Size(788, 61);
            topBarMenu.TabIndex = 117;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.home__4_;
            pictureBox2.Location = new Point(32, 22);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 30);
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
            lblTITULO.Location = new Point(94, 26);
            lblTITULO.Name = "lblTITULO";
            lblTITULO.Size = new Size(71, 25);
            lblTITULO.TabIndex = 3;
            lblTITULO.Text = "INICIO";
            lblTITULO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(788, 544);
            Controls.Add(topBarMenu);
            Controls.Add(panel2);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PanelEmpleado";
            Text = "PanelEmpleado";
            Load += PanelEmpleado_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            topBarMenu.ResumeLayout(false);
            topBarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblFechaActual;
        public Label lblNombreUser;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel topBarMenu;
        private PictureBox pictureBox2;
        private Label lblTITULO;
    }
}