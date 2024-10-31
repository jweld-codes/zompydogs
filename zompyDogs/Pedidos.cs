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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            CargarPedidos();
        }

        private void CargarPedidos()
        {
            DataTable pedidos = PedidosDAO.ObtenerDetallesdePedido();
            dgvPedidos.DataSource = pedidos;
        }
    }
}
