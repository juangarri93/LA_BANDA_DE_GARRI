namespace AerolineaFrba.Abm_Rol
{
    partial class ABMRolBajaModificacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.BajaLogica = new System.Windows.Forms.Button();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.EditarFuncionalidad = new System.Windows.Forms.Button();
            this.labelNNR = new System.Windows.Forms.Label();
            this.txtNuevoRol = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Editar Nombre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre Rol :";
            // 
            // Funcionalidades
            // 
            this.Funcionalidades.FormattingEnabled = true;
            this.Funcionalidades.Location = new System.Drawing.Point(16, 58);
            this.Funcionalidades.Name = "Funcionalidades";
            this.Funcionalidades.Size = new System.Drawing.Size(257, 229);
            this.Funcionalidades.TabIndex = 18;
            // 
            // BajaLogica
            // 
            this.BajaLogica.Location = new System.Drawing.Point(331, 230);
            this.BajaLogica.Name = "BajaLogica";
            this.BajaLogica.Size = new System.Drawing.Size(159, 57);
            this.BajaLogica.TabIndex = 19;
            this.BajaLogica.Text = "Baja Logica";
            this.BajaLogica.UseVisualStyleBackColor = true;
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(152, 19);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(121, 21);
            this.cbNombre.TabIndex = 20;
            // 
            // EditarFuncionalidad
            // 
            this.EditarFuncionalidad.Location = new System.Drawing.Point(331, 139);
            this.EditarFuncionalidad.Name = "EditarFuncionalidad";
            this.EditarFuncionalidad.Size = new System.Drawing.Size(159, 55);
            this.EditarFuncionalidad.TabIndex = 21;
            this.EditarFuncionalidad.Text = "Editar Funcionalidad";
            this.EditarFuncionalidad.UseVisualStyleBackColor = true;
            this.EditarFuncionalidad.Click += new System.EventHandler(this.EditarFuncionalidad_Click);
            // 
            // labelNNR
            // 
            this.labelNNR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNNR.Location = new System.Drawing.Point(298, 19);
            this.labelNNR.Name = "labelNNR";
            this.labelNNR.Size = new System.Drawing.Size(192, 29);
            this.labelNNR.TabIndex = 22;
            this.labelNNR.Text = "Nombre Nuevo Rol :";
            // 
            // txtNuevoRol
            // 
            this.txtNuevoRol.Location = new System.Drawing.Point(477, 20);
            this.txtNuevoRol.Name = "txtNuevoRol";
            this.txtNuevoRol.Size = new System.Drawing.Size(136, 20);
            this.txtNuevoRol.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(559, 139);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 55);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // ABMRolBajaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 331);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNuevoRol);
            this.Controls.Add(this.labelNNR);
            this.Controls.Add(this.EditarFuncionalidad);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.BajaLogica);
            this.Controls.Add(this.Funcionalidades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ABMRolBajaModificacion";
            this.Text = "ABMRolBajaModificacion";
            this.Load += new System.EventHandler(this.ABMRolBajaModificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Funcionalidades;
        private System.Windows.Forms.Button BajaLogica;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.Button EditarFuncionalidad;
        private System.Windows.Forms.Label labelNNR;
        private System.Windows.Forms.TextBox txtNuevoRol;
        private System.Windows.Forms.Button btnGuardar;
    }
}