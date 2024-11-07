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
            //public decimal Sub_Total { get; set; }
            //public decimal I_S_V { get; set; }
            //public decimal TOTAL_Pagar { get; set; }
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

        public bool GuardarPedido(PedidoDetalle pedido, BindingList<PlatilloDetalle> platillos)
        {
            using (SqlConnection conn = new SqlConnection(con_string))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryPedido = @"INSERT INTO Pedido (codigoPedido, Fk_Usuario, FechaPedido, total, estado)
                                   VALUES (@CodigoPedido, @CodigoEmpleado, @FechaDelPedido, @TotalDeProductos, @Precio_Total, @ISV, @TotalPagar, @MetodoDePago, @Estado)";
                    
                    SqlCommand cmdPedido = new SqlCommand(queryPedido, conn, transaction);
                    cmdPedido.Parameters.AddWithValue("@CodigoPedido", pedido.CodigoPedido);
                    cmdPedido.Parameters.AddWithValue("@CodigoEmpleado", pedido.CodigoEmpleado);
                    cmdPedido.Parameters.AddWithValue("@FechaDelPedido", pedido.FechaDelPedido);
                    cmdPedido.Parameters.AddWithValue("@TotalDeProductos", pedido.TotalDeProductos);
                    //cmdPedido.Parameters.AddWithValue("@Precio_Total", pedido.Sub_Total);
                    //cmdPedido.Parameters.AddWithValue("@ISV", pedido.I_S_V);
                    //cmdPedido.Parameters.AddWithValue("@TotalPagar", pedido.TOTAL_Pagar);
                    //cmdPedido.Parameters.AddWithValue("@MetodoDePago", pedido.MetodoDePago);
                    cmdPedido.Parameters.AddWithValue("@Estado", pedido.Estado);

                    cmdPedido.ExecuteNonQuery();

                    foreach (var platillo in platillos)
                    {
                        string queryDetalle = @"INSERT INTO DetallesPedido (CodigoPedido, CodigoPlatillo, Cantidad, Precio_Unitario, TotalProducto)
                                        VALUES (@CodigoPedido, @CodigoPlatillo, @Cantidad, @PrecioUnitario, @TotalProducto)";
                        SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conn, transaction);
                        cmdDetalle.Parameters.AddWithValue("@CodigoPedido", pedido.CodigoPedido);
                        cmdDetalle.Parameters.AddWithValue("@CodigoPlatillo", platillo.Codigo);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", platillo.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", platillo.Precio_Unitario);
                        cmdDetalle.Parameters.AddWithValue("@TotalProducto", platillo.TotalProducto);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    Console.WriteLine("Pedido guardado exitosamente.");
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error al guardar el pedido: " + ex.Message);
                    return false;
                }
            }
        }

    }
}
