using Azure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZompyDogsLib.Controladores;

namespace zompyDogs
{
    public partial class UsuarioRegistro : Form
    {
        private ControladorGeneradoresDeCodigo _controladorGeneradorCodigo;

        private string nuevoCodigoUsuario;
        private bool isTheUsername = false;

        public UsuarioRegistro()
        {
            InitializeComponent();

            _controladorGeneradorCodigo = new ControladorGeneradoresDeCodigo();

            GeneradordeCodigoUsuarioFromForm();
        }

        private void GeneradordeCodigoUsuarioFromForm()
        {
            nuevoCodigoUsuario = _controladorGeneradorCodigo.GeneradordeCodigoUsuario();
            txtCodigoGenerado.Text = nuevoCodigoUsuario;
        }

        private void btnGeneradorUsername_Click(object sender, EventArgs e)
        {
            isTheUsername = true;
            GeneradordeNombreDeUsuarioYClave();
        }

        public string GeneradordeNombreDeUsuarioYClave()
        {
            string nombreUser = txtPrimNombre.Text;
            string apellUser = txtPrimApellido.Text;
            string username = nombreUser + "." + apellUser;

            string numeroAleatorio = new Random().Next(1000, 9999).ToString();
            string codigoGeneradoUsername = $"{username}-{numeroAleatorio}";
            string codigoGeneradoPassword = $"{nombreUser}-{numeroAleatorio}";

            if (isTheUsername == true)
            {
                txtUsername.Text = codigoGeneradoUsername;
                return codigoGeneradoUsername;
            }
            else
            {
                txtPassword.Text = codigoGeneradoPassword;
                return codigoGeneradoPassword;
            }
        }

        private void btnGeneradorPassword_Click(object sender, EventArgs e)
        {
            isTheUsername = false;
            GeneradordeNombreDeUsuarioYClave();
        }
    }
}
