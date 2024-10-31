namespace zompyDogs
{
    partial class LibretaMenu
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
            btnAdminPanel = new Button();
            pictureBox2 = new PictureBox();
            btnUsuarioPanel = new Button();
            lblTITULO = new Label();
            lblBreadCrumbUser = new Label();
            label1 = new Label();
            panel1 = new Panel();
            flpLibreta = new FlowLayoutPanel();
            categoryPanel = new Panel();
            label2 = new Label();
            btnCategory = new Button();
            topBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            categoryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topBarMenu
            // 
            topBarMenu.BackColor = Color.FromArgb(31, 19, 10);
            topBarMenu.Controls.Add(btnAdminPanel);
            topBarMenu.Controls.Add(pictureBox2);
            topBarMenu.Controls.Add(btnUsuarioPanel);
            topBarMenu.Controls.Add(lblTITULO);
            topBarMenu.Dock = DockStyle.Top;
            topBarMenu.Location = new Point(0, 0);
            topBarMenu.Name = "topBarMenu";
            topBarMenu.Size = new Size(901, 81);
            topBarMenu.TabIndex = 126;
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.BackColor = Color.White;
            btnAdminPanel.FlatAppearance.BorderSize = 0;
            btnAdminPanel.FlatStyle = FlatStyle.Flat;
            btnAdminPanel.ForeColor = SystemColors.ActiveCaptionText;
            btnAdminPanel.Location = new Point(706, 45);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(152, 36);
            btnAdminPanel.TabIndex = 99;
            btnAdminPanel.Text = "Libreta";
            btnAdminPanel.UseVisualStyleBackColor = false;
            btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dinner;
            pictureBox2.Location = new Point(36, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 97;
            pictureBox2.TabStop = false;
            // 
            // btnUsuarioPanel
            // 
            btnUsuarioPanel.BackColor = Color.Transparent;
            btnUsuarioPanel.FlatAppearance.BorderSize = 0;
            btnUsuarioPanel.FlatStyle = FlatStyle.Flat;
            btnUsuarioPanel.ForeColor = SystemColors.Control;
            btnUsuarioPanel.Location = new Point(547, 45);
            btnUsuarioPanel.Name = "btnUsuarioPanel";
            btnUsuarioPanel.Size = new Size(152, 36);
            btnUsuarioPanel.TabIndex = 98;
            btnUsuarioPanel.Text = "Menú";
            btnUsuarioPanel.UseVisualStyleBackColor = false;
            btnUsuarioPanel.Click += btnUsuarioPanel_Click;
            // 
            // lblTITULO
            // 
            lblTITULO.AutoSize = true;
            lblTITULO.BackColor = Color.Transparent;
            lblTITULO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTITULO.ForeColor = Color.Transparent;
            lblTITULO.Location = new Point(109, 34);
            lblTITULO.Name = "lblTITULO";
            lblTITULO.Size = new Size(83, 31);
            lblTITULO.TabIndex = 3;
            lblTITULO.Text = "MENÚ";
            lblTITULO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBreadCrumbUser
            // 
            lblBreadCrumbUser.AutoSize = true;
            lblBreadCrumbUser.BackColor = Color.Transparent;
            lblBreadCrumbUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreadCrumbUser.ForeColor = Color.LimeGreen;
            lblBreadCrumbUser.Location = new Point(70, 3);
            lblBreadCrumbUser.Name = "lblBreadCrumbUser";
            lblBreadCrumbUser.Size = new Size(69, 20);
            lblBreadCrumbUser.TabIndex = 124;
            lblBreadCrumbUser.Text = "LIBRETA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 3);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 123;
            label1.Text = "MENÚ /";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblBreadCrumbUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 55);
            panel1.TabIndex = 127;
            // 
            // flpLibreta
            // 
            flpLibreta.AutoScroll = true;
            flpLibreta.Dock = DockStyle.Right;
            flpLibreta.Location = new Point(163, 136);
            flpLibreta.Name = "flpLibreta";
            flpLibreta.Size = new Size(738, 589);
            flpLibreta.TabIndex = 128;
            // 
            // categoryPanel
            // 
            categoryPanel.BorderStyle = BorderStyle.FixedSingle;
            categoryPanel.Controls.Add(label2);
            categoryPanel.Controls.Add(btnCategory);
            categoryPanel.Dock = DockStyle.Left;
            categoryPanel.Location = new Point(0, 136);
            categoryPanel.Name = "categoryPanel";
            categoryPanel.Size = new Size(157, 589);
            categoryPanel.TabIndex = 129;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 25);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 0;
            label2.Text = "CATEGORIAS";
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.Green;
            btnCategory.ForeColor = SystemColors.Control;
            btnCategory.Location = new Point(6, 64);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(141, 72);
            btnCategory.TabIndex = 0;
            btnCategory.UseVisualStyleBackColor = false;
            // 
            // LibretaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(901, 725);
            Controls.Add(categoryPanel);
            Controls.Add(flpLibreta);
            Controls.Add(panel1);
            Controls.Add(topBarMenu);
            Name = "LibretaMenu";
            Text = "LibretaMenu";
            topBarMenu.ResumeLayout(false);
            topBarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            categoryPanel.ResumeLayout(false);
            categoryPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel topBarMenu;
        private Button btnAdminPanel;
        private PictureBox pictureBox2;
        public Button btnUsuarioPanel;
        private Label lblTITULO;
        private Panel panel1;
        private Label lblBreadCrumbUser;
        private Label label1;
        private FlowLayoutPanel flpLibreta;
        private Panel categoryPanel;
        private Label label2;
        private Button btnCategory;
    }
}