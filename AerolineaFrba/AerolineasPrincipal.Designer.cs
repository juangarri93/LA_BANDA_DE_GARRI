﻿namespace AerolineaFrba
{
    partial class AerolineasPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnABMAronaves = new System.Windows.Forms.Button();
            this.btnABMRol = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnABM_Ciudad = new System.Windows.Forms.Button();
            this.btnABMRutaAerea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABMAronaves
            // 
            this.btnABMAronaves.Location = new System.Drawing.Point(12, 94);
            this.btnABMAronaves.Name = "btnABMAronaves";
            this.btnABMAronaves.Size = new System.Drawing.Size(180, 36);
            this.btnABMAronaves.TabIndex = 0;
            this.btnABMAronaves.Text = "ABM Aeronaves";
            this.btnABMAronaves.UseVisualStyleBackColor = true;
            this.btnABMAronaves.Click += new System.EventHandler(this.btnABM_Aeronaves_Click);
            // 
            // btnABMRol
            // 
            this.btnABMRol.Location = new System.Drawing.Point(12, 145);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(180, 36);
            this.btnABMRol.TabIndex = 1;
            this.btnABMRol.Text = "ABM Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            this.btnABMRol.Click += new System.EventHandler(this.btnABM_Rol_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(141, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 32);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "AEROLINEA";
            // 
            // btnABM_Ciudad
            // 
            this.btnABM_Ciudad.Location = new System.Drawing.Point(12, 203);
            this.btnABM_Ciudad.Name = "btnABM_Ciudad";
            this.btnABM_Ciudad.Size = new System.Drawing.Size(180, 36);
            this.btnABM_Ciudad.TabIndex = 9;
            this.btnABM_Ciudad.Text = "ABM Ciudad";
            this.btnABM_Ciudad.UseVisualStyleBackColor = true;
            this.btnABM_Ciudad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnABMRutaAerea
            // 
            this.btnABMRutaAerea.Location = new System.Drawing.Point(12, 256);
            this.btnABMRutaAerea.Name = "btnABMRutaAerea";
            this.btnABMRutaAerea.Size = new System.Drawing.Size(180, 36);
            this.btnABMRutaAerea.TabIndex = 10;
            this.btnABMRutaAerea.Text = "ABM Ruta Aerea";
            this.btnABMRutaAerea.UseVisualStyleBackColor = true;
            this.btnABMRutaAerea.Click += new System.EventHandler(this.btnABMRutaAerea_Click);
            // 
            // AerolineasPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 341);
            this.Controls.Add(this.btnABMRutaAerea);
            this.Controls.Add(this.btnABM_Ciudad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnABMRol);
            this.Controls.Add(this.btnABMAronaves);
            this.Name = "AerolineasPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnABMAronaves;
        private System.Windows.Forms.Button btnABMRol;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnABM_Ciudad;
        private System.Windows.Forms.Button btnABMRutaAerea;

    }
}
