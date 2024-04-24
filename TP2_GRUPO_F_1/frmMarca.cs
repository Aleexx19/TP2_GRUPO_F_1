using Business;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP2_GRUPO_F_1
{
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            var listMarcas = new List<MarcaEntity>();
            var marcaNegocio = new MarcaBusiness();
            listMarcas = marcaNegocio.GetMarcas();
            dgvMarca.DataSource = listMarcas;
        }
    }
}
