﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZompyDogsDAO;

namespace zompyDogs
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            CargarAuditoriasCompletas();
        }

        public void CargarAuditoriasCompletas()
        {
            DataTable auditorias = AuditoriaDAO.ObtenerAuditorias();
            dgvActividadesAuditoria.DataSource = auditorias;
        }
    }
}
