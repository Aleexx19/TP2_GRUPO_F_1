using Business.Articulo;
using Business.Marca;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_GRUPO_F_1
{
    public partial class FrmArticulo : Form
    {
        public FrmArticulo()
        {
            InitializeComponent();
        }
        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            var listArticulo = new List<ArticuloEntity>();
            var ArticuloNegocio = new ArticuloBussines();
            listArticulo = ArticuloNegocio.GetArticulo();
            dgvArticulo.DataSource = listArticulo;

        }

            private void dgvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*  ArticuloBussines articulo = new ArticuloBussines();
              dgvArticulo.DataSource = listArticulos
            
            var listArticulo = new List<ArticuloEntity>();
            var ArticuloNegocio = new ArticuloBussines();
            listArticulo = ArticuloNegocio.GetArticulo();
            dgvArticulo.DataSource = listArticulo;

                */
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregar = new frmAgregarArticulo();
            agregar.ShowDialog();
        }
    }
}
