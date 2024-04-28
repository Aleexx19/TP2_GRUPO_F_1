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
    public partial class frmModificarArticulo : Form
    {

        private ArticuloEntity artic = null;
        public frmModificarArticulo(ArticuloEntity artic)
        {
            this.artic = artic;
            InitializeComponent();
        }
        private void frmModificarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
        }

    }
}