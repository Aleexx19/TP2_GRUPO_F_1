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
    }
}
