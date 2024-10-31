﻿namespace zompyDogs.CRUD.REGISTROS
{
    partial class PeticionesRegisro
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
            btnCancelar = new Button();
            btnGuardarUser = new Button();
            groupBox1 = new GroupBox();
            txtUsuarioName = new TextBox();
            cbxPeticion = new ComboBox();
            label10 = new Label();
            txtCodigoGenerado = new TextBox();
            dtpFechaEnviada = new DateTimePicker();
            cbxEstadoCuenta = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblTituloRegistro = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 49, 54);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(228, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(177, 64);
            btnCancelar.TabIndex = 110;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarUser
            // 
            btnGuardarUser.BackColor = Color.FromArgb(251, 147, 32);
            btnGuardarUser.ForeColor = SystemColors.ControlLightLight;
            btnGuardarUser.Location = new Point(31, 405);
            btnGuardarUser.Name = "btnGuardarUser";
            btnGuardarUser.Size = new Size(177, 64);
            btnGuardarUser.TabIndex = 109;
            btnGuardarUser.Text = "GUARDAR";
            btnGuardarUser.UseVisualStyleBackColor = false;
            btnGuardarUser.Click += btnGuardarUser_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsuarioName);
            groupBox1.Controls.Add(cbxPeticion);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtCodigoGenerado);
            groupBox1.Controls.Add(dtpFechaEnviada);
            groupBox1.Controls.Add(cbxEstadoCuenta);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 313);
            groupBox1.TabIndex = 108;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // txtUsuarioName
            // 
            txtUsuarioName.Location = new Point(19, 259);
            txtUsuarioName.Name = "txtUsuarioName";
            txtUsuarioName.Size = new Size(180, 27);
            txtUsuarioName.TabIndex = 116;
            // 
            // cbxPeticion
            // 
            cbxPeticion.FormattingEnabled = true;
            cbxPeticion.ItemHeight = 20;
            cbxPeticion.Items.AddRange(new object[] { "Actualizar", "Eliminar", "Recuperación de Cuenta" });
            cbxPeticion.Location = new Point(19, 69);
            cbxPeticion.Name = "cbxPeticion";
            cbxPeticion.Size = new Size(180, 28);
            cbxPeticion.TabIndex = 115;
            cbxPeticion.Text = "ACTUALIZAR";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(222, 46);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 114;
            label10.Text = "Fecha de Peticion";
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
            // dtpFechaEnviada
            // 
            dtpFechaEnviada.Enabled = false;
            dtpFechaEnviada.Format = DateTimePickerFormat.Short;
            dtpFechaEnviada.Location = new Point(222, 69);
            dtpFechaEnviada.Name = "dtpFechaEnviada";
            dtpFechaEnviada.Size = new Size(180, 27);
            dtpFechaEnviada.TabIndex = 113;
            // 
            // cbxEstadoCuenta
            // 
            cbxEstadoCuenta.Enabled = false;
            cbxEstadoCuenta.FormattingEnabled = true;
            cbxEstadoCuenta.ItemHeight = 20;
            cbxEstadoCuenta.Items.AddRange(new object[] { "Activo", "Inactivo", "Completado", "Pendiente" });
            cbxEstadoCuenta.Location = new Point(222, 259);
            cbxEstadoCuenta.Name = "cbxEstadoCuenta";
            cbxEstadoCuenta.Size = new Size(180, 28);
            cbxEstadoCuenta.TabIndex = 112;
            cbxEstadoCuenta.Text = "ACTIVO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(222, 234);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 111;
            label9.Text = "Estado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 46);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 107;
            label7.Text = "Petición";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(19, 128);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(383, 86);
            txtDescripcion.TabIndex = 102;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 105);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 101;
            label4.Text = "Descripción de Petición";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 234);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 97;
            label3.Text = "Nombre del Usuario";
            // 
            // lblTituloRegistro
            // 
            lblTituloRegistro.AutoSize = true;
            lblTituloRegistro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRegistro.Location = new Point(12, 33);
            lblTituloRegistro.Name = "lblTituloRegistro";
            lblTituloRegistro.Size = new Size(42, 41);
            lblTituloRegistro.TabIndex = 107;
            lblTituloRegistro.Text = "...";
            // 
            // PeticionesRegisro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 490);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarUser);
            Controls.Add(groupBox1);
            Controls.Add(lblTituloRegistro);
            Name = "PeticionesRegisro";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnCancelar;
        public Button btnGuardarUser;
        private GroupBox groupBox1;
        private Label label10;
        public TextBox txtCodigoGenerado;
        public DateTimePicker dtpFechaEnviada;
        public ComboBox cbxEstadoCuenta;
        private Label label9;
        private Label label7;
        public TextBox txtDescripcion;
        private Label label4;
        public Label label3;
        public Label lblTituloRegistro;
        public ComboBox cbxPeticion;
        public TextBox txtUsuarioName;
    }
}