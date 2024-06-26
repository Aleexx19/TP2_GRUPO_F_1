﻿using Business;
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
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("El input no puede quedar vacío");
                return; //modificado por un return.
            }

            if(txtDescripcion.Text.Length > 50)
            {
                MessageBox.Show("No puede excederse de 50 caracteres");
                return; 
            }

            MarcaEntity marca = new MarcaEntity(); 
            marca.Descripcion = txtDescripcion.Text;

            MarcaBusiness marcaBusiness = new MarcaBusiness();
            try
            {
                if(marcaBusiness.AgregarMarca(marca) > 0)
                {
                    MessageBox.Show("Se agregó con éxito.");
                    Close();

                } else 
                {
                    MessageBox.Show("Hubo un problema al insertar.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al insertar " +  ex.Message);
            }
            
        }


    }
}
