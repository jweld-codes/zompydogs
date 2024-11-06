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
using ZompyDogsLib.Controladores;

namespace zompyDogs.CRUD.REGISTROS
{
    public partial class PuestosRegistro : Form
    {
        private string nuevoCodigoPuesto;
        private ControladorGeneradoresDeCodigo _controladorGeneradorCodigo;
        public PuestosRegistro()
        {
            InitializeComponent();

            CargarPuestos();
           // GeneradordeCodigoPuestoFromForm();

            _controladorGeneradorCodigo = new ControladorGeneradoresDeCodigo();
        }

        private void CargarPuestos()
        {
            DataTable puestos = UsuarioDAO.ObtenerDetalllesPuestos();
            dgvPuestos.DataSource = puestos;
        }

     
      /* private void GeneradordeCodigoPuestoFromForm()
        {
            nuevoCodigoPuesto = _controladorGeneradorCodigo.GeneradordeCodigoPuesto();
            txtCodigoGenerado.Text = nuevoCodigoPuesto;
        }*/





    }
}
