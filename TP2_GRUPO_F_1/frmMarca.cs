using Business;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TP2_GRUPO_F_1
{
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private List<MarcaEntity> listMarca;

        private void cargar()
        {
            MarcaBusiness negocio = new MarcaBusiness();
            try
            {
                listMarca = negocio.GetMarcas();
                dgvMarca.DataSource = listMarca;
                dgvMarca.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            var listMarcas = new List<MarcaEntity>();
            var marcaNegocio = new MarcaBusiness();
            listMarcas = marcaNegocio.GetMarcas();
            dgvMarca.DataSource = listMarcas;
        }

        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            MarcaEntity seleccionada; 
            seleccionada = (MarcaEntity)dgvMarca.CurrentRow.DataBoundItem;

            var ventana = new frmModificarMarca(seleccionada);
            ventana.ShowDialog();
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var ventana = new frmAgregarMarca();
            ventana.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respuesta == DialogResult.Yes)
            {
                MarcaEntity seleccionada;
                seleccionada = (MarcaEntity)dgvMarca.CurrentRow.DataBoundItem;

                var marcaBusiness = new MarcaBusiness();
                try
                {
                    if (marcaBusiness.Corrobar(seleccionada.Id) > 0)
                    {
                        MessageBox.Show("Está Marca tiene un registro en Articulo.");
                        return;
                    }
                    if (marcaBusiness.EliminarMarca(seleccionada.Id) > 0)
                    {
                        MessageBox.Show("Se elimino con éxito.");
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
