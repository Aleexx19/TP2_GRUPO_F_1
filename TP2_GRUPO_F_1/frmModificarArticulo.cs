using Business;
using Business.Articulo;
using Business.Marca;
using Domain.Entities;
using System;
using System.Windows.Forms;

namespace TP2_GRUPO_F_1
{
    public partial class frmModificarArticulo : Form
    {

        private ArticuloEntity artic = null;
        private int idCat = 0, idMarca = 0, idArt=0;
        public frmModificarArticulo(ArticuloEntity artic)
        {
            this.artic = artic;
            idCat = this.artic.Categoria.Id;
            idMarca = this.artic.Marca.Id;
            idArt = this.artic.Id;
            InitializeComponent();
        }
        private void frmModificarArticulo_Load(object sender, EventArgs e)

        {
            MarcaBusiness marcaBusiness = new MarcaBusiness();
            CategoriaBusiness categoriaBusiness = new CategoriaBusiness();

            cboMarca.DataSource = marcaBusiness.GetMarcas();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
            cboCategoria.DataSource = categoriaBusiness.GetCategorias();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";

            ///
            txtNombre.Text = artic.Nombre;
            txtDescricpion.Text = artic.Descripcion;
            txtPrecio.Text = artic.Precio.ToString();
            txtCodigo.Text = artic.CodArticulo;
            txtUrlImagen.Text = artic.Imagen.UrlImagen;
            cboCategoria.SelectedValue = idCat;
            cboMarca.SelectedValue = idMarca;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre del artículo no puede quedar vacío.");
                return;
            }

            
            if (txtNombre.Text.Length > 50)
            {
                MessageBox.Show("El nombre del artículo no puede exceder los 50 caracteres.");
                return;
            }

            // Crear una nueva instancia de ArticuloEntity con los datos del formulario
            ArticuloEntity nuevoArticulo = new ArticuloEntity();
            nuevoArticulo.Imagen = new ImagenEntity();
            nuevoArticulo.Marca = new MarcaEntity();
            nuevoArticulo.Categoria = new CategoriaEntity();
            nuevoArticulo.Id = idArt;
            nuevoArticulo.Nombre = txtNombre.Text;
            nuevoArticulo.Descripcion = txtDescricpion.Text;
            nuevoArticulo.Precio = Convert.ToDecimal(txtPrecio.Text);
            nuevoArticulo.CodArticulo = txtCodigo.Text;
            nuevoArticulo.Imagen.UrlImagen = txtUrlImagen.Text;
            // Asignar los valores de categoría y marca seleccionados
            nuevoArticulo.Categoria = (CategoriaEntity)cboCategoria.SelectedItem;
            nuevoArticulo.Marca = (MarcaEntity)cboMarca.SelectedItem;

            // Instancia la clase de negocios para modificar el artículo
            ArticuloBussines articuloBusiness = new ArticuloBussines();
            try
            {
                // Llama al método de la capa de negocios para modificar el artículo
                if (articuloBusiness.ModificarArticulo(nuevoArticulo) > 0)
                {
                    MessageBox.Show("Se modificó el artículo con éxito.");
                    // Cerrar el formulario después de la modificación exitosa
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al modificar el artículo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el artículo: " + ex.Message);
            }

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriaEntity categoriaSeleccionada = (CategoriaEntity)cboCategoria.SelectedItem;

            
            artic.Categoria = categoriaSeleccionada;
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarcaEntity marcaSeleccionada = (MarcaEntity)cboMarca.SelectedItem;

            
            artic.Marca = marcaSeleccionada;
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            string urlImagen = txtUrlImagen.Text;

            
            artic.Imagen.UrlImagen = urlImagen;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                // Asignar el precio al artículo actual
                artic.Precio = precio;
            }
            else
            {
                txtPrecio.Clear();
            }
        }

        private void txtDescricpion_TextChanged(object sender, EventArgs e)
        {
            string descripcion = txtDescricpion.Text;

            
            artic.Descripcion = descripcion;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            
            artic.Nombre = nombre;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

           
            artic.CodArticulo = codigo;
        }
    }
}