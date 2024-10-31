using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZompyDogsLib
{
    public class UsuariosLib
    {
        private int _idCedula;
        private string _nombreUsuario;
        private string _segundoUsuario;
        private string _apellidoUsuario;
        private string _telefono;
        private string _direccion;
        private DateTime _fechaNacimiento;
        private string _estadoCivil;
        private string _username;
        private string _clave;
        private DateTime _fechaRegistro;
        private int _rolId;
        private string _rolUsuario;
        private string _estadoUsuario;

        public int IdCedula { get => _idCedula; set => _idCedula = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string SegundoUsuario { get => _segundoUsuario; set => _segundoUsuario = value; }
        public string ApellidoUsuario { get => _apellidoUsuario; set => _apellidoUsuario = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string EstadoCivil { get => _estadoCivil; set => _estadoCivil = value; }
        public string Username { get => _username; set => _username = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public int RolId { get => _rolId; set => _rolId = value; }
        public string RolUsuario { get => _rolUsuario; set => _rolUsuario = value; }
        public string EstadoUsuario { get => _estadoUsuario; set => _estadoUsuario = value; }


        public UsuariosLib()
        {
            _idCedula = 0;
            _nombreUsuario = "";
            _segundoUsuario="";
            _apellidoUsuario="";
            _telefono="";
            _direccion="";
            _fechaNacimiento = DateTime.MinValue;
            _estadoCivil ="";
            _username="";
            _clave="";
            _fechaRegistro=DateTime.MinValue;
            _rolId= 0;
            _rolUsuario="";
            _estadoUsuario="";
        }

        public UsuariosLib(
            int idCedula,
            string nombreUsuario,
            string segundoUsuario,
            string apellidoUsuario,
            string telefono,
            string direccion,
            DateTime fechaNacimiento,
            string estadoCivil,
            string username,
            string clave,
            DateTime fechaRegistro,
            int rolId,
            string rolUsuario,
            string estadoUsuario
            )
        {
            IdCedula = idCedula;
            NombreUsuario = nombreUsuario;
            SegundoUsuario = segundoUsuario;
            ApellidoUsuario = apellidoUsuario;
            Telefono = telefono;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            Username = username;
            Clave = clave;
            FechaRegistro = fechaRegistro;
            RolId = rolId;
            RolUsuario = rolUsuario;
            EstadoUsuario = estadoUsuario;
        }



    }
}
