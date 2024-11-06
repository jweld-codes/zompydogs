using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zompyDogs.CRUD.AGREGAR;
using zompyDogs.CRUD.REGISTROS;
using ZompyDogsDAO;
using ZompyDogsLib;
using ZompyDogsLib.Controladores;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar;
using static ZompyDogsDAO.PeticionesValidaciones;
using static ZompyDogsDAO.UsuarioDAO;

namespace zompyDogs
{
    public partial class Usuarios : Form
    {
        public BienvenidaAdmin FormPrincipal { get; set; }
        private bool isUser = false;

        private string nuevoCodigoUsuario;
        private ControladorGeneradoresDeCodigo _controladorGeneradorCodigo;
        private UsuarioRegistro _usuarioRegistroForm;

        public string detalleUsuarioprimerNombreVal;
        public string detalleUsuariosegundoNombreVal;
        public string detalleUsuarioprimerApellidoVal;
        public string detalleUsuariosegundoApellidoVal;
        public string detalleUsuariocodigoCedulaVal;
        public DateTime detalleUsuariofechaNacimientoVal;
        public string detalleUsuarioestadoCivilVal;
        public string detalleUsuariotelefonoVal;
        public string detalleUsuariodireccionVal;
        public int detalleUsuariocodigoPuestoVal;
        public string detalleUsuariocodigoUsuarioVal;

        public Usuarios()
        {
            InitializeComponent();
            isUser = true;

            CargarUsuarios();
            CargarUsuariosAdministradores();
            CargarUsuariosEmpleados();
            CargarProveedores();

            dgvEmpleados.Hide();
            dgvAdminis.Hide();
            dgvProveedor.Hide();

            _controladorGeneradorCodigo = new ControladorGeneradoresDeCodigo();
            _usuarioRegistroForm = new UsuarioRegistro();
        }
        private void GeneradordeCodigoUsuarioFromForm()
        {
            nuevoCodigoUsuario = _controladorGeneradorCodigo.GeneradordeCodigoUsuario();
            _usuarioRegistroForm.txtCodigoGenerado.Text = nuevoCodigoUsuario;
        }
        private void CargarUsuarios()
        {
            DataTable usuarios = UsuarioDAO.ObtenerDetalllesDeUsuarios();
            dgvUsuarios.DataSource = usuarios;
        }

        private void CargarUsuariosEmpleados()
        {
            DataTable usuariosEmp = UsuarioDAO.ObtenerDetalllesDeUsuariosEmpleados();
            dgvEmpleados.DataSource = usuariosEmp;
        }
        private void CargarUsuariosAdministradores()
        {
            DataTable usuariosAdmin = UsuarioDAO.ObtenerDetalllesDeUsuariosAdmin();
            dgvAdminis.DataSource = usuariosAdmin;
        }
        private void CargarProveedores()
        {
            DataTable usuariosAdmin = UsuarioDAO.ObtenerDetalllesProveedores();
            dgvProveedor.DataSource = usuariosAdmin;
        }



        private void btnAbrirVentanaForm_Click(object sender, EventArgs e)
        {
            Inventario frminventario = new Inventario();
            frminventario.Show();
        }

        private void btnAgregarNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (isUser == true)
            {
                var usuarioGuardar = new UsuarioRegistro();
                usuarioGuardar.Show();
                usuarioGuardar.lblTituloRegistro.Text = "Agregar Nuevo Registro";
                usuarioGuardar.btnGuardarUser.Text = "GUARDAR";

                //llamar el metodo guardar usuario
                usuarioGuardar.btnGuardarUser.Click += (s, args) =>
                {
                    int siguienteID = UsuarioDAO.ObtenerSiguienteID();

                    DetalleUsuario nuevoDetalleUsuario = new DetalleUsuario
                    {
                        primerNombre = usuarioGuardar.txtPrimNombre.Text,
                        segundoNombre = usuarioGuardar.txtSegNombre.Text,
                        primerApellido = usuarioGuardar.txtPrimApellido.Text,
                        segundoApellido = usuarioGuardar.txtSegApellido.Text,
                        codigoCedula = usuarioGuardar.txtCedula.Text,
                        fechaNacimiento = usuarioGuardar.dtpFechaNacimiento.Value,
                        estadoCivil = usuarioGuardar.cbxEsatdoCivil.SelectedItem?.ToString() ?? string.Empty,
                        telefono = usuarioGuardar.txtTelefono.Text,
                        direccion = usuarioGuardar.txtDireccion.Text,
                        codigoPuesto = usuarioGuardar.cbPuesto.SelectedValue != null ? Convert.ToInt32(usuarioGuardar.cbPuesto.SelectedValue) : 1,
                        codigoUsuario = siguienteID.ToString(), 
                    };

                    UsuarioRegistro nuevoUsuarioRegistro = new UsuarioRegistro
                    {
                        UserName = usuarioGuardar.txtUsername.Text,
                        PassWord = usuarioGuardar.txtPassword.Text,
                        FechaRegistro = DateTime.Now, 
                        CodigoRol = usuarioGuardar.cbxRol.SelectedValue != null ? Convert.ToInt32(usuarioGuardar.cbxRol.SelectedValue) : 1, 
                        CodigoDetalleUsuario = siguienteID, 
                        Estado = usuarioGuardar.cbxEstado.Text
                    };

                    try
                    {
                        // Guardar DetalleUsuario
                        UsuarioDAO.GuardarDetalleUsuario(nuevoDetalleUsuario);

                        // Guardar UsuarioRegistro
                        UsuarioDAO.GuardarUsuario(nuevoUsuarioRegistro);

                        MessageBox.Show("Usuario Registrado con Éxito.");
                        CargarUsuarios();
                        CargarUsuariosAdministradores();
                        CargarUsuariosEmpleados();
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar el Usuario.");

                    }
                };
            }
            else
            {
                ProveedorRegistro frmProveedorRegistro = new ProveedorRegistro();
                frmProveedorRegistro.lblTituloRegistro.Text = "Agregar Nuevo Proveedor";
                frmProveedorRegistro.btnGuardarUser.Text = "GUARDAR";

                //llamar metodo para guardar proveedor

                frmProveedorRegistro.Show();

            }
        }
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (isUser)
            {
                var usuarioEditar = new UsuarioRegistro();
                usuarioEditar.lblTituloRegistro.Text = "Editar Registro";
                usuarioEditar.btnGuardarUser.Text = "EDITAR";

                usuarioEditar.Show();

                DataTable usuarioDatosEditar = UsuarioDAO.ObtenerDetalllesDeUsuariosParaEditar(detalleUsuariocodigoUsuarioVal);

                if (usuarioDatosEditar.Rows.Count > 0)
                {
                    DataRow fila = usuarioDatosEditar.Rows[0];

                    usuarioEditar.txtCodigoGenerado.Text = fila["Codigo"].ToString();
                    usuarioEditar.lblidDetalleUsuario.Text = fila["ID_DetalleUsuario"].ToString();
                    usuarioEditar.txtCedula.Text = fila["ID_Cedula"].ToString();
                    usuarioEditar.txtPrimNombre.Text = fila["Nombre_Usuario"].ToString();
                    usuarioEditar.txtSegNombre.Text = fila["Segundo_Nombre"].ToString();
                    usuarioEditar.txtPrimApellido.Text = fila["Apellido_Usuario"].ToString();
                    usuarioEditar.txtSegApellido.Text = fila["Segundo_Apellido"].ToString();
                    usuarioEditar.txtDireccion.Text = fila["Direccion"].ToString();
                    usuarioEditar.txtTelefono.Text = fila["Telefono"].ToString();
                    usuarioEditar.cbxEsatdoCivil.Text = fila["Estado_Civil"].ToString();
                    usuarioEditar.cbPuesto.Text = fila["Puesto"].ToString();
                    usuarioEditar.txtPassword.Text = fila["Clave"].ToString();

                    DateTime fechaNacimiento;
                    if (DateTime.TryParse(fila["Fecha_De_Nacimiento"].ToString(), out fechaNacimiento) &&
                        fechaNacimiento >= usuarioEditar.dtpFechaNacimiento.MinDate &&
                        fechaNacimiento <= usuarioEditar.dtpFechaNacimiento.MaxDate)
                    {
                        usuarioEditar.dtpFechaNacimiento.Value = fechaNacimiento;
                    }
                    else
                    {
                        usuarioEditar.dtpFechaNacimiento.Value = usuarioEditar.dtpFechaNacimiento.MinDate;
                    }

                    usuarioEditar.txtUsername.Text = fila["Usuario"].ToString();
                    usuarioEditar.cbxRol.Text = (fila["RolUsuario"].ToString() == "admin") ? "Administrador" : "Empleado";
                    usuarioEditar.txtSalario.Text = fila["Salario"].ToString();

                    usuarioEditar.txtPassword.Enabled = false;
                    usuarioEditar.txtUsername.Enabled = false;
                    usuarioEditar.cbHorasLaborales.Enabled = false;
                    usuarioEditar.txtSalario.Enabled = false;
                    usuarioEditar.btnGeneradorUsername.Enabled = false;
                    usuarioEditar.btnGeneradorPassword.Enabled = false;

                    usuarioEditar.btnGuardarUser.Click += (s, args) =>
                    {
                        try
                        {
                            if (string.IsNullOrWhiteSpace(usuarioEditar.txtCodigoGenerado.Text))
                            {
                                MessageBox.Show("Código de usuario no válido.");
                                return;
                            }

                            DetalleUsuario usuarioActualizado = new DetalleUsuario
                            {
                                primerNombre = usuarioEditar.txtPrimNombre.Text,
                                segundoNombre = usuarioEditar.txtSegNombre.Text,
                                primerApellido = usuarioEditar.txtPrimApellido.Text,
                                segundoApellido = usuarioEditar.txtSegApellido.Text,
                                codigoCedula = usuarioEditar.txtCedula.Text,
                                fechaNacimiento = usuarioEditar.dtpFechaNacimiento.Value,
                                estadoCivil = usuarioEditar.cbxEsatdoCivil.Text,
                                telefono = usuarioEditar.txtTelefono.Text,
                                direccion = usuarioEditar.txtDireccion.Text,
                                codigoUsuario = detalleUsuariocodigoUsuarioVal
                            };

                            if (usuarioEditar.cbPuesto.SelectedValue != null)
                            {
                                usuarioActualizado.codigoPuesto = Convert.ToInt32(usuarioEditar.cbPuesto.SelectedValue);
                            }
                            else
                            {
                                MessageBox.Show("Por favor selecciona un puesto válido.");
                                return;
                            }

                            bool resultado = UsuarioDAO.ActualizarDetalleUsuario(usuarioActualizado);
                            if (resultado)
                            {
                                MessageBox.Show("Usuario actualizado con éxito.");
                                CargarUsuarios();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar el usuario.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al actualizar el usuario: " + ex.Message);
                            Console.WriteLine("Detalles de la excepción: " + ex.ToString());
                        }
                    };
                }
                else
                {
                    MessageBox.Show("No se encontraron datos del usuario para editar.");
                }
            }
            else
            {
                ProveedorRegistro frmProveedorRegistro = new ProveedorRegistro();
                frmProveedorRegistro.lblTituloRegistro.Text = "Editar Proveedor";
                frmProveedorRegistro.btnGuardarUser.Text = "EDITAR";

                frmProveedorRegistro.Show();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(detalleUsuariocodigoUsuarioVal))
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
                return;
            }
            DialogResult check = MessageBox.Show("¿Está seguro de eliminar este usuario?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                bool eliminado = UsuarioDAO.EliminarUsuario(detalleUsuariocodigoUsuarioVal);

                if (eliminado)
                {
                    MessageBox.Show("Usuario eliminado con éxito.");
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario.");
                }
            }
        }

        private void btnUsuarioPanel_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender);
            isUser = true;
            CargarUsuarios();
            lblTituloRegistroPanel.Text = "Registros de Usuarios";
            dgvUsuarios.Show();
            dgvProveedor.Hide();
            lblBreadCrumbUser.Text = "USUARIOS";
            dgvEmpleados.Hide();
            dgvAdminis.Hide();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender);
            isUser = true;
            CargarUsuariosAdministradores();
            lblTituloRegistroPanel.Text = "Registros de Administradores";
            dgvUsuarios.Hide();
            dgvEmpleados.Hide();
            dgvProveedor.Hide();
            dgvAdminis.Show();
            lblBreadCrumbUser.Text = "ADMINISTRADORES";
        }

        private void btnEmpleadoPanel_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender);
            isUser = true;
            CargarUsuariosEmpleados();
            lblTituloRegistroPanel.Text = "Registros de Empleados";
            dgvUsuarios.Hide();
            dgvProveedor.Hide();
            dgvEmpleados.Show();
            lblBreadCrumbUser.Text = "EMPLEADOS";
            dgvAdminis.Hide();
        }

        private void btnPrveedores_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender);
            isUser = false;
            CargarProveedores();
            lblTituloRegistroPanel.Text = "Registros de Proveedores";
            dgvUsuarios.Hide();
            dgvEmpleados.Hide();
            dgvAdminis.Hide();
            dgvProveedor.Show();
            lblBreadCrumbUser.Text = "PROVEEDORES";
        }

        private void CambiarColorBoton(Button botonActivo)
        {
            foreach (Control ctrl in topBarMenu.Controls)
            {
                if (ctrl is Button)
                {
                    Button boton = (Button)ctrl;
                    boton.BackColor = Color.Transparent;
                    boton.ForeColor = Color.White;
                }
            }

            botonActivo.BackColor = Color.White;
            botonActivo.ForeColor = Color.Black;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvUsuarios.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                detalleUsuariocodigoUsuarioVal = filaSeleccionada.Cells["Codigo"].Value.ToString();
            }
        }

        private void btnRefreshDG_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarUsuariosAdministradores();
            CargarUsuariosEmpleados();
            CargarProveedores();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscarUsuario.Text;
            DataTable resultados = UsuarioDAO.BuscadorDeUsuarios(valorBusqueda);
            dgvUsuarios.DataSource = resultados;
            dgvEmpleados.DataSource = resultados;
            dgvAdminis.DataSource = resultados;
            dgvProveedor.DataSource = resultados;
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedItem != null)
            {
                string estadoSeleccionado = cbxFiltro.SelectedItem.ToString();

                if (estadoSeleccionado == "Activo" || estadoSeleccionado == "ACTIVO")
                {
                    DataTable usuariosFiltro = UsuarioDAO.FiltroDeUsuarios("ACTIVO");
                    dgvUsuarios.DataSource = usuariosFiltro;
                }
                else if (estadoSeleccionado == "Inactivo" || estadoSeleccionado == "INACTIVO")
                {
                    DataTable usuariosFiltro = UsuarioDAO.FiltroDeUsuarios("INACTIVO");
                    dgvUsuarios.DataSource = usuariosFiltro;
                }
                else if (estadoSeleccionado == "Todos")
                {
                    CargarUsuarios();
                    CargarUsuariosAdministradores();
                    CargarUsuariosEmpleados();
                    CargarProveedores();
                }
            }
        }
    }
}
