using Business;
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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
           var listCategoria = new List<CategoriaEntity>();
            var categoriaNegocio = new CategoriaBusiness();
            listCategoria = categoriaNegocio.GetCategorias();
            dgvCategoria.DataSource = listCategoria;
           
          /* ArticuloBussines articulo = new ArticuloBussines();
            dgvCategoria.DataSource = articulo.GetArticulo();
          */

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
