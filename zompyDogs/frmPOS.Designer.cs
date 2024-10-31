namespace zompyDogs
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            topBarMenu = new Panel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            btnUsuarioPanel = new Button();
            lblTITULO = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label15 = new Label();
            btnEliminarOrden = new Button();
            textBox5 = new TextBox();
            button1 = new Button();
            textBox6 = new TextBox();
            btnQtuMore = new Button();
            btnQtyLess = new Button();
            dgvPedido = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            btnConfirmarPedido = new Button();
            categoryPanel = new Panel();
            label1 = new Label();
            btnCategory = new Button();
            panel3 = new Panel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            panelContenedrPOS = new Panel();
            flpPOSPanel = new FlowLayoutPanel();
            panel4 = new Panel();
            panel2 = new Panel();
            lblNombrePlatillo = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            textBox1 = new TextBox();
            btnNext = new Button();
            btnAgregarPlatillo = new Button();
            btnAtras = new Button();
            lblPrecioPlatilo = new Label();
            label2 = new Label();
            topBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            categoryPanel.SuspendLayout();
            panel3.SuspendLayout();
            panelContenedrPOS.SuspendLayout();
            flpPOSPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // topBarMenu
            // 
            topBarMenu.BackColor = Color.FromArgb(31, 19, 10);
            topBarMenu.Controls.Add(button2);
            topBarMenu.Controls.Add(pictureBox2);
            topBarMenu.Controls.Add(btnUsuarioPanel);
            topBarMenu.Controls.Add(lblTITULO);
            topBarMenu.Dock = DockStyle.Top;
            topBarMenu.Location = new Point(0, 0);
            topBarMenu.Name = "topBarMenu";
            topBarMenu.Size = new Size(901, 81);
            topBarMenu.TabIndex = 106;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(716, 45);
            button2.Name = "button2";
            button2.Size = new Size(152, 36);
            button2.TabIndex = 99;
            button2.Text = "FACTURAS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            btnUsuarioPanel.Location = new Point(558, 45);
            btnUsuarioPanel.Name = "btnUsuarioPanel";
            btnUsuarioPanel.Size = new Size(152, 36);
            btnUsuarioPanel.TabIndex = 98;
            btnUsuarioPanel.Text = "PUNTO DE VENTA";
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
            lblTITULO.Size = new Size(205, 31);
            lblTITULO.TabIndex = 3;
            lblTITULO.Text = "PUNTO DE VENTA";
            lblTITULO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(dgvPedido);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(579, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 644);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(btnEliminarOrden);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(btnQtuMore);
            groupBox1.Controls.Add(btnQtyLess);
            groupBox1.Location = new Point(5, 376);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 150);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Orden";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 30);
            label15.Name = "label15";
            label15.Size = new Size(55, 20);
            label15.TabIndex = 1;
            label15.Text = "Platillo";
            // 
            // btnEliminarOrden
            // 
            btnEliminarOrden.FlatAppearance.BorderSize = 0;
            btnEliminarOrden.Image = Properties.Resources.delete2;
            btnEliminarOrden.Location = new Point(16, 51);
            btnEliminarOrden.Name = "btnEliminarOrden";
            btnEliminarOrden.Size = new Size(26, 29);
            btnEliminarOrden.TabIndex = 6;
            btnEliminarOrden.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(48, 53);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(136, 27);
            textBox5.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(185, 97);
            button1.Name = "button1";
            button1.Size = new Size(116, 47);
            button1.TabIndex = 5;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(222, 53);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(48, 27);
            textBox6.TabIndex = 3;
            // 
            // btnQtuMore
            // 
            btnQtuMore.FlatAppearance.BorderSize = 0;
            btnQtuMore.Image = Properties.Resources.plus__1_;
            btnQtuMore.Location = new Point(190, 51);
            btnQtuMore.Name = "btnQtuMore";
            btnQtuMore.Size = new Size(26, 29);
            btnQtuMore.TabIndex = 5;
            btnQtuMore.UseVisualStyleBackColor = true;
            // 
            // btnQtyLess
            // 
            btnQtyLess.FlatAppearance.BorderSize = 0;
            btnQtyLess.Image = Properties.Resources.negative;
            btnQtyLess.Location = new Point(275, 51);
            btnQtyLess.Name = "btnQtyLess";
            btnQtyLess.Size = new Size(26, 29);
            btnQtyLess.TabIndex = 4;
            btnQtyLess.UseVisualStyleBackColor = true;
            // 
            // dgvPedido
            // 
            dgvPedido.AllowUserToAddRows = false;
            dgvPedido.AllowUserToOrderColumns = true;
            dgvPedido.AllowUserToResizeColumns = false;
            dgvPedido.AllowUserToResizeRows = false;
            dgvPedido.BackgroundColor = SystemColors.Control;
            dgvPedido.BorderStyle = BorderStyle.None;
            dgvPedido.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvPedido.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidad, colTotal });
            dgvPedido.GridColor = SystemColors.ScrollBar;
            dgvPedido.Location = new Point(5, 5);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersVisible = false;
            dgvPedido.RowHeadersWidth = 51;
            dgvPedido.Size = new Size(304, 337);
            dgvPedido.TabIndex = 0;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.Width = 125;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.Width = 125;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.Width = 125;
            // 
            // btnConfirmarPedido
            // 
            btnConfirmarPedido.BackColor = SystemColors.Highlight;
            btnConfirmarPedido.ForeColor = SystemColors.Control;
            btnConfirmarPedido.Location = new Point(237, 8);
            btnConfirmarPedido.Name = "btnConfirmarPedido";
            btnConfirmarPedido.Size = new Size(179, 47);
            btnConfirmarPedido.TabIndex = 1;
            btnConfirmarPedido.Text = "CONFIRMAR PEDIDO";
            btnConfirmarPedido.UseVisualStyleBackColor = false;
            // 
            // categoryPanel
            // 
            categoryPanel.BorderStyle = BorderStyle.FixedSingle;
            categoryPanel.Controls.Add(label1);
            categoryPanel.Controls.Add(btnCategory);
            categoryPanel.Dock = DockStyle.Left;
            categoryPanel.Location = new Point(0, 0);
            categoryPanel.Name = "categoryPanel";
            categoryPanel.Size = new Size(153, 644);
            categoryPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 25);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 0;
            label1.Text = "CATEGORIAS";
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
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(btnConfirmarPedido);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(153, 581);
            panel3.Name = "panel3";
            panel3.Size = new Size(426, 63);
            panel3.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(112, 17);
            label14.Name = "label14";
            label14.Size = new Size(57, 25);
            label14.TabIndex = 4;
            label14.Text = "00.00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(91, 17);
            label13.Name = "label13";
            label13.Size = new Size(26, 25);
            label13.TabIndex = 3;
            label13.Text = "L.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 21);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 2;
            label12.Text = "TOTAL:";
            // 
            // panelContenedrPOS
            // 
            panelContenedrPOS.Controls.Add(flpPOSPanel);
            panelContenedrPOS.Controls.Add(panel3);
            panelContenedrPOS.Controls.Add(panel1);
            panelContenedrPOS.Controls.Add(categoryPanel);
            panelContenedrPOS.Dock = DockStyle.Right;
            panelContenedrPOS.Location = new Point(0, 81);
            panelContenedrPOS.Name = "panelContenedrPOS";
            panelContenedrPOS.Size = new Size(901, 644);
            panelContenedrPOS.TabIndex = 109;
            // 
            // flpPOSPanel
            // 
            flpPOSPanel.Controls.Add(panel4);
            flpPOSPanel.Dock = DockStyle.Left;
            flpPOSPanel.Location = new Point(153, 0);
            flpPOSPanel.Name = "flpPOSPanel";
            flpPOSPanel.Size = new Size(426, 581);
            flpPOSPanel.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 343);
            panel4.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblNombrePlatillo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 51);
            panel2.TabIndex = 5;
            // 
            // lblNombrePlatillo
            // 
            lblNombrePlatillo.AutoSize = true;
            lblNombrePlatillo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombrePlatillo.Location = new Point(3, 14);
            lblNombrePlatillo.Name = "lblNombrePlatillo";
            lblNombrePlatillo.Size = new Size(176, 25);
            lblNombrePlatillo.TabIndex = 2;
            lblNombrePlatillo.Text = "Nombre del Platillo";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(20, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 154);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(btnNext);
            panel5.Controls.Add(btnAgregarPlatillo);
            panel5.Controls.Add(btnAtras);
            panel5.Controls.Add(lblPrecioPlatilo);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 216);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 127);
            panel5.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(48, 27);
            textBox1.TabIndex = 5;
            // 
            // btnNext
            // 
            btnNext.Image = Properties.Resources.arrow;
            btnNext.Location = new Point(122, 33);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 29);
            btnNext.TabIndex = 73;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPlatillo
            // 
            btnAgregarPlatillo.BackColor = Color.ForestGreen;
            btnAgregarPlatillo.ForeColor = SystemColors.Control;
            btnAgregarPlatillo.Location = new Point(14, 68);
            btnAgregarPlatillo.Name = "btnAgregarPlatillo";
            btnAgregarPlatillo.Size = new Size(176, 42);
            btnAgregarPlatillo.TabIndex = 4;
            btnAgregarPlatillo.Text = "Agregar";
            btnAgregarPlatillo.UseVisualStyleBackColor = false;
            // 
            // btnAtras
            // 
            btnAtras.Image = Properties.Resources.left_arrow;
            btnAtras.Location = new Point(41, 35);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(36, 29);
            btnAtras.TabIndex = 72;
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // lblPrecioPlatilo
            // 
            lblPrecioPlatilo.AutoSize = true;
            lblPrecioPlatilo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioPlatilo.Location = new Point(41, 5);
            lblPrecioPlatilo.Name = "lblPrecioPlatilo";
            lblPrecioPlatilo.Size = new Size(55, 23);
            lblPrecioPlatilo.TabIndex = 3;
            lblPrecioPlatilo.Text = "00.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 5);
            label2.Name = "label2";
            label2.Size = new Size(24, 23);
            label2.TabIndex = 2;
            label2.Text = "L.";
            // 
            // frmPOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(901, 725);
            Controls.Add(panelContenedrPOS);
            Controls.Add(topBarMenu);
            Name = "frmPOS";
            Text = "Facturacion";
            topBarMenu.ResumeLayout(false);
            topBarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            categoryPanel.ResumeLayout(false);
            categoryPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelContenedrPOS.ResumeLayout(false);
            flpPOSPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel topBarMenu;
        private PictureBox pictureBox2;
        public Button btnUsuarioPanel;
        private Label lblTITULO;
        private Panel panel1;
        private Button btnConfirmarPedido;
        private DataGridView dgvPedido;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colTotal;
        private Panel categoryPanel;
        private Label label1;
        private Button btnCategory;
        private Panel panel3;
        private Panel panelContenedrPOS;
        private FlowLayoutPanel flpPOSPanel;
        private Panel panel4;
        private Panel panel5;
        private Button btnAgregarPlatillo;
        private Label lblPrecioPlatilo;
        private Label label2;
        private Label lblNombrePlatillo;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private Button btnNext;
        private Button btnAtras;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button button1;
        private Button btnQtuMore;
        private Button btnQtyLess;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label15;
        private Button btnEliminarOrden;
        private GroupBox groupBox1;
        private Panel panel2;
        public Button button2;
    }
}