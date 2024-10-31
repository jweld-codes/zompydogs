using Microsoft.Identity.Client;
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
using static ZompyDogsDAO.PeticionesValidaciones;

namespace zompyDogs.CRUD.REGISTROS
{
    public partial class PeticionesRegisro : Form
    {
        private ControladorGeneradoresDeCodigo _controladorGeneradorCodigo;

        private string nuevoCodigoPeticion;
        public int Guardar = 0;
        public int Editar = 0;
        private int idAdmin;
        private int idObtenido;

        public int IdEmpleado { get; set; }
        public BienvenidaAdmin FormPrincipal { get; set; }

        Peticiones frmPeticiones;
        public EmpleadoBienvenida EmpleadoFormPrincipal { get; set; }
        public PeticionesRegisro(int idEmpleado)
        {
            InitializeComponent();

            IdEmpleado = idEmpleado;
            _controladorGeneradorCodigo = new ControladorGeneradoresDeCodigo();
            GeneradordeCodigoPeticionFromForm();
        }

        /*private void ObtenerIDxUser(string nombreUsuario)
        {
            // Obtén el ID del usuario mediante el nombre
            idUsuario = UsuarioDAO.ObtenerIDPorNombreUsuario(nombreUsuario);

            // Verifica si se obtuvo un ID válido y lo muestra en el TextBox correspondiente
            if (idUsuario.HasValue)
            {
                MessageBox.Show($"ID de Usuario encontrado: {idUsuario.Value}");
                txtUsuarioName.Text = idUsuario.Value.ToString();  // Suponiendo que tienes un TextBox llamado txtUserID
            }
            else
            {
                MessageBox.Show("No se encontró el ID para el usuario especificado.");
            }
        }*/

        private void GeneradordeCodigoPeticionFromForm()
        {
            nuevoCodigoPeticion = _controladorGeneradorCodigo.GeneradordeCodigoPeticion();
            txtCodigoGenerado.Text = nuevoCodigoPeticion;
        }

        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            Guardar = 1;
            Editar = 2;

            switch (Guardar)
            {
                case 1:
                    try
                    {

                        /*  Peticion nuevaPeticion = new Peticion
                          {
                              CodigPeticion = txtCodigoGenerado.Text,
                              AccionPeticion = cbxPeticion.SelectedItem?.ToString() ?? string.Empty,
                              Descripcion = txtDescripcion.Text,
                              FechaEnviada = dtpFechaEnviada.Value,
                              FechaRealizada = DateTime.Now,
                              CodigoUsuario = IdEmpleado,
                              Estado = cbxEstadoCuenta.SelectedItem?.ToString() ?? "AC"
                          };

                          PeticionesValidaciones.GuardarPeticion(nuevaPeticion);

                          MessageBox.Show("Petición Registrada con Éxito.");

                          this.Hide();*/
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al registrar la petición: " + ex.Message);
                    }

                    break;
                case 2:
                    MessageBox.Show("Case 2");

                    break;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
