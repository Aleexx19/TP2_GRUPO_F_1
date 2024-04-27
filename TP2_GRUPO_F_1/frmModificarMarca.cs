using Business;
using Domain.Entities;
using System;
using System.Windows.Forms;

namespace TP2_GRUPO_F_1
{
    public partial class frmModificarMarca : Form
    {
        private MarcaEntity marca = null;

        public frmModificarMarca(MarcaEntity marca)
        {
            this.marca = marca;
            InitializeComponent();
        }

        private void btnAceptarModificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtModificar.Text))
            {
                MessageBox.Show("El input no puede quedar vacío");
                return; 
            }

            if (txtModificar.Text.Length > 50)
            {
                MessageBox.Show("No puede excederse de 50 caracteres");
                return;
            }

            MarcaEntity marca = new MarcaEntity();
            marca.Descripcion = txtModificar.Text;
            marca.Id = this.marca.Id;

            MarcaBusiness marcaBusiness = new MarcaBusiness();
            try
            {
                if (marcaBusiness.ModificarMarca(marca) > 0)
                {
                    MessageBox.Show("Se modifico con éxito.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al modificar.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al modificar " + ex.Message);
            }
        }

        private void btnCancelarModificar_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
