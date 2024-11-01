using System.Data;
using System.Data.SqlClient;
namespace ZompyDogsDAO
{
    public class UsuarioValidaciones
    {
        public static readonly string con_string = "Data Source=DESKTOP-8B6OMJK;Initial Catalog=DB_ZompyDogs;Integrated Security=True;Encrypt=False;";
        public static SqlConnection conn = new SqlConnection(con_string);

        // Metodo para validar el usuario y obtener sus datos
        public static (
            bool isValid, 
            bool isAdmin,
            string nombreUser,
            string apeUser,
            string username,
            int idEmpleado
            ) IsValidUser(string user, string password)
        {
            bool isValid = false;
            bool isAdmin = false;
            string nombreUser = string.Empty;
            string apeUser = string.Empty;
            string username = string.Empty;
            int idEmpleado = 0;

            try
            {
                conn.Open();

                // Consulta para validar al usuario
                string query = @"
                    SELECT Nombre_Usuario, Apellido_Usuario,Usuario,IDUsuario, RolId 
                    FROM v_DetallesUsuarios
                    WHERE Usuario = @user AND Clave = @password
                ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    isValid = true;
                    while (reader.Read())
                    {
                        nombreUser = reader["Nombre_Usuario"].ToString();
                        apeUser = reader["Apellido_Usuario"].ToString();
                        username = reader["Usuario"].ToString();
                        idEmpleado = reader.GetInt32(reader.GetOrdinal("IDUsuario"));

                        if (reader["RolId"] != DBNull.Value && Convert.ToInt32(reader["RolId"]) == 1)
                        {
                            isAdmin = true;
                        }
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Manejo de excepción
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return (isValid, isAdmin, nombreUser, apeUser, username, idEmpleado);
        }

            public static (bool existeUsuario, string nombreUsuario, string rolUsuario) 
            ObtenerUsuarioParaPeticionRegistro(int idUsuario)
            {
            bool existeUsuario = false;
            string nombreUsuario = string.Empty;
            string rolUsuario = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(con_string))
                {
                    conn.Open();

                    // Consulta para obtener los detalles del usuario por su ID
                    string query = @"
                        SELECT Usuario, RolId 
                        FROM v_DetallesUsuarios 
                        WHERE IDUsuario = @idUsuario
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            existeUsuario = true;
                            while (reader.Read())
                            {
                                // Realiza la conversión directamente sobre el reader
                                try
                                {
                                    idUsuario = reader["IDUsuario"] != DBNull.Value ? Convert.ToInt32(reader["IDUsuario"]) : 5;
                                }
                                catch (FormatException ex)
                                {
                                    // Manejar el error de formato
                                    Console.WriteLine($"Error de formato al convertir IDUsuario: {ex.Message}");
                                }
                                catch (Exception ex)
                                {
                                    // Manejar cualquier otro error
                                    Console.WriteLine($"Error inesperado: {ex.Message}");
                                }
                                nombreUsuario = reader["Usuario"].ToString();
                                rolUsuario = reader["RolId"] != DBNull.Value ? reader["RolId"].ToString() : "No asignado";
                            }
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al obtener usuario para petición registro: " + ex.Message);
            }

            return (existeUsuario, nombreUsuario, rolUsuario);
        }

    }
}
