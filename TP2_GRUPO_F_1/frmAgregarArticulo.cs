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
using Domain;
using Business;
using Business.Articulo;
using Business.Marca;



namespace TP2_GRUPO_F_1
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            ArticuloEntity arti = new ArticuloEntity();
            ArticuloBussines bussines = new ArticuloBussines();

            try 
            { 
                arti.CodArticulo = txtCodigo.Text;
                arti.nombre = txtNombre.Text;
                arti.descripcion = txtDescricpion.Text;
                arti.precio = decimal.Parse(txtPrecio.Text);

                bussines.agregarArticulo(arti);
                MessageBox.Show("Agregado de manera exitosa.");
                Close();
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }
        //  Desarrollando ahora, 26/4 20hs
        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            
            CategoriaBusiness cat = new CategoriaBusiness();
            MarcaBusiness marc = new MarcaBusiness();
            
            try
            {
                cboMarca.DataSource = marc.GetMarcas();//Arreglar para que salgan las opciones
                cboCategoria.DataSource = cat.GetCategorias(); //Idem
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
