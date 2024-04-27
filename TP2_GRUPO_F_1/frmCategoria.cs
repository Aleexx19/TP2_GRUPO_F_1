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
        private List<CategoriaEntity> listCategoria;
        private void cargar()
        {
            CategoriaBusiness negocio = new CategoriaBusiness();
            try
            {
                listCategoria = negocio.GetCategorias();
                dgvCategoria.DataSource = listCategoria;
                dgvCategoria.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmCategoria_Load(object sender, EventArgs e)
        {
           var listCategoria = new List<CategoriaEntity>();
            var categoriaNegocio = new CategoriaBusiness();
            listCategoria = categoriaNegocio.GetCategorias();
            dgvCategoria.DataSource = listCategoria;
           
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CategoriaEntity seleccionada; 
            seleccionada = (CategoriaEntity)dgvCategoria.CurrentRow.DataBoundItem;

            var ventana = new frmModificarCategoria(seleccionada);
            ventana.ShowDialog();
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var ventana = new frmAgregarCategoria();
            ventana.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea Eliminar este registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                CategoriaEntity seleccionada;
                seleccionada = (CategoriaEntity)dgvCategoria.CurrentRow.DataBoundItem;

                var categoBusiness = new CategoriaBusiness();
                try
                {
                    if (categoBusiness.EliminarCategoria(seleccionada.Id) > 0)
                    {
                        MessageBox.Show("Se Elimino con éxito.");
                        cargar();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al eliminar " + ex.Message);
                }
            }
        }
    }
}
