﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZompyDogsLib.Controladores;

namespace zompyDogs.CRUD.AGREGAR
{
    public partial class ProveedorRegistro : Form
    {
        private ControladorGeneradoresDeCodigo _controladorGeneradorCodigo;

        private string nuevoCodigoProveedor;
        public ProveedorRegistro()
        {
            InitializeComponent();
            _controladorGeneradorCodigo = new ControladorGeneradoresDeCodigo();

            GeneradordeCodigoProveedorFromForm();
        }

        private void GeneradordeCodigoProveedorFromForm()
        {
            nuevoCodigoProveedor = _controladorGeneradorCodigo.GeneradordeCodigoProveedor();
            txtCodigoGenerado.Text = nuevoCodigoProveedor;
        }
    }
}
