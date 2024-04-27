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
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("El input no puede quedar vacío");
                return;
            }

            CategoriaEntity cate = new CategoriaEntity();
            cate.Descripcion = txtDescripcion.Text;

            CategoriaBusiness cateBusiness = new CategoriaBusiness();
            try
            {
                if (cateBusiness.AgregarCategoria(cate) > 0)
                {
                    MessageBox.Show("Se agregó una Categoria con éxito.");
                }
                else
                {
                    MessageBox.Show("Hubo un problema al insertar.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al insertar " + ex.Message);
            }

        }
    }
    }

