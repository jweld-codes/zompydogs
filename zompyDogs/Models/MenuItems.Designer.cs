namespace zompyDogs.Models
{
    partial class MenuItems
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblNombrePlatillo = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            lblPrecioPlatilo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(84, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 154);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPrecioPlatilo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 127);
            panel1.TabIndex = 1;
            // 
            // lblNombrePlatillo
            // 
            lblNombrePlatillo.AutoSize = true;
            lblNombrePlatillo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombrePlatillo.Location = new Point(20, 11);
            lblNombrePlatillo.Name = "lblNombrePlatillo";
            lblNombrePlatillo.Size = new Size(176, 25);
            lblNombrePlatillo.TabIndex = 0;
            lblNombrePlatillo.Text = "Nombre del Platillo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 68);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 5);
            label1.Name = "label1";
            label1.Size = new Size(24, 23);
            label1.TabIndex = 2;
            label1.Text = "L.";
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
            // MenuItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lblNombrePlatillo);
            Controls.Add(pictureBox1);
            Name = "MenuItems";
            Size = new Size(338, 340);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBox1;
        private Label lblNombrePlatillo;
        private Label lblPrecioPlatilo;
        private Label label1;
    }
}
