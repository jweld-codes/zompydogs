using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ZompyDogsDAO
{
    public class PedidosDAO
    {
        private static readonly string con_string = "Data Source=MACARENA\\SQLEXPRESS;Initial Catalog=DB_ZompyDogs;Integrated Security=True;Encrypt=False";
        public static DataTable ObtenerDetallesdePedido()
        {
            using (SqlConnection conn = new SqlConnection(con_string))
            {
                string query = "SELECT * FROM v_DetallesPedidos ORDER BY Fecha_Del_Pedido DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dtProductos = new DataTable();
                da.Fill(dtProductos);
                return dtProductos;
            }
        }

        public class PedidoDetalle
        {
            public string CodigoPedido { get; set; }
            public string CodigoEmpleado { get; set; }
            public string EmpleadoNombre { get; set; }
            public DateTime FechaDelPedido { get; set; }
            public int TotalDeProductos { get; set; }
            public decimal Precio_Unitario { get; set; }
            public decimal Sub_Total { get; set; }
            public decimal I_S_V { get; set; }
            public decimal TOTAL_Pagar { get; set; }
            public string MetodoDePago { get; set; }
            public string Estado { get; set; }
        }

        public class PlatilloDetalle
        {
            public string Codigo { get; set; }
            public string PlatilloNombre { get; set; }
            public string Descripcion { get; set; }
            public int Categoria { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio_Unitario { get; set; }
            public string ImagenPlatillo { get; set; }
            public decimal TotalProducto { get; set; }
        }

        public BindingList<PlatilloDetalle> platillosLista = new BindingList<PlatilloDetalle>();

    }
}
