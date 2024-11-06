namespace zompyDogs.CRUD.REGISTROS
{
    partial class PuestosRegistro
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            txtCodigoGenerado = new TextBox();
            txtDiasLaborales = new TextBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtNombrePuesto = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            chbxDomingo = new CheckBox();
            chbxSabado = new CheckBox();
            chbxViernes = new CheckBox();
            chbxJueves = new CheckBox();
            chbxMiercoles = new CheckBox();
            chbxMartes = new CheckBox();
            chbxLunes = new CheckBox();
            cbHorasLaborales = new ComboBox();
            label14 = new Label();
            txtSalario = new TextBox();
            label13 = new Label();
            btnCancelar = new Button();
            btnGuardarUser = new Button();
            dgvPuestos = new DataGridView();
            button1 = new Button();
            label3 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCodigoGenerado);
            groupBox2.Controls.Add(txtDiasLaborales);
            groupBox2.Controls.Add(txtDescripcion);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNombrePuesto);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(cbHorasLaborales);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtSalario);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 338);
            groupBox2.TabIndex = 101;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de Puesto";
            // 
            // txtCodigoGenerado
            // 
            txtCodigoGenerado.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoGenerado.Enabled = false;
            txtCodigoGenerado.Location = new Point(213, 0);
            txtCodigoGenerado.Name = "txtCodigoGenerado";
            txtCodigoGenerado.ReadOnly = true;
            txtCodigoGenerado.Size = new Size(229, 27);
            txtCodigoGenerado.TabIndex = 135;
            // 
            // txtDiasLaborales
            // 
            txtDiasLaborales.BorderStyle = BorderStyle.FixedSingle;
            txtDiasLaborales.Location = new Point(213, 292);
            txtDiasLaborales.Multiline = true;
            txtDiasLaborales.Name = "txtDiasLaborales";
            txtDiasLaborales.Size = new Size(229, 30);
            txtDiasLaborales.TabIndex = 134;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(18, 138);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(180, 62);
            txtDescripcion.TabIndex = 132;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 115);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 133;
            label2.Text = "Descripción";
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePuesto.Location = new Point(18, 60);
            txtNombrePuesto.Multiline = true;
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(180, 37);
            txtNombrePuesto.TabIndex = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 131;
            label1.Text = "Nombre del Puesto";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chbxDomingo);
            groupBox3.Controls.Add(chbxSabado);
            groupBox3.Controls.Add(chbxViernes);
            groupBox3.Controls.Add(chbxJueves);
            groupBox3.Controls.Add(chbxMiercoles);
            groupBox3.Controls.Add(chbxMartes);
            groupBox3.Controls.Add(chbxLunes);
            groupBox3.Location = new Point(213, 125);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(229, 161);
            groupBox3.TabIndex = 123;
            groupBox3.TabStop = false;
            groupBox3.Text = "Horario";
            // 
            // chbxDomingo
            // 
            chbxDomingo.AutoSize = true;
            chbxDomingo.Location = new Point(126, 94);
            chbxDomingo.Name = "chbxDomingo";
            chbxDomingo.Size = new Size(94, 24);
            chbxDomingo.TabIndex = 6;
            chbxDomingo.Text = "Domingo";
            chbxDomingo.UseVisualStyleBackColor = true;
            // 
            // chbxSabado
            // 
            chbxSabado.AutoSize = true;
            chbxSabado.Location = new Point(126, 66);
            chbxSabado.Name = "chbxSabado";
            chbxSabado.Size = new Size(82, 24);
            chbxSabado.TabIndex = 5;
            chbxSabado.Text = "Sábado";
            chbxSabado.UseVisualStyleBackColor = true;
            // 
            // chbxViernes
            // 
            chbxViernes.AutoSize = true;
            chbxViernes.Location = new Point(126, 36);
            chbxViernes.Name = "chbxViernes";
            chbxViernes.Size = new Size(79, 24);
            chbxViernes.TabIndex = 4;
            chbxViernes.Text = "Viernes";
            chbxViernes.UseVisualStyleBackColor = true;
            // 
            // chbxJueves
            // 
            chbxJueves.AutoSize = true;
            chbxJueves.Location = new Point(16, 124);
            chbxJueves.Name = "chbxJueves";
            chbxJueves.Size = new Size(73, 24);
            chbxJueves.TabIndex = 3;
            chbxJueves.Text = "Jueves";
            chbxJueves.UseVisualStyleBackColor = true;
            // 
            // chbxMiercoles
            // 
            chbxMiercoles.AutoSize = true;
            chbxMiercoles.Location = new Point(16, 96);
            chbxMiercoles.Name = "chbxMiercoles";
            chbxMiercoles.Size = new Size(95, 24);
            chbxMiercoles.TabIndex = 2;
            chbxMiercoles.Text = "Miércoles";
            chbxMiercoles.UseVisualStyleBackColor = true;
            // 
            // chbxMartes
            // 
            chbxMartes.AutoSize = true;
            chbxMartes.Location = new Point(16, 66);
            chbxMartes.Name = "chbxMartes";
            chbxMartes.Size = new Size(76, 24);
            chbxMartes.TabIndex = 1;
            chbxMartes.Text = "Martes";
            chbxMartes.UseVisualStyleBackColor = true;
            // 
            // chbxLunes
            // 
            chbxLunes.AutoSize = true;
            chbxLunes.Location = new Point(16, 36);
            chbxLunes.Name = "chbxLunes";
            chbxLunes.Size = new Size(68, 24);
            chbxLunes.TabIndex = 0;
            chbxLunes.Text = "Lunes";
            chbxLunes.UseVisualStyleBackColor = true;
            // 
            // cbHorasLaborales
            // 
            cbHorasLaborales.FormattingEnabled = true;
            cbHorasLaborales.ItemHeight = 20;
            cbHorasLaborales.Items.AddRange(new object[] { "7:00 AM - 5:00 PM", "5:00 PM - 11:00 PM", "8:00 AM - 3:00 PM", "6:00 AM - 12:00 PM" });
            cbHorasLaborales.Location = new Point(15, 240);
            cbHorasLaborales.Name = "cbHorasLaborales";
            cbHorasLaborales.Size = new Size(180, 28);
            cbHorasLaborales.TabIndex = 122;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 215);
            label14.Name = "label14";
            label14.Size = new Size(48, 20);
            label14.TabIndex = 121;
            label14.Text = "Horas";
            // 
            // txtSalario
            // 
            txtSalario.BorderStyle = BorderStyle.FixedSingle;
            txtSalario.Location = new Point(216, 60);
            txtSalario.Multiline = true;
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(180, 37);
            txtSalario.TabIndex = 115;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(216, 37);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 120;
            label13.Text = "Salario";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 49, 54);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(631, 262);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 45);
            btnCancelar.TabIndex = 104;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarUser
            // 
            btnGuardarUser.BackColor = Color.FromArgb(251, 147, 32);
            btnGuardarUser.ForeColor = SystemColors.ControlLightLight;
            btnGuardarUser.Location = new Point(477, 262);
            btnGuardarUser.Name = "btnGuardarUser";
            btnGuardarUser.Size = new Size(148, 45);
            btnGuardarUser.TabIndex = 103;
            btnGuardarUser.Text = "CONFIRMAR";
            btnGuardarUser.UseVisualStyleBackColor = false;
            // 
            // dgvPuestos
            // 
            dgvPuestos.AllowUserToAddRows = false;
            dgvPuestos.AllowUserToDeleteRows = false;
            dgvPuestos.AllowUserToOrderColumns = true;
            dgvPuestos.AllowUserToResizeColumns = false;
            dgvPuestos.AllowUserToResizeRows = false;
            dgvPuestos.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Location = new Point(477, 72);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.ReadOnly = true;
            dgvPuestos.RowHeadersWidth = 51;
            dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuestos.Size = new Size(486, 177);
            dgvPuestos.TabIndex = 105;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 49, 54);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(797, 262);
            button1.Name = "button1";
            button1.Size = new Size(160, 45);
            button1.TabIndex = 106;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(477, 49);
            label3.Name = "label3";
            label3.Size = new Size(287, 20);
            label3.TabIndex = 134;
            label3.Text = "*Seleccione una fila para editar el puesto*";
            // 
            // PuestosRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(987, 364);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(dgvPuestos);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarUser);
            Controls.Add(groupBox2);
            Name = "PuestosRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        public TextBox txtDescripcion;
        private Label label2;
        public TextBox txtNombrePuesto;
        private Label label1;
        public GroupBox groupBox3;
        public CheckBox chbxDomingo;
        public CheckBox chbxSabado;
        public CheckBox chbxViernes;
        public CheckBox chbxJueves;
        public CheckBox chbxMiercoles;
        public CheckBox chbxMartes;
        public CheckBox chbxLunes;
        public ComboBox cbHorasLaborales;
        private Label label14;
        public TextBox txtSalario;
        private Label label13;
        public Button btnCancelar;
        public Button btnGuardarUser;
        private DataGridView dgvPuestos;
        public Button button1;
        private Label label3;
        public TextBox txtDiasLaborales;
        public TextBox txtCodigoGenerado;
    }
}