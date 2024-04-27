using Business;
using Business.Marca;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_GRUPO_F_1
{
    public partial class frmModificarCategoria : Form
    {
        private CategoriaEntity catego = null;
        public frmModificarCategoria(CategoriaEntity catego)
        {
            this.catego = catego;
            InitializeComponent();
        }
        private void btnCancelarModificar_Click(object sender, EventArgs e)
        {
            Close();
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

            CategoriaEntity catego = new CategoriaEntity();
            catego.Descripcion = txtModificar.Text;
            catego.Id = this.catego.Id;

            CategoriaBusiness categoBusiness = new CategoriaBusiness();
            try
            {
                if (categoBusiness.ModificarCategoria(catego) > 0)
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

        private void frmModificarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
