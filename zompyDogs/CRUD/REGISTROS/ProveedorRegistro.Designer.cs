﻿namespace zompyDogs.CRUD.AGREGAR
{
    partial class ProveedorRegistro
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
            btnGuardarUser = new Button();
            groupBox1 = new GroupBox();
            label10 = new Label();
            txtCodigoGenerado = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            cbxEsatdoCivil = new ComboBox();
            label9 = new Label();
            txtCedula = new TextBox();
            label7 = new Label();
            txtSegApellido = new TextBox();
            label5 = new Label();
            txtPrimApellido = new TextBox();
            label4 = new Label();
            txtSegNombre = new TextBox();
            label2 = new Label();
            txtPrimNombre = new TextBox();
            label3 = new Label();
            lblTituloRegistro = new Label();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardarUser
            // 
            btnGuardarUser.BackColor = Color.FromArgb(251, 147, 32);
            btnGuardarUser.ForeColor = SystemColors.ControlLightLight;
            btnGuardarUser.Location = new Point(52, 475);
            btnGuardarUser.Name = "btnGuardarUser";
            btnGuardarUser.Size = new Size(177, 64);
            btnGuardarUser.TabIndex = 104;
            btnGuardarUser.Text = "GUARDAR";
            btnGuardarUser.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtCodigoGenerado);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(cbxEsatdoCivil);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSegApellido);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrimApellido);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSegNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPrimNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(23, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 377);
            groupBox1.TabIndex = 103;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(222, 46);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 114;
            label10.Text = "Fecha de Registro";
            // 
            // txtCodigoGenerado
            // 
            txtCodigoGenerado.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoGenerado.Enabled = false;
            txtCodigoGenerado.Location = new Point(184, 0);
            txtCodigoGenerado.Name = "txtCodigoGenerado";
            txtCodigoGenerado.ReadOnly = true;
            txtCodigoGenerado.Size = new Size(239, 27);
            txtCodigoGenerado.TabIndex = 105;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(222, 69);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(180, 27);
            dtpFechaNacimiento.TabIndex = 113;
            // 
            // cbxEsatdoCivil
            // 
            cbxEsatdoCivil.FormattingEnabled = true;
            cbxEsatdoCivil.ItemHeight = 20;
            cbxEsatdoCivil.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbxEsatdoCivil.Location = new Point(19, 325);
            cbxEsatdoCivil.Name = "cbxEsatdoCivil";
            cbxEsatdoCivil.Size = new Size(180, 28);
            cbxEsatdoCivil.TabIndex = 112;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 300);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 111;
            label9.Text = "Estado";
            // 
            // txtCedula
            // 
            txtCedula.BorderStyle = BorderStyle.FixedSingle;
            txtCedula.Location = new Point(19, 69);
            txtCedula.Multiline = true;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(180, 37);
            txtCedula.TabIndex = 108;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 46);
            label7.Name = "label7";
            label7.Size = new Size(161, 20);
            label7.TabIndex = 107;
            label7.Text = "Nombre del Proveedor";
            // 
            // txtSegApellido
            // 
            txtSegApellido.BorderStyle = BorderStyle.FixedSingle;
            txtSegApellido.Location = new Point(222, 240);
            txtSegApellido.Multiline = true;
            txtSegApellido.Name = "txtSegApellido";
            txtSegApellido.Size = new Size(180, 37);
            txtSegApellido.TabIndex = 104;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 217);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 103;
            label5.Text = "Correo Electrónico";
            // 
            // txtPrimApellido
            // 
            txtPrimApellido.BorderStyle = BorderStyle.FixedSingle;
            txtPrimApellido.Location = new Point(19, 240);
            txtPrimApellido.Multiline = true;
            txtPrimApellido.Name = "txtPrimApellido";
            txtPrimApellido.Size = new Size(180, 37);
            txtPrimApellido.TabIndex = 102;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 217);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 101;
            label4.Text = "Teléfono";
            // 
            // txtSegNombre
            // 
            txtSegNombre.BorderStyle = BorderStyle.FixedSingle;
            txtSegNombre.Location = new Point(222, 157);
            txtSegNombre.Multiline = true;
            txtSegNombre.Name = "txtSegNombre";
            txtSegNombre.Size = new Size(180, 37);
            txtSegNombre.TabIndex = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 134);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 99;
            label2.Text = "Apellido del Contacto";
            // 
            // txtPrimNombre
            // 
            txtPrimNombre.BorderStyle = BorderStyle.FixedSingle;
            txtPrimNombre.Location = new Point(19, 157);
            txtPrimNombre.Multiline = true;
            txtPrimNombre.Name = "txtPrimNombre";
            txtPrimNombre.Size = new Size(180, 37);
            txtPrimNombre.TabIndex = 98;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 134);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 97;
            label3.Text = "Nombre del Contacto";
            // 
            // lblTituloRegistro
            // 
            lblTituloRegistro.AutoSize = true;
            lblTituloRegistro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRegistro.Location = new Point(23, 24);
            lblTituloRegistro.Name = "lblTituloRegistro";
            lblTituloRegistro.Size = new Size(42, 41);
            lblTituloRegistro.TabIndex = 102;
            lblTituloRegistro.Text = "...";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 49, 54);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(249, 475);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(177, 64);
            btnCancelar.TabIndex = 106;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // ProveedorRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 561);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarUser);
            Controls.Add(groupBox1);
            Controls.Add(lblTituloRegistro);
            Name = "ProveedorRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProveedorRegistro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnGuardarUser;
        private GroupBox groupBox1;
        private Label label10;
        public DateTimePicker dtpFechaNacimiento;
        private ComboBox cbxEsatdoCivil;
        private Label label9;
        public TextBox txtCedula;
        private Label label7;
        public TextBox txtSegApellido;
        private Label label5;
        public TextBox txtPrimApellido;
        private Label label4;
        public TextBox txtSegNombre;
        private Label label2;
        public TextBox txtPrimNombre;
        private Label label3;
        public Label lblTituloRegistro;
        private TextBox txtCodigoGenerado;
        public Button btnCancelar;
    }
}