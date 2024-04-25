namespace TP2_GRUPO_F_1
{
    partial class frmAgregarMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategoriaAgregarMarca = new System.Windows.Forms.Label();
            this.txtCategoriaAgregarMarca = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategoriaAgregarMarca
            // 
            this.lblCategoriaAgregarMarca.AutoSize = true;
            this.lblCategoriaAgregarMarca.Location = new System.Drawing.Point(46, 40);
            this.lblCategoriaAgregarMarca.Name = "lblCategoriaAgregarMarca";
            this.lblCategoriaAgregarMarca.Size = new System.Drawing.Size(69, 13);
            this.lblCategoriaAgregarMarca.TabIndex = 0;
            this.lblCategoriaAgregarMarca.Text = "Descripción: ";
            // 
            // txtCategoriaAgregarMarca
            // 
            this.txtCategoriaAgregarMarca.Location = new System.Drawing.Point(121, 37);
            this.txtCategoriaAgregarMarca.Name = "txtCategoriaAgregarMarca";
            this.txtCategoriaAgregarMarca.Size = new System.Drawing.Size(100, 20);
            this.txtCategoriaAgregarMarca.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(49, 111);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(154, 111);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 180);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCategoriaAgregarMarca);
            this.Controls.Add(this.lblCategoriaAgregarMarca);
            this.Name = "frmAgregarMarca";
            this.Text = "Agregar Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoriaAgregarMarca;
        private System.Windows.Forms.TextBox txtCategoriaAgregarMarca;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}