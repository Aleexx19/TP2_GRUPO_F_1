namespace TP2_GRUPO_F_1
{
    partial class frmModificarCategoria
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
            this.lblidOculto = new System.Windows.Forms.Label();
            this.btnCancelarModificar = new System.Windows.Forms.Button();
            this.btnAceptarModificar = new System.Windows.Forms.Button();
            this.txtModificar = new System.Windows.Forms.TextBox();
            this.lblModificar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblidOculto
            // 
            this.lblidOculto.AutoSize = true;
            this.lblidOculto.Location = new System.Drawing.Point(83, 34);
            this.lblidOculto.Name = "lblidOculto";
            this.lblidOculto.Size = new System.Drawing.Size(0, 13);
            this.lblidOculto.TabIndex = 9;
            // 
            // btnCancelarModificar
            // 
            this.btnCancelarModificar.Location = new System.Drawing.Point(197, 124);
            this.btnCancelarModificar.Name = "btnCancelarModificar";
            this.btnCancelarModificar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModificar.TabIndex = 8;
            this.btnCancelarModificar.Text = "Cancelar";
            this.btnCancelarModificar.UseVisualStyleBackColor = true;
            this.btnCancelarModificar.Click += new System.EventHandler(this.btnCancelarModificar_Click);
            // 
            // btnAceptarModificar
            // 
            this.btnAceptarModificar.Location = new System.Drawing.Point(86, 124);
            this.btnAceptarModificar.Name = "btnAceptarModificar";
            this.btnAceptarModificar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarModificar.TabIndex = 7;
            this.btnAceptarModificar.Text = "Aceptar";
            this.btnAceptarModificar.UseVisualStyleBackColor = true;
            this.btnAceptarModificar.Click += new System.EventHandler(this.btnAceptarModificar_Click);
            // 
            // txtModificar
            // 
            this.txtModificar.Location = new System.Drawing.Point(158, 61);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(114, 20);
            this.txtModificar.TabIndex = 6;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Location = new System.Drawing.Point(83, 64);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(69, 13);
            this.lblModificar.TabIndex = 5;
            this.lblModificar.Text = "Descripción: ";
            // 
            // frmModificarCategoria
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 210);
            this.Controls.Add(this.lblidOculto);
            this.Controls.Add(this.btnCancelarModificar);
            this.Controls.Add(this.btnAceptarModificar);
            this.Controls.Add(this.txtModificar);
            this.Controls.Add(this.lblModificar);
            this.Name = "frmModificarCategoria";
            this.Text = "Modificar Categoria";
            this.Load += new System.EventHandler(this.frmModificarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidOculto;
        private System.Windows.Forms.Button btnCancelarModificar;
        private System.Windows.Forms.Button btnAceptarModificar;
        private System.Windows.Forms.TextBox txtModificar;
        private System.Windows.Forms.Label lblModificar;
    }
}