using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZompyDogsDAO;
using ZompyDogsLib.Controladores;
using static ZompyDogsDAO.UsuarioDAO;

namespace zompyDogs.CRUD.REGISTROS
{
    public partial class PuestosRegistro : Form
    {
        private string nuevoCodigoPuesto;
        private ControladorGeneradoresDeCodigo _controladorGeneradorCodigo;
        public PuestosRegistro()
        {
            InitializeComponent();

            CargarPuestos();
            _controladorGeneradorCodigo = new ControladorGeneradoresDeCodigo();
            GeneradordeCodigoPuestoFromForm();
            CargarRolesComboBox();

            //CheckBox Changed
            chbxLunes.CheckedChanged += (s, e) => ActualizarDiasLaborales();
            chbxMartes.CheckedChanged += (s, e) => ActualizarDiasLaborales();
            chbxMiercoles.CheckedChanged += (s, e) => ActualizarDiasLaborales();
            chbxJueves.CheckedChanged += (s, e) => ActualizarDiasLaborales();
            chbxViernes.CheckedChanged += (s, e) => ActualizarDiasLaborales();
            chbxSabado.CheckedChanged += (s, e) => ActualizarDiasLaborales();
            chbxDomingo.CheckedChanged += (s, e) => ActualizarDiasLaborales();
        }

        private void CargarPuestos()
        {
            DataTable puestos = UsuarioDAO.ObtenerDetalllesPuestos();
            dgvPuestos.DataSource = puestos;
        }


        private void GeneradordeCodigoPuestoFromForm()
        {
            nuevoCodigoPuesto = _controladorGeneradorCodigo.GeneradordeCodigoPuesto();
            txtCodigoGeneradoPuesto.Text = nuevoCodigoPuesto;
        }
        private void CargarRolesComboBox()
        {
            DataTable dtRoles = UsuarioDAO.ObtenerRolesParaComboBox();

            cbxRoles.DataSource = dtRoles;
            cbxRoles.DisplayMember = "Rol";
            cbxRoles.ValueMember = "Id_Rol";
        }
        private void ActualizarDiasLaborales()
        {
            List<string> diasSeleccionados = new List<string>();

            // Verifica cada CheckBox y agrega el día correspondiente si está seleccionado
            if (chbxLunes.Checked) diasSeleccionados.Add("Lunes");
            if (chbxMartes.Checked) diasSeleccionados.Add("Martes");
            if (chbxMiercoles.Checked) diasSeleccionados.Add("Miércoles");
            if (chbxJueves.Checked) diasSeleccionados.Add("Jueves");
            if (chbxViernes.Checked) diasSeleccionados.Add("Viernes");
            if (chbxSabado.Checked) diasSeleccionados.Add("Sábado");
            if (chbxDomingo.Checked) diasSeleccionados.Add("Domingo");

            // Une los días seleccionados en una cadena separada por comas
            txtDiasLaborales.Text = string.Join(",", diasSeleccionados);
        }
        private void btnGuardarPuesto_Click(object sender, EventArgs e)
        {


            PuestoREF nuevoPuesto = new PuestoREF
            {
                Puesto = txtNombrePuesto.Text,
                Descripcion = txtDescripcion.Text,
                Salario = Convert.ToInt32(txtSalario.Text),
                DiasLaborales = txtDiasLaborales.Text,
                CodigoPuesto = txtCodigoGeneradoPuesto.Text,
                CodigoRol = cbxRoles.SelectedValue != null && int.TryParse(cbxRoles.SelectedValue.ToString(), out int codigoRol)
                ? codigoRol
                : 1,
                Estado = cbxEstado.Text,

                HoralaboralInicio = new TimeSpan(tmBegin.Value.Hour, tmBegin.Value.Minute, 0),
                HoraLaboralTermina = new TimeSpan(tmEnd.Value.Hour, tmEnd.Value.Minute, 0)
            };
            try
            {
                if (string.IsNullOrWhiteSpace(nuevoPuesto.Puesto) ||
                    string.IsNullOrWhiteSpace(nuevoPuesto.Descripcion) ||
                    string.IsNullOrWhiteSpace(nuevoPuesto.DiasLaborales) ||
                    string.IsNullOrWhiteSpace(nuevoPuesto.CodigoPuesto) ||
                    string.IsNullOrWhiteSpace(nuevoPuesto.Estado))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.");
                    return;
                }
                // Guardar DetalleUsuario
                UsuarioDAO.GuardarPuesto(nuevoPuesto);


                MessageBox.Show("Puesto Registrado con Éxito.");
                CargarPuestos();
            }
            catch
            {
                MessageBox.Show("Error al registrar el Puesto.");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
