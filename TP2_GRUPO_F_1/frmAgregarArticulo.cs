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

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ArticuloEntity arti = new ArticuloEntity();
            ArticuloBussines bussines = new ArticuloBussines();

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("El Precio no puede quedar vacio.");
                return;
            }

            if (!soloNumeros(txtPrecio.Text))
            {
                MessageBox.Show("El Precio solo debe contener numeros.");
                return;
            }

            decimal precio = decimal.Parse(txtPrecio.Text);

            if (precio <= 0)
            {
                MessageBox.Show("El Precio no puede ser menor o igual a  0.");
                return;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text) || txtCodigo.Text.Length > 50)
            {
                MessageBox.Show("El Codigo no puede quedar vacio o excederce de 50 caracteres.");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text) || txtNombre.Text.Length > 50)
            {
                MessageBox.Show("El Nombre no puede quedar vacio o excederce de 50 caracteres.");
                return;
            }

            if (string.IsNullOrEmpty(txtDescricpion.Text) || txtDescricpion.Text.Length > 150)
            {
                MessageBox.Show("La Descripcion no puede quedar vacia o excederce de 150 caracteres.");
                return;
            }

            if (txtUrlImagen.Text.Length > 1000)
            {
                MessageBox.Show("La url no puede superar los 1000 caracteres.");
                return;
            }

            try 
            { 
                arti.CodArticulo = txtCodigo.Text;
                arti.Nombre = txtNombre.Text;
                arti.Descripcion = txtDescricpion.Text;
                arti.Precio = precio;
                arti.Marca = new MarcaEntity();
                arti.Categoria = new CategoriaEntity();
                arti.Imagen = new ImagenEntity();
                arti.Imagen.UrlImagen = txtUrlImagen.Text;
                arti.Marca = (MarcaEntity)cboMarca.SelectedItem;
                arti.Categoria = (CategoriaEntity)cboCategoria.SelectedItem;

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
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = cat.GetCategorias(); //Idem
                cboCategoria.DisplayMember = "Descripcion";
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
