using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zompyDogs
{
    public partial class AjustesCuenta : Form
    {
        public AjustesCuenta()
        {
            InitializeComponent();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioRegistro addNuevoRegistro = new UsuarioRegistro();
            addNuevoRegistro.lblTituloRegistro.Text = "Editar Cuenta";
            addNuevoRegistro.btnGuardarUser.Text = "EDITAR";
            addNuevoRegistro.Show();
        }
    }
}
