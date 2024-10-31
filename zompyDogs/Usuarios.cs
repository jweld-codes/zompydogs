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
// using ZompyDogsDAO.UsuarioDAO;
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
        public Usuarios()
        {
            InitializeComponent();
            isUser = true;
            CargarUsuarios();

            dgvEmpleados.Hide();
            dgvAdminis.Hide();
            dgvProveedor.Hide();

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
                        codigoPuesto = usuarioGuardar.cbPuesto.SelectedValue != null? Convert.ToInt32(usuarioGuardar.cbPuesto.SelectedValue): 1,
                        codigoUsuario = usuarioGuardar.txtCodigoGenerado.Text,
                    };

                    try
                    {
                        UsuarioDAO.GuardarDetalleUsuario(nuevoDetalleUsuario);

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
            if (isUser == true)
            {
                UsuarioRegistro addNuevoRegistro = new UsuarioRegistro();
                addNuevoRegistro.lblTituloRegistro.Text = "Editar Registro";
                addNuevoRegistro.btnGuardarUser.Text = "EDITAR";
                addNuevoRegistro.Show();
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
            if (isUser == true)
            {
                UsuarioRegistro addNuevoRegistro = new UsuarioRegistro();
                addNuevoRegistro.lblTituloRegistro.Text = "Eliminar Registro";
                addNuevoRegistro.btnGuardarUser.Text = "ELIMINAR";
                addNuevoRegistro.Show();
            }
            else
            {
                ProveedorRegistro frmProveedorRegistro = new ProveedorRegistro();
                frmProveedorRegistro.lblTituloRegistro.Text = "Eliminar Proveedor";
                frmProveedorRegistro.btnGuardarUser.Text = "ELIMINAR";

                frmProveedorRegistro.Show();

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
    }
}
