﻿using System;
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
                string query = "SELECT * FROM v_DetallesPedidosConPlatillo ORDER BY Fecha_Del_Pedido DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dtProductos = new DataTable();
                da.Fill(dtProductos);
                return dtProductos;
            }
        }

       
        public class RegistroPedidos
        {
            public string CodigoPedido { get; set; }
            public int CodigoEmpleado { get; set; }
            public string EmpleadoNombre { get; set; }
            public DateTime FechaDelPedido { get; set; }
            public string Estado { get; set; }
        }
        public static DataTable BuscarPeticionesPorID(int valorBusqueda)
        {
            string query = "SELECT  * FROM v_DetallesPedidosConPlatillo WHERE Num_Factura = @valorBusqueda;";

            using (SqlConnection connection = new SqlConnection(con_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@valorBusqueda", valorBusqueda);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable resultados = new DataTable();
                    adapter.Fill(resultados);
                    return resultados;
                }
            }
        }

        public class DetalleDePedido
        {
            public int id_Menu { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio_Unitario { get; set; }
            public int id_Pedido { get; set; }
            public string PlatilloNombre { get; set; }
            public string Descripcion { get; set; }
            public int Categoria { get; set; }
            public string ImagenPlatillo { get; set; }
            public decimal SubTotal { get; set; }
        }

        public BindingList<DetalleDePedido> platillosLista = new BindingList<DetalleDePedido>();


        /************************ FACTURAS ******************* */

        public static DataTable ObtenerDetalllesPedidos_DGV()
        {
            DataTable dtpDetallesUsuarios = new DataTable();
            string query = "SELECT Codigo_Pedido, Empleado, Total_De_Productos, Precio_Unitario_Promedio, Subtotal, ISV, Total_a_Pagar, Fecha_Del_Pedido FROM v_DetallesPedidosPorEmpleado";

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                try
                {
                    conn.Open();
                    da.Fill(dtpDetallesUsuarios);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener las descripciones de usuarios: " + ex.Message);
                }
            }

            return dtpDetallesUsuarios;
        }

        public static DataTable ObtenerDetalllesDeFacturaPorEmpleado(string codigoEmpleado)
        {
            DataTable dtpDetallesUsuarios = new DataTable();
            string query = "SELECT * FROM v_DetallesPedidosConPlatillo WHERE Codigo_Empleado = @codigoEmpleado";

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigoEmpleado", codigoEmpleado);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                try
                {
                    conn.Open();
                    da.Fill(dtpDetallesUsuarios);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener las descripciones de pedidos: " + ex.Message);
                }
            }

            return dtpDetallesUsuarios;
        }


    }
}
