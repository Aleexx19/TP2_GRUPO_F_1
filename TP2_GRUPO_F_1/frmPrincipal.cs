using Domain.Entities;
using System;
using System.Windows.Forms;


namespace TP2_GRUPO_F_1
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmMarca))
                {
                    MessageBox.Show("No se puede abrir la misma ventana cuando esta en uso");
                    return;
                }
            }

            var ventana = new frmMarca();
            ventana.MdiParent = this;
            ventana.Show();
            
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmCategoria))
                {
                    MessageBox.Show("No se puede abrir la misma ventana cuando esta en uso");
                    return;
                }
            }

            var ventana = new frmCategoria();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarca alta = new frmAgregarMarca();
            alta.ShowDialog();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmArticulo))
                {
                    MessageBox.Show("No se puede abrir la misma ventana cuando esta en uso");
                    return;
                }
            }

            var ventana = new FrmArticulo();
            ventana.MdiParent = this;
            ventana.Show();

        }

        //Borré el boton de modificar, y lo puse dentro del listado.
    }
}
