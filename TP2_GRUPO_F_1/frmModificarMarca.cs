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
    public partial class frmModificarMarca : Form
    {
        public frmModificarMarca()
        {
            InitializeComponent();
        }

        private void btnAceptarModificar_Click(object sender, EventArgs e)
        {
            
            MarcaEntity modificacion = new MarcaEntity();
            
            
        }

        private void btnCancelarModificar_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
