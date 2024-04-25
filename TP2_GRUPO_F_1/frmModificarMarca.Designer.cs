namespace TP2_GRUPO_F_1
{
    partial class frmModificarMarca
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
            this.lblModificar = new System.Windows.Forms.Label();
            this.txtModificar = new System.Windows.Forms.TextBox();
            this.btnAceptarModificar = new System.Windows.Forms.Button();
            this.btnCancelarModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Location = new System.Drawing.Point(46, 50);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(69, 13);
            this.lblModificar.TabIndex = 0;
            this.lblModificar.Text = "Descripción: ";
            // 
            // txtModificar
            // 
            this.txtModificar.Location = new System.Drawing.Point(121, 47);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(100, 20);
            this.txtModificar.TabIndex = 1;
            // 
            // btnAceptarModificar
            // 
            this.btnAceptarModificar.Location = new System.Drawing.Point(25, 107);
            this.btnAceptarModificar.Name = "btnAceptarModificar";
            this.btnAceptarModificar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarModificar.TabIndex = 2;
            this.btnAceptarModificar.Text = "Aceptar";
            this.btnAceptarModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarModificar
            // 
            this.btnCancelarModificar.Location = new System.Drawing.Point(136, 107);
            this.btnCancelarModificar.Name = "btnCancelarModificar";
            this.btnCancelarModificar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModificar.TabIndex = 3;
            this.btnCancelarModificar.Text = "Cancelar";
            this.btnCancelarModificar.UseVisualStyleBackColor = true;
            // 
            // frmModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 191);
            this.Controls.Add(this.btnCancelarModificar);
            this.Controls.Add(this.btnAceptarModificar);
            this.Controls.Add(this.txtModificar);
            this.Controls.Add(this.lblModificar);
            this.Name = "frmModificarMarca";
            this.Text = "frmModificarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.TextBox txtModificar;
        private System.Windows.Forms.Button btnAceptarModificar;
        private System.Windows.Forms.Button btnCancelarModificar;
    }
}