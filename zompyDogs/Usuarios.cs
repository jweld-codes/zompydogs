﻿using Azure.Identity;
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

        public string detalleUsuarioRol;
        public int detalleUsuarioID;
        public string detalleUsuariocodigoUsuarioVal;
        public string proveedorcodigoUsuarioVal;

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

            cbxFiltro.Hide();

            _controladorGeneradorCodigo = new ControladorGeneradoresDeCodigo();
            _usuarioRegistroForm = new UsuarioRegistro();
        }

        /********** Generador de Codigo Para Usuarios ********/
        private void GeneradordeCodigoUsuarioFromForm()
        {
            nuevoCodigoUsuario = _controladorGeneradorCodigo.GeneradordeCodigoUsuario();
            _usuarioRegistroForm.txtCodigoGenerado.Text = nuevoCodigoUsuario;
        }

        /********** Cargadores de Datos ********/
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

        /********** CRUD Para Usuarios ********/
        
        //GUARDA NUEVO REGISTRO DE USUARIOS
        private void btnAgregarNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (isUser == true)
            {
                var usuarioGuardar = new UsuarioRegistro();
                usuarioGuardar.Show();
                usuarioGuardar.lblTituloRegistro.Text = "Agregar Nuevo Registro";
                usuarioGuardar.btnGuardarUser.Text = "GUARDAR";

                usuarioGuardar.dtpFechaRegistro.Enabled = false;
                
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
                        codigoUsuario = usuarioGuardar.txtCodigoGenerado.Text,
                    };
                    try
                    {
                        // Guardar DetalleUsuario
                        UsuarioDAO.GuardarDetalleUsuario(nuevoDetalleUsuario);

                        UsuarioCrear nuevoUsuarioRegistro = new UsuarioCrear
                        {
                            UserName = usuarioGuardar.txtUsername.Text,
                            PassWord = usuarioGuardar.txtPassword.Text,
                            FechaRegistro = usuarioGuardar.dtpFechaRegistro.Value.Date,
                            CodigoRol = usuarioGuardar.cbxRol.SelectedValue != null ? Convert.ToInt32(usuarioGuardar.cbxRol.SelectedValue) : 1,
                            CodigoDetalleUsuario = siguienteID,
                        };

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
                var proveedorGuardar = new ProveedorRegistro();
                proveedorGuardar.Show();
                proveedorGuardar.lblTituloRegistro.Text = "Agregar Nuevo Proveedor";
                proveedorGuardar.btnGuardarProv.Text = "GUARDAR";

                proveedorGuardar.dtpFechaRegistro.Enabled = false;

                proveedorGuardar.btnGuardarProv.Click += (s, args) =>
                {
                    ProveedorCrear nuevoProveedor = new ProveedorCrear
                    {
                        CodigoProv = proveedorGuardar.txtCodigoGenerado.Text,
                        NombreProv = proveedorGuardar.txtNombreProv.Text,
                        FechaRegistroProv = proveedorGuardar.dtpFechaRegistro.Value.Date,
                        ContactoProv = proveedorGuardar.txtPrimNombre.Text,
                        ApellidoContactoProv = proveedorGuardar.txtSegNombre.Text,
                        TelefonoProv = proveedorGuardar.txtTelefono.Text,
                        EmailProv = proveedorGuardar.txtEmail.Text,
                        EstadoProv = proveedorGuardar.cbxEstado.Text
                    };

                    try
                    {
                        UsuarioDAO.GuardarProveedor(nuevoProveedor);

                        MessageBox.Show("Proveedor Registrado con Éxito.");
                        CargarProveedores();
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar el proveedor.");
                    }
                };

            }
        }

        //Edita los datos de los usuarios
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

                    usuarioEditar.lblidDetalleUsuario.Text = fila["ID_DetalleUsuario"].ToString();
                    usuarioEditar.txtCodigoGenerado.Text = fila["Codigo"].ToString();
                    usuarioEditar.txtCodigoGenerado.Enabled = false;

                    usuarioEditar.txtCedula.Text = fila["ID_Cedula"].ToString();
                    usuarioEditar.txtCedula.Enabled = false;

                    usuarioEditar.txtPrimNombre.Text = fila["Nombre_Usuario"].ToString();
                    usuarioEditar.txtSegNombre.Text = fila["Segundo_Nombre"].ToString();
                    usuarioEditar.txtPrimApellido.Text = fila["Apellido_Usuario"].ToString();
                    usuarioEditar.txtSegApellido.Text = fila["Segundo_Apellido"].ToString();

                    usuarioEditar.txtDireccion.Text = fila["Direccion"].ToString();
                    usuarioEditar.txtTelefono.Text = fila["Telefono"].ToString();

                    usuarioEditar.cbxEsatdoCivil.Text = fila["Estado_Civil"].ToString();
                    usuarioEditar.cbPuesto.Text = fila["Puesto"].ToString();

                    usuarioEditar.txtPassword.Text = fila["Clave"].ToString();
                    usuarioEditar.txtUsername.Text = fila["Usuario"].ToString();
                    usuarioEditar.cbxRol.Text = fila["RolUsuario"].ToString();

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
                    usuarioEditar.dtpFechaRegistro.Enabled = false;
                    usuarioEditar.dtpFechaNacimiento.Enabled = false;

                    usuarioEditar.txtPassword.Enabled = false;
                    usuarioEditar.txtUsername.Enabled = false;
                    usuarioEditar.btnGeneradorUsername.Enabled = false;
                    usuarioEditar.btnGeneradorPassword.Enabled = false;
                    usuarioEditar.txtCedula.Enabled = false;
                    usuarioEditar.cbxRol.Enabled = false;

                    usuarioEditar.btnGuardarUser.Click += (s, args) =>
                    {
                        try
                        {
                            if (string.IsNullOrWhiteSpace(usuarioEditar.txtCodigoGenerado.Text))
                            {
                                MessageBox.Show("Código de usuario no válido.");
                                return;
                            }

                            DetalleUsuario detalleUsuarioActualizado = new DetalleUsuario
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
                                codigoPuesto = usuarioEditar.cbPuesto.SelectedValue != null ? Convert.ToInt32(usuarioEditar.cbPuesto.SelectedValue) : 1,
                                codigoUsuario = detalleUsuariocodigoUsuarioVal
                            };

                            if (usuarioEditar.cbPuesto.SelectedValue == null)
                            {
                                MessageBox.Show("Por favor selecciona un puesto válido.");
                                return;
                            }

                            bool resultadoDetalle = UsuarioDAO.ActualizarDetalleUsuario(detalleUsuarioActualizado);

                            if (resultadoDetalle)
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
                            MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
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
                var frmProveedorRegistro = new ProveedorRegistro();
                frmProveedorRegistro.lblTituloRegistro.Text = "Editar Proveedor";
                frmProveedorRegistro.btnGuardarProv.Text = "EDITAR";

                frmProveedorRegistro.Show();

                DataTable proveedoresDatosEditar = UsuarioDAO.ObtenerDetalllesDeProveedoresParaEditar(proveedorcodigoUsuarioVal);

                if (proveedoresDatosEditar.Rows.Count > 0)
                {
                    DataRow fila = proveedoresDatosEditar.Rows[0];

                    frmProveedorRegistro.txtCodigoGenerado.Text = fila["Codigo"].ToString();
                    frmProveedorRegistro.txtCodigoGenerado.Enabled = false;

                    frmProveedorRegistro.txtNombreProv.Text = fila["Proveedor"].ToString();
                    frmProveedorRegistro.txtPrimNombre.Text = fila["Nombre"].ToString();
                    frmProveedorRegistro.txtSegNombre.Text = fila["Apellido"].ToString();
                    frmProveedorRegistro.txtTelefono.Text = fila["Telefono"].ToString();
                    frmProveedorRegistro.txtEmail.Text = fila["Correo"].ToString();
                    frmProveedorRegistro.cbxEstado.Text = fila["Estado"].ToString();
                    frmProveedorRegistro.dtpFechaRegistro.Enabled = false;
                    frmProveedorRegistro.btnGuardarProv.Click += (s, args) =>
                    {
                        try
                        {
                            if (string.IsNullOrWhiteSpace(frmProveedorRegistro.txtCodigoGenerado.Text))
                            {
                                MessageBox.Show("Código de proveedor no válido.");
                                return;
                            }

                            ProveedorCrear proveedorActualizador = new ProveedorCrear
                            {
                                NombreProv = frmProveedorRegistro.txtNombreProv.Text,
                                ContactoProv = frmProveedorRegistro.txtPrimNombre.Text,
                                TelefonoProv = frmProveedorRegistro.txtTelefono.Text,
                                EmailProv = frmProveedorRegistro.txtEmail.Text,
                                EstadoProv = frmProveedorRegistro.cbxEstado.Text,
                                ApellidoContactoProv = frmProveedorRegistro.txtSegNombre.Text,
                                CodigoProv = proveedorcodigoUsuarioVal
                            };

                            bool resultado = UsuarioDAO.ActualizarProveedotes(proveedorActualizador);

                            if (resultado)
                            {
                                MessageBox.Show("Proveedor actualizado con éxito.");
                                CargarProveedores();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar el proveedor.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al actualizar el proveedot: " + ex.Message);
                            Console.WriteLine("Detalles de la excepción: " + ex.ToString());
                        }
                    };


                }
            }
        }
        private void btnVisualizarRegistro_Click(object sender, EventArgs e)
        {
            if (isUser == true)
            {
                var usuarioView = new UsuarioRegistro();
                usuarioView.lblTituloRegistro.Text = "Ver Registro";
                usuarioView.btnGuardarUser.Hide();

                // Deshabilitar todos los elementos del formulario
                foreach (Control control in usuarioView.Controls)
                {
                    control.Enabled = false;
                }
                usuarioView.btnCancelar.Text = "SALIR";
                usuarioView.btnCancelar.Enabled = true;
                usuarioView.Show();

                DataTable usuarioDatosEditar = UsuarioDAO.ObtenerDetalllesDeUsuariosParaEditar(detalleUsuariocodigoUsuarioVal);

                if (usuarioDatosEditar.Rows.Count > 0)
                {
                    DataRow fila = usuarioDatosEditar.Rows[0];

                    usuarioView.txtCodigoGenerado.Text = fila["Codigo"].ToString();
                    usuarioView.lblidDetalleUsuario.Text = fila["ID_DetalleUsuario"].ToString();
                    usuarioView.txtCedula.Text = fila["ID_Cedula"].ToString();
                    usuarioView.txtPrimNombre.Text = fila["Nombre_Usuario"].ToString();
                    usuarioView.txtSegNombre.Text = fila["Segundo_Nombre"].ToString();
                    usuarioView.txtPrimApellido.Text = fila["Apellido_Usuario"].ToString();
                    usuarioView.txtSegApellido.Text = fila["Segundo_Apellido"].ToString();
                    usuarioView.txtDireccion.Text = fila["Direccion"].ToString();
                    usuarioView.txtTelefono.Text = fila["Telefono"].ToString();
                    usuarioView.cbxEsatdoCivil.Text = fila["Estado_Civil"].ToString();

                    usuarioView.cbPuesto.Text = fila["Puesto"].ToString();
                    usuarioView.txtPassword.Text = fila["Clave"].ToString();

                    DateTime fechaNacimiento;
                    if (DateTime.TryParse(fila["Fecha_De_Nacimiento"].ToString(), out fechaNacimiento) &&
                        fechaNacimiento >= usuarioView.dtpFechaNacimiento.MinDate &&
                        fechaNacimiento <= usuarioView.dtpFechaNacimiento.MaxDate)
                    {
                        usuarioView.dtpFechaNacimiento.Value = fechaNacimiento;
                    }
                    else
                    {
                        usuarioView.dtpFechaNacimiento.Value = usuarioView.dtpFechaNacimiento.MinDate;
                    }

                    usuarioView.txtUsername.Text = fila["Usuario"].ToString();
                    usuarioView.cbxRol.Text = (fila["RolUsuario"].ToString() == "admin") ? "Administrador" : "Empleado";
                    
                }
            }
            else
            {
                var frmProveedorRegistro = new ProveedorRegistro();
                frmProveedorRegistro.lblTituloRegistro.Text = "Ver Proveedor";
                frmProveedorRegistro.Show();

                DataTable proveedoresDatos = UsuarioDAO.ObtenerDetalllesDeProveedoresParaEditar(proveedorcodigoUsuarioVal);

                if (proveedoresDatos.Rows.Count > 0)
                {
                    DataRow fila = proveedoresDatos.Rows[0];

                    frmProveedorRegistro.dtpFechaRegistro.Enabled = false;

                    frmProveedorRegistro.txtCodigoGenerado.Text = fila["Codigo"].ToString();
                    frmProveedorRegistro.txtCodigoGenerado.Enabled = false;

                    frmProveedorRegistro.txtNombreProv.Text = fila["Proveedor"].ToString();
                    frmProveedorRegistro.txtNombreProv.Enabled = false;

                    frmProveedorRegistro.txtPrimNombre.Text = fila["Nombre"].ToString();
                    frmProveedorRegistro.txtPrimNombre.Enabled = false;

                    frmProveedorRegistro.txtSegNombre.Text = fila["Apellido"].ToString();
                    frmProveedorRegistro.txtSegNombre.Enabled = false;

                    frmProveedorRegistro.txtTelefono.Text = fila["Telefono"].ToString();
                    frmProveedorRegistro.txtTelefono.Enabled = false;

                    frmProveedorRegistro.txtEmail.Text = fila["Correo"].ToString();
                    frmProveedorRegistro.txtEmail.Enabled = false;

                    frmProveedorRegistro.cbxEstado.Text = fila["Estado"].ToString();
                    frmProveedorRegistro.cbxEstado.Enabled = false;

                    frmProveedorRegistro.btnGuardarProv.Hide();
                    frmProveedorRegistro.btnCancelar.Text = "Salir";
                }

            }
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            DataTable usuarioTabla = UsuarioDAO.ObtenerDetalllesDeUsuariosParaEditar(detalleUsuariocodigoUsuarioVal);
            var usuariosRegistroForm = new UsuarioRegistro();
            if (usuarioTabla.Rows.Count > 0)
            {
                DataRow fila = usuarioTabla.Rows[0];
                usuariosRegistroForm.lblidDetalleUsuario.Text = fila["ID_DetalleUsuario"].ToString();
            }

            detalleUsuarioID = Convert.ToInt32(usuariosRegistroForm.lblidDetalleUsuario.Text);

            DialogResult check = MessageBox.Show("¿Está seguro de eliminar este usuario?",
            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                bool eliminadoUsuario = UsuarioDAO.EliminarUsuario(detalleUsuarioID);
                bool eliminadoDetalle = UsuarioDAO.EliminarUsuarioPorDetalle(detalleUsuariocodigoUsuarioVal);

                if (eliminadoUsuario)
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


        /******** Top Menu Navegador ***********/
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
            cbxFiltro.Hide();

            txtBuscarUsuario.TextChanged += (s, args) =>
            {
                string valorBusqueda = txtBuscarUsuario.Text;
                DataTable resultados = UsuarioDAO.BuscadorDeUsuarios(valorBusqueda);
                dgvEmpleados.DataSource = resultados;
            };
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
            cbxFiltro.Hide();
            lblBreadCrumbUser.Text = "ADMINISTRADORES";

            txtBuscarUsuario.TextChanged += (s, args) =>
            {
                string valorBusqueda = txtBuscarUsuario.Text;
                DataTable resultados = UsuarioDAO.BuscadorDeUsuariosAdmins(valorBusqueda);
                dgvAdminis.DataSource = resultados;
            };
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
            cbxFiltro.Hide();

            txtBuscarUsuario.TextChanged += (s, args) =>
            {
                string valorBusqueda = txtBuscarUsuario.Text;
                DataTable resultados = UsuarioDAO.BuscadorDeUsuariosEmps(valorBusqueda);
                dgvEmpleados.DataSource = resultados;
            };
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
            cbxFiltro.Show();

            btnRefreshDG.Show();

            lblBreadCrumbUser.Text = "PROVEEDORES";

            txtBuscarUsuario.TextChanged += (s, args) =>
            {
                string valorBusqueda = txtBuscarUsuario.Text;
                DataTable resultados = UsuarioDAO.BuscadorDeProveedores(valorBusqueda);
                dgvProveedor.DataSource = resultados;
            };

            btnEliminarUsuario.Click += (s, args) =>
            {
                DialogResult check = MessageBox.Show("¿Está seguro de eliminar este proveedor?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    bool eliminarProveedor = UsuarioDAO.EliminarProveedor(proveedorcodigoUsuarioVal);

                    if (eliminarProveedor)
                    {
                        MessageBox.Show("Proveedor eliminado con éxito.");
                        CargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el proveedor.");
                    }
                }
            };
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

        /****** Seleccionadores de Datos en DataGrid ************/
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvUsuarios.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                detalleUsuariocodigoUsuarioVal = filaSeleccionada.Cells["Codigo"].Value.ToString();
                detalleUsuarioRol = filaSeleccionada.Cells["RolUsuario"].Value.ToString();
            }
        }
        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvProveedor.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                proveedorcodigoUsuarioVal = filaSeleccionada.Cells["Codigo"].Value.ToString();
            }
        }
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvEmpleados.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                detalleUsuariocodigoUsuarioVal = filaSeleccionada.Cells["Codigo"].Value.ToString();
                detalleUsuarioRol = filaSeleccionada.Cells["RolUsuario"].Value.ToString();
            }
        }
        private void dgvAdminis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvAdminis.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                detalleUsuariocodigoUsuarioVal = filaSeleccionada.Cells["Codigo"].Value.ToString();
                detalleUsuarioRol = filaSeleccionada.Cells["RolUsuario"].Value.ToString();
            }
        }

        /********* Extras *************/
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
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedItem != null)
            {
                string estadoSeleccionado = cbxFiltro.SelectedItem.ToString();

                if (estadoSeleccionado == "Activo" || estadoSeleccionado == "ACTIVO")
                {
                    DataTable proveedorFiltro = UsuarioDAO.FiltroDeProveedores("ACTIVO");
                    dgvProveedor.DataSource = proveedorFiltro;
                }
                else if (estadoSeleccionado == "Inactivo" || estadoSeleccionado == "INACTIVO")
                {
                    DataTable proveedorFiltro = UsuarioDAO.FiltroDeProveedores("INACTIVO");
                    dgvProveedor.DataSource = proveedorFiltro;
                }
                else if (estadoSeleccionado == "Todos")
                {
                    CargarProveedores();
                }
            }
        }
       
    }
}
