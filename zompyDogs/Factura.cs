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

namespace zompyDogs
{
    public partial class Factura : Form
    {
        public BienvenidaAdmin FormPrincipal { get; set; }
        public EmpleadoBienvenida EmpleadoFormPrincipal { get; set; }
        public Factura()
        {
            InitializeComponent();
            CargarPedidos();
        }

        private void CargarPedidos()
        {
            DataTable pedidos = PedidosDAO.ObtenerDetallesdePedido();
            dgvPedidos.DataSource = pedidos;
        }

        private void btnUsuarioPanel_Click(object sender, EventArgs e)
        {
            if (FormPrincipal != null)
            {
                FormPrincipal.AbrirFormsHija(new frmPOS { FormPrincipal = FormPrincipal });
            }
            else if (EmpleadoFormPrincipal != null)
            {
                EmpleadoFormPrincipal.AbrirFormsHijaEmpleado(new frmPOS { EmpleadoFormPrincipal = EmpleadoFormPrincipal });
            }
            else
            {
                MessageBox.Show("Formulario es nulo");
            }
        }
    }
}
