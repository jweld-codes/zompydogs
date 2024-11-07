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

namespace zompyDogs
{
    public partial class Facturas : Form
    {
        public BienvenidaAdmin FormPrincipal { get; set; }
        public EmpleadoBienvenida EmpleadoFormPrincipal { get; set; }

        private int usuarioIDActual;
        private string pedidoCodigoEmpleadoVal;
        public Facturas(int usuarioIDActual)
        {
            InitializeComponent();
            this.usuarioIDActual = usuarioIDActual;

            CargarFacturas();
        }
        private void CargarFacturas()
        {
            DataTable facturas = PedidosDAO.ObtenerDetalllesPedidos_DGV();
            dgvHistorialPedidos.DataSource = facturas;
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

        private void btnPuntoVenta_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender);
            if (FormPrincipal != null)
            {
                FormPrincipal.AbrirFormsHija(new frmPOS(usuarioIDActual) { FormPrincipal = FormPrincipal });
            }
            else if (EmpleadoFormPrincipal != null)
            {
                EmpleadoFormPrincipal.AbrirFormsHijaEmpleado(new frmPOS(usuarioIDActual) { EmpleadoFormPrincipal = EmpleadoFormPrincipal });
            }
            else
            {
                MessageBox.Show("Form es nulo");
            }
        }

        private void btnVisualizarRegistro_Click(object sender, EventArgs e)
        {
            var facturaView = new FacturaView();

            // Deshabilitar todos los elementos del formulario
            foreach (Control control in facturaView.Controls)
            {
                control.Enabled = false;
            }
            facturaView.Show();

            DataTable facturaDatosView = PedidosDAO.ObtenerDetalllesDeFacturaPorEmpleado(pedidoCodigoEmpleadoVal);

            if (facturaDatosView.Rows.Count > 0)
            {
                DataRow fila = facturaDatosView.Rows[0];

                facturaView.txtCodigoGenerado.Text = fila["Codigo_Pedido"].ToString();
                facturaView.lblCodigoEmpleado.Text = fila["Codigo_Empleado"].ToString();
                facturaView.txtEmpleado.Text = fila["Empleado"].ToString();
                facturaView.dtpFechaRegistro.Text = fila["Fecha_Del_Pedido"].ToString();
                facturaView.lblTotal.Text = fila["Total_a_Pagar"].ToString();
                facturaView.lblSubtotal.Text = fila["Subtotal"].ToString();
                facturaView.lblISV.Text = fila["ISV"].ToString();
                facturaView.lblTotalProductos.Text = fila["Total_De_Productos"].ToString();
                facturaView.txtEstado.Text = fila["Estado"].ToString();
            }

        }

        private void dgvHistorialPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvHistorialPedidos.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                pedidoCodigoEmpleadoVal = filaSeleccionada.Cells["Codigo_Empleado"].Value.ToString();
            }
        }
    }
}
