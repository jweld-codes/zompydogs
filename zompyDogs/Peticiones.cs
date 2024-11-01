﻿using System;
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
    public partial class Peticiones : Form
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

        public Peticiones(int idEmpledo)
        {
            InitializeComponent();
            IdEmpleado = idEmpledo;
            CargarPeticiones();
        }
        public void CargarPeticiones()
        {
            DataTable peticiones = PeticionesValidaciones.ObtenerPeticionesCompletasAdmin();
            dgvPeticiones.DataSource = peticiones;
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {

            if (PeticionAccionVal == "Recuperación de contraseña")
            {
                var peticionesRecuperacion = new PeticionRecuperacionDeContraseña();
                peticionesRecuperacion.lblTituloRegistro.Text = "Recuperación de contraseña";

                peticionesRecuperacion.txtCodigoGenerado.Text = PeticionCodigoVal;
                peticionesRecuperacion.txtCodigoGenerado.Enabled = false;

                peticionesRecuperacion.txtAccionPeticion.Text = PeticionAccionVal;
                peticionesRecuperacion.txtAccionPeticion.Enabled = false;

                peticionesRecuperacion.txtDescripcion.Text = PeticionDescripcionVal;
                peticionesRecuperacion.txtDescripcion.Enabled = false;

                peticionesRecuperacion.dtpFechaEnviada.Value = PeticionFecha_De_EnvioVal;
                peticionesRecuperacion.dtpFechaEnviada.Enabled = false;

                peticionesRecuperacion.txtUsername.Text = PeticionUsuarioVal;
                peticionesRecuperacion.txtUsername.Enabled = false;

                peticionesRecuperacion.txtEstado.Text = PeticionEstadoVal;
                peticionesRecuperacion.txtEstado.Enabled = false;

                peticionesRecuperacion.btnRecuperacion.Text = "CONFIRMAR";
                peticionesRecuperacion.btnCancelar.Text = "CANCELAR";
                peticionesRecuperacion.btnCancelar.Hide();

                peticionesRecuperacion.Show();
            }

            else
            {
                var peticionesRegistro = new PeticionesRegisro(IdEmpleado);
                peticionesRegistro.lblTituloRegistro.Text = "Guardar Nueva Petición";
                peticionesRegistro.Show();
                peticionesRegistro.txtUsuarioName.Hide();
                peticionesRegistro.label3.Hide();
                peticionesRegistro.btnGuardarUser.Text = "GUARDAR";
                peticionesRegistro.btnCancelar.Text = "CANCELAR";

                //metodo para guardar
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
                        Estado =peticionesRegistro.cbxEstadoCuenta.SelectedItem?.ToString() ?? "Activo"
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

        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PeticionCodigoVal))
            {
                MessageBox.Show("Por favor, selecciona una petición para eliminar.");
                return;
            }

            DialogResult check = MessageBox.Show("¿Está seguro de eliminar su petición?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                bool eliminado = PeticionesValidaciones.EliminarPeticion(PeticionCodigoVal);

                if (eliminado)
                {
                    MessageBox.Show("Petición eliminada con éxito.");
                    CargarPeticiones(); // Refresca el DataGridView
                }
                else
                {
                    MessageBox.Show("Error al eliminar la petición.");
                }
            }
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

        private void Peticiones_Load(object sender, EventArgs e)
        {
            cbxFiltro.Items.Add("Todos");
            cbxFiltro.Items.Add("Pendiente");
            cbxFiltro.Items.Add("Completado");
            cbxFiltro.Items.Add("Activo");
            cbxFiltro.Items.Add("Inactivo");
        }

        private void btnRefreshDG_Click(object sender, EventArgs e)
        {
            CargarPeticiones();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PeticionesRegisro frmpeticionesRegistro = new PeticionesRegisro(2);
            frmpeticionesRegistro.Guardar = 2;

            var peticionEditar = new PeticionesRegisro(IdEmpleado);
            peticionEditar.lblTituloRegistro.Text = "Editar Petición";

            peticionEditar.txtCodigoGenerado.Text = PeticionCodigoVal;
            peticionEditar.txtCodigoGenerado.Enabled = false;

            peticionEditar.cbxPeticion.Text = PeticionAccionVal;
            peticionEditar.txtDescripcion.Text = PeticionDescripcionVal;
            peticionEditar.txtUsuarioName.Text = PeticionUsuarioVal;
            peticionEditar.txtUsuarioName.Enabled = false;
            peticionEditar.dtpFechaEnviada.Value = PeticionFecha_De_EnvioVal;
            peticionEditar.cbxEstadoCuenta.Text = PeticionEstadoVal;
            peticionEditar.cbxEstadoCuenta.Enabled = true;

            peticionEditar.btnGuardarUser.Text = "CONFIRMAR";
            peticionEditar.btnCancelar.Text = "CANCELAR";
            peticionEditar.btnCancelar.Hide();

            peticionEditar.Show();

            peticionEditar.btnGuardarUser.Click += (s, args) =>
            {
                Peticion peticionActualizada = new Peticion
                {
                    CodigPeticion = peticionEditar.txtCodigoGenerado.Text,
                    AccionPeticion = peticionEditar.cbxPeticion.Text,
                    Descripcion = peticionEditar.txtDescripcion.Text,
                    FechaEnviada = peticionEditar.dtpFechaEnviada.Value,
                    FechaRealizada = DateTime.Now,
                    CodigoUsuario = IdEmpleado,
                    Estado = peticionEditar.cbxEstadoCuenta.Text
                };

                bool resultado = PeticionesValidaciones.ActualizarPeticion(peticionActualizada);

                if (resultado)
                {
                    CargarPeticiones();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la petición.");
                }
            };
        }

        private void btnVisualizarRegistro_Click(object sender, EventArgs e)
        {
            var peticionView = new PeticionesRegisro(IdEmpleado);
            peticionView.lblTituloRegistro.Text = "Ver Petición";

            peticionView.txtCodigoGenerado.Text = PeticionCodigoVal;
            peticionView.txtCodigoGenerado.Enabled = false;

            peticionView.cbxPeticion.Text = PeticionAccionVal;
            peticionView.cbxPeticion.Enabled = false;

            peticionView.txtDescripcion.Text = PeticionDescripcionVal;
            peticionView.txtDescripcion.Enabled = false;

            peticionView.txtUsuarioName.Text = PeticionUsuarioVal;
            peticionView.txtUsuarioName.Enabled = false;

            peticionView.dtpFechaEnviada.Value = PeticionFecha_De_EnvioVal;
            peticionView.dtpFechaEnviada.Enabled = false;

            peticionView.cbxEstadoCuenta.Text = PeticionEstadoVal;
            peticionView.cbxEstadoCuenta.Enabled = false;

            peticionView.btnCancelar.Text = "Salir";
            peticionView.btnGuardarUser.Hide();

            peticionView.Show();
        }



        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscarUsuario.Text;
            DataTable resultados = PeticionesValidaciones.BuscarPeticionesPorUsuario(valorBusqueda);
            dgvPeticiones.DataSource = resultados;
        }

        private void Peticiones_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
