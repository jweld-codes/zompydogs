using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zompyDogs.CRUD.REGISTROS;
using ZompyDogsDAO;
using static ZompyDogsDAO.PeticionesValidaciones;

namespace zompyDogs
{
    public partial class PeticionesEmp : Form
    {
        public EmpleadoBienvenida EmpleadoFormPrincipal { get; set; }

        public BienvenidaAdmin FormPrincipal { get; set; }

        PeticionRecuperacionDeContraseña frmSolicitudDeRecuperacionCuenta;
        public PeticionesRegisro frmPeticionesRegisro;
        int idAdmin;
        public int IdEmpleado { get; set; }

        public string PeticionAccionVal;
        public string PeticionCodigoVal;
        public string PeticionVal;
        public DateTime PeticionFecha_De_EnvioVal;
        public string PeticionDescripcionVal;
        public string PeticionEstadoVal;
        public string PeticionUsuarioVal;
        public string PeticionUsuarioGuardar;
        public int PeticionUsuarioID;
        public PeticionesEmp(int idEmpledo)
        {
            InitializeComponent();
            InitializeComponent();
            IdEmpleado = idEmpledo;
            CargarPeticiones();
        }

        public void CargarPeticiones()
        {
            DataTable peticiones = PeticionesValidaciones.ObtenerPeticionesCompletasEmpl(IdEmpleado);
            dgvPeticiones.DataSource = peticiones;
        }

        private void dgvPeticiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvPeticiones.Rows[e.RowIndex];

                PeticionCodigoVal = filaSeleccionada.Cells["Codigo"].Value.ToString();
                PeticionAccionVal = filaSeleccionada.Cells["Accion"].Value.ToString();
                PeticionFecha_De_EnvioVal = Convert.ToDateTime(dgvPeticiones.Rows[e.RowIndex].Cells["Fecha_De_Envio"].Value);
                PeticionDescripcionVal = filaSeleccionada.Cells["Peticion"].Value.ToString();
                PeticionUsuarioVal = filaSeleccionada.Cells["Usuario"].Value.ToString();
                PeticionEstadoVal = filaSeleccionada.Cells["Estado"].Value.ToString();
            }
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            var peticionesRegistro = new PeticionesRegisro(IdEmpleado);
            peticionesRegistro.lblTituloRegistro.Text = "Guardar Nueva Petición";
            peticionesRegistro.Show();
            peticionesRegistro.txtUsuarioName.Hide();
            peticionesRegistro.label3.Hide();
            peticionesRegistro.btnGuardarUser.Text = "GUARDAR";
            peticionesRegistro.btnCancelar.Text = "CANCELAR";

            peticionesRegistro.btnGuardarUser.Click += (s, args) =>
            {

                Peticion nuevaPeticion = new Peticion
                {
                    CodigPeticion = peticionesRegistro.txtCodigoGenerado.Text,
                    AccionPeticion = peticionesRegistro.cbxPeticion.SelectedItem?.ToString() ?? string.Empty,
                    Descripcion = peticionesRegistro.txtDescripcion.Text,
                    FechaEnviada = peticionesRegistro.dtpFechaEnviada.Value,
                    FechaRealizada = DateTime.Now,
                    CodigoUsuario = peticionesRegistro.IdEmpleado,
                    Estado = peticionesRegistro.cbxEstadoCuenta.SelectedItem?.ToString() ?? "Activo"
                };
                try
                {
                    PeticionesValidaciones.GuardarPeticion(nuevaPeticion);

                    MessageBox.Show("Petición Registrada con Éxito.");
                    CargarPeticiones();
                }
                catch
                {
                    MessageBox.Show("Error al actualizar la petición.");

                }

            };
        }

        private void dgvPeticiones_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvPeticiones.Rows[e.RowIndex];

                PeticionCodigoVal = filaSeleccionada.Cells["Codigo"].Value.ToString();
                PeticionAccionVal = filaSeleccionada.Cells["Accion"].Value.ToString();
                PeticionFecha_De_EnvioVal = Convert.ToDateTime(dgvPeticiones.Rows[e.RowIndex].Cells["Fecha_De_Envio"].Value);
                PeticionDescripcionVal = filaSeleccionada.Cells["Peticion"].Value.ToString();
                PeticionUsuarioVal = filaSeleccionada.Cells["Usuario"].Value.ToString();
                PeticionEstadoVal = filaSeleccionada.Cells["Estado"].Value.ToString();
            }
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedItem != null)
            {
                string estadoSeleccionado = cbxFiltro.SelectedItem.ToString();

                if (estadoSeleccionado == "Pendiente")
                {
                    DataTable peticionesEstado = PeticionesValidaciones.FiltroPendienteCompletado("Pendiente");
                    dgvPeticiones.DataSource = peticionesEstado;
                }
                else if (estadoSeleccionado == "Completado")
                {
                    DataTable peticionesCompletadas = PeticionesValidaciones.FiltroPendienteCompletado("Completado");
                    dgvPeticiones.DataSource = peticionesCompletadas;
                }
                else if (estadoSeleccionado == "Activo")
                {
                    DataTable peticionesCompletadas = PeticionesValidaciones.FiltroPendienteCompletado("ACTIVO");
                    dgvPeticiones.DataSource = peticionesCompletadas;
                }
                else if (estadoSeleccionado == "Inactivo")
                {
                    DataTable peticionesCompletadas = PeticionesValidaciones.FiltroPendienteCompletado("INACTIVO");
                    dgvPeticiones.DataSource = peticionesCompletadas;
                }
                else if (estadoSeleccionado == "Todos")
                {
                    CargarPeticiones();
                }
                else
                {
                    CargarPeticiones();
                }
            }
        }
    }
}
