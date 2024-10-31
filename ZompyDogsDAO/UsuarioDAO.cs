using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ZompyDogsDAO
{
    public class UsuarioDAO
    {
        public static readonly string con_string = "Data Source=MACARENA\\SQLEXPRESS;Initial Catalog=DB_ZompyDogs;Integrated Security=True;Encrypt=False";
        public static SqlConnection conn = new SqlConnection(con_string);

        public static int ObtenerIDPorNombreUsuario(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                throw new ArgumentException("El nombre de usuario no puede ser nulo o estar vacío.", nombreUsuario);
            }

            int idUsuario = 0;

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                string query = "SELECT IDUsuario FROM v_DetallesUsuarios WHERE Usuario = @NombreUsuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    idUsuario = Convert.ToInt32(result);
                }
            }
            return idUsuario;
        }
        public static string ObtenerNombreUsuarioPorID(int idUsuario)
        {
            string nombreUsuario = null;

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                string query = "SELECT Usuario FROM v_PeticionesxUsuarios WHERE IDUsuario = @IDUsuario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDUsuario", idUsuario);

                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    nombreUsuario = result.ToString();
                }
                
            }

            return nombreUsuario;
        }

        public static bool ActualizarClaveUsuario(string nombreUsuario, string nuevaClave)
        {
            string queryUsername = "SELECT id_usuario FROM Usuario WHERE username = @nombreUsuario";
            string queryUpdatePassword = "UPDATE Usuario SET password = @nuevaClave WHERE username = @nombreUsuario";
            string queryUpdateEstadoPeticion = "UPDATE Peticiones SET estado = 'Completado' WHERE codigoUsuario = @idUser";

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Obtener el id_usuario
                        SqlCommand cmdQU = new SqlCommand(queryUsername, conn, transaction);
                        cmdQU.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        int idUser = (int)cmdQU.ExecuteScalar();

                        // Actualizar la contraseña
                        SqlCommand cmdUpdatePassword = new SqlCommand(queryUpdatePassword, conn, transaction);
                        cmdUpdatePassword.Parameters.AddWithValue("@nuevaClave", nuevaClave);
                        cmdUpdatePassword.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        int filasAfectadasPassword = cmdUpdatePassword.ExecuteNonQuery();

                        // Actualizar el estado de la petición
                        SqlCommand cmdUpdateEstadoPeticion = new SqlCommand(queryUpdateEstadoPeticion, conn, transaction);
                        cmdUpdateEstadoPeticion.Parameters.AddWithValue("@idUser", idUser);

                        int filasAfectadasPeticion = cmdUpdateEstadoPeticion.ExecuteNonQuery();

                        // Comprobar si ambas actualizaciones tuvieron éxito
                        if (filasAfectadasPassword > 0 && filasAfectadasPeticion > 0)
                        {
                            transaction.Commit();
                            return true;
                        }
                        else
                        {
                            transaction.Rollback();
                            Console.WriteLine("No se actualizaron filas en Usuario o Peticiones.");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error al actualizar la clave del usuario: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public static DataTable ObtenerDetalllesDeUsuarios()
        {
            DataTable dtpDetallesUsuarios = new DataTable();
            string query = "SELECT Codigo, Nombre_Completo, Usuario, Telefono, Puesto, Salario, RolUsuario, Estado FROM v_DetallesUsuarios";

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

        public static DataTable ObtenerDetalllesDeUsuariosEmpleados()
        {
            DataTable dtpDetallesUsuarios = new DataTable();
            string query = "SELECT Codigo, Nombre_Completo, Usuario, Telefono, Puesto, Salario, RolUsuario, Estado FROM v_DetallesUsuarios WHERE RolID = 2";

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

        public static DataTable ObtenerDetalllesDeUsuariosAdmin()
        {
            DataTable dtpDetallesUsuarios = new DataTable();
            string query = "SELECT Codigo, Nombre_Completo, Usuario, Telefono, Puesto, Salario, RolUsuario, Estado FROM v_DetallesUsuarios WHERE RolID = 1";

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

        public static DataTable ObtenerDetalllesProveedores()
        {
            DataTable dtpDetallesUsuarios = new DataTable();
            string query = "SELECT * FROM Proveedor";

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



    }
}
