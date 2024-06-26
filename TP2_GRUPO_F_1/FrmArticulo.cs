﻿using Business.Articulo;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace TP2_GRUPO_F_1
{
    public partial class FrmArticulo : Form
    {
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private List<ArticuloEntity> listArticulo;

        
        
        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            var listArticulo = new List<ArticuloEntity>();
            var ArticuloNegocio = new ArticuloBussines();
            listArticulo = ArticuloNegocio.GetArticulo();
            dgvArticulo.DataSource = listArticulo;
            ocultarColumnas();
            cargarImagen(listArticulo[0].Imagen.UrlImagen);
        }

        private void ocultarColumnas()
        {
            dgvArticulo.Columns["Imagen"].Visible = false;
            dgvArticulo.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagenArticulo.Load("https://img.freepik.com/vector-gratis/ilustracion-icono-galeria_53876-27002.jpg?size=626&ext=jpg&ga=GA1.1.1687694167.1713916800&semt=ais");
            }
        }

        private void cargar()
        {
            var negocio = new ArticuloBussines();
            try
            {
                listArticulo = negocio.GetArticulo();
                dgvArticulo.DataSource = listArticulo;
                dgvArticulo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregar = new frmAgregarArticulo();
            agregar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ArticuloBussines negocio = new ArticuloBussines();
            ArticuloEntity seleccion;

            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                try
                {

                    seleccion = (ArticuloEntity)dgvArticulo.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccion.Id);

                    var listArticulo = negocio.GetArticulo();
                    dgvArticulo.DataSource = null;
                    dgvArticulo.DataSource = listArticulo;

                    cargar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                var seleccionado = (ArticuloEntity)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen.UrlImagen);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ArticuloEntity seleccionada;
            seleccionada = (ArticuloEntity)dgvArticulo.CurrentRow.DataBoundItem;

            var ventana = new frmModificarArticulo(seleccionada);
            ventana.ShowDialog();
            cargar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            var listaFiltro = new ArticuloBussines().GetArticulo()
                .Where(a => a.Nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                .ToList();

            if (listaFiltro.Count == 0)
            {
                listaFiltro = new ArticuloBussines().GetArticulo();
            }

            dgvArticulo.DataSource = null;
            dgvArticulo.DataSource = listaFiltro;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


