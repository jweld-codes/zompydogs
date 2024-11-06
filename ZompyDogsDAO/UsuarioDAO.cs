using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static ZompyDogsDAO.UsuarioDAO;

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

        public static DataTable ObtenerDetalllesDeUsuariosParaEditar(string codigoUsuario)
        {
            DataTable dtpDetallesUsuarios = new DataTable();
            string query = "SELECT * FROM v_DetallesUsuarios WHERE Codigo = @codigoUsuario";

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario);

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

        public static DataTable BuscadorDeUsuarios(string valorBusqueda)
        {
            string query = "SELECT Codigo, Nombre_Completo, Usuario, RolUsuario FROM v_DetallesUsuarios WHERE Usuario LIKE @valorBusqueda OR Nombre_Completo LIKE @valorBusqueda OR Codigo LIKE @valorBusqueda";

            using (SqlConnection connection = new SqlConnection(con_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@valorBusqueda", "%" + valorBusqueda + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable resultados = new DataTable();
                    adapter.Fill(resultados);
                    return resultados;
                }
            }
        }
        public static DataTable FiltroDeUsuarios(string estadoDT)
        {
            DataTable dtFiltro = new DataTable();
            string query = "SELECT Codigo, Nombre_Completo, Usuario, Telefono, Puesto, Salario, RolUsuario, Estado FROM v_DetallesUsuarios WHERE estado = @estadoDT";

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estadoDT", estadoDT);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                try
                {
                    conn.Open();
                    da.Fill(dtFiltro);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener las descripciones de usuarios: " + ex.Message);
                }
            }

            return dtFiltro;
        }
        public class DetalleUsuario
        {
            public string primerNombre { get; set; }
            public string segundoNombre { get; set; }
            public string primerApellido { get; set; }
            public string segundoApellido { get; set; }
            public string codigoCedula { get; set; }
            public DateTime fechaNacimiento { get; set; }
            public string estadoCivil { get; set; }
            public string telefono { get; set; }
            public string direccion { get; set; }
            public int codigoPuesto { get; set; }
            public string codigoUsuario { get; set; }
        }

        public class UsuarioRegistro
        {
            public string UserName { get; set; }
            public string PassWord { get; set; }
            public DateTime FechaRegistro { get; set; }
            public int CodigoRol { get; set; }

            public int CodigoDetalleUsuario { get; set; } 

            public string Estado { get; set; }
        }

        public static int ObtenerSiguienteID()
        {
            int siguienteID = 1;
            try
            {
                using (SqlConnection conn = new SqlConnection(con_string))
                {
                    conn.Open();
                    string query = "SELECT MAX(Id_DetalleUsuario) FROM DetalleUsuario";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        var resultado = cmd.ExecuteScalar();
                        if (resultado != DBNull.Value)
                        {
                            siguienteID = Convert.ToInt32(resultado) + 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el siguiente ID: " + ex.Message);
            }
            return siguienteID;
        }

        public static void GuardarDetalleUsuario(DetalleUsuario detalleusuario)
        {
            string query = "INSERT INTO Usuario (primNombreUsuario, segNombreUsuario, primApellidoUsuario, segApellido, codigoCedula, fechaNacimiento, estadoCivil, telefono, direccion, codigoPuesto, codigoUsuario) VALUES (@primern, @segundon, @primera, @segundoa, @codice, @fechanac, @civil, @tele, @direcc, @codpu, @codius)";

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@primern", detalleusuario.primerNombre);
                    cmd.Parameters.AddWithValue("@segundon", detalleusuario.segundoNombre);
                    cmd.Parameters.AddWithValue("@primera", detalleusuario.primerApellido);
                    cmd.Parameters.AddWithValue("@segundoa", detalleusuario.segundoApellido);
                    cmd.Parameters.AddWithValue("@codice", detalleusuario.codigoCedula);
                    cmd.Parameters.AddWithValue("@fechanac", detalleusuario.fechaNacimiento);
                    cmd.Parameters.AddWithValue("@civil", detalleusuario.estadoCivil);
                    cmd.Parameters.AddWithValue("@tele", detalleusuario.telefono);
                    cmd.Parameters.AddWithValue("@direcc", detalleusuario.direccion);
                    cmd.Parameters.AddWithValue("@codpu", Convert.ToInt32(detalleusuario.codigoPuesto));
                    cmd.Parameters.AddWithValue("@codius", detalleusuario.codigoUsuario);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No se insertó ningún registro en la base de datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al guardar el usuario: " + ex.Message);
                    }
                }
            }
        }

       public static void GuardarUsuario(UsuarioRegistro userAdd)
        {
            string query = "INSERT INTO Usuario (username, password, fechaRegistro, codigoRol, codigoDetalleUsuario, estado) VALUES (@nameuser, @claveuser, @fechareg, @codiRol, @codiDetalle, @estado)";

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@nameuser", userAdd.UserName);
                    cmd.Parameters.AddWithValue("@claveuser", userAdd.PassWord);
                    cmd.Parameters.AddWithValue("@fechareg", userAdd.FechaRegistro);
                    cmd.Parameters.AddWithValue("@codiRol", Convert.ToInt32(userAdd.CodigoRol));
                    cmd.Parameters.AddWithValue("@codiDetalle", Convert.ToInt32(userAdd.CodigoDetalleUsuario));
                    cmd.Parameters.AddWithValue("@estado", userAdd.Estado);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No se insertó ningún registro en la base de datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al guardar el usuario: " + ex.Message);
                    }
                }
            }
        }

        public static bool EliminarUsuario(string codigoUsuario)
        {
            string query = "DELETE FROM DetalleUsuario WHERE codigoUsuario = @codigoUsuario";

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario);

                try
                {
                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar la petición: " + ex.Message);
                    return false;
                }
            }
        }

        public static DataTable ObtenerPuestosParaComboBox()
        {
            DataTable dtPuestos = new DataTable();
            using (SqlConnection conn = new SqlConnection(con_string))
            {
                conn.Open();
                string query = "SELECT IdPuesto, puesto FROM Puestos";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtPuestos);
                }
            }
            return dtPuestos;
        }
        public static DataTable ObtenerRolesParaComboBox()
        {
            DataTable dtRoles = new DataTable();
            using (SqlConnection conn = new SqlConnection(con_string))
            {
                conn.Open();
                string query = "SELECT Id_Rol, Rol FROM Rol";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtRoles);
                }
            }
            return dtRoles;
        }

        public static bool ActualizarDetalleUsuario(DetalleUsuario detalleUsuario)
        {
            string query = "UPDATE DetalleUsuario SET primNombreUsuario = @primNombreUsuario,segNombreUsuario = @segNombreUsuario, primApellidoUsuario = @primApellidoUsuario, segApellido = @segApellido, codigoCedula = @codigoCedula, fechaNacimiento = @fechaNacimiento, estadoCivil = @estadoCivil, telefono = @telefono, direccion = @direccion WHERE codigoUsuario = @codigoUsuario";

            using (SqlConnection conn = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@primNombreUsuario", detalleUsuario.primerNombre);
                cmd.Parameters.AddWithValue("@segNombreUsuario", detalleUsuario.segundoNombre);
                cmd.Parameters.AddWithValue("@primApellidoUsuario", detalleUsuario.primerApellido);
                cmd.Parameters.AddWithValue("@segApellido", detalleUsuario.segundoApellido);
                cmd.Parameters.AddWithValue("@codigoCedula", detalleUsuario.codigoCedula);
                cmd.Parameters.AddWithValue("@fechaNacimiento", detalleUsuario.fechaNacimiento);
                cmd.Parameters.AddWithValue("@estadoCivil", detalleUsuario.estadoCivil);
                cmd.Parameters.AddWithValue("@telefono", detalleUsuario.telefono);
                cmd.Parameters.AddWithValue("@direccion", detalleUsuario.direccion);
                cmd.Parameters.AddWithValue("@codigoPuesto", detalleUsuario.codigoPuesto);
                cmd.Parameters.AddWithValue("@codigoUsuario", detalleUsuario.codigoUsuario);

                try
                {
                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar el usuario: " + ex.Message);
                    Console.WriteLine("Detalles de la excepción: " + ex.ToString());
                    return false;
                }
            }
        }


    }
}
