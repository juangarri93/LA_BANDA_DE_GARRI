namespace AerolineaFrba
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
            this.btnRegistrosDeUsuarios = new System.Windows.Forms.Button();
            this.btnGenerarViaje = new System.Windows.Forms.Button();
            this.btnRegistroDeLlegadaDestino = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_canjear_millas = new System.Windows.Forms.Button();
            this.btn_consulta_millas = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // btnABMAronaves
            // 
            this.btnABMAronaves.Location = new System.Drawing.Point(16, 116);
            this.btnABMAronaves.Margin = new System.Windows.Forms.Padding(4);
            this.btnABMAronaves.Name = "btnABMAronaves";
            this.btnABMAronaves.Size = new System.Drawing.Size(240, 44);
            this.btnABMAronaves.TabIndex = 0;
            this.btnABMAronaves.Text = "ABM Aeronaves";
            this.btnABMAronaves.UseVisualStyleBackColor = true;
            this.btnABMAronaves.Click += new System.EventHandler(this.btnABM_Aeronaves_Click);
            // 
            // btnABMRol
            // 
            this.btnABMRol.Location = new System.Drawing.Point(16, 178);
            this.btnABMRol.Margin = new System.Windows.Forms.Padding(4);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(240, 44);
            this.btnABMRol.TabIndex = 1;
            this.btnABMRol.Text = "ABM Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            this.btnABMRol.Click += new System.EventHandler(this.btnABM_Rol_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(206, 36);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(215, 40);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "AEROLINEA";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnABM_Ciudad
            // 
            this.btnABM_Ciudad.Location = new System.Drawing.Point(16, 250);
            this.btnABM_Ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.btnABM_Ciudad.Name = "btnABM_Ciudad";
            this.btnABM_Ciudad.Size = new System.Drawing.Size(240, 44);
            this.btnABM_Ciudad.TabIndex = 9;
            this.btnABM_Ciudad.Text = "ABM Ciudad";
            this.btnABM_Ciudad.UseVisualStyleBackColor = true;
            this.btnABM_Ciudad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnABMRutaAerea
            // 
            this.btnABMRutaAerea.Location = new System.Drawing.Point(16, 315);
            this.btnABMRutaAerea.Margin = new System.Windows.Forms.Padding(4);
            this.btnABMRutaAerea.Name = "btnABMRutaAerea";
            this.btnABMRutaAerea.Size = new System.Drawing.Size(240, 44);
            this.btnABMRutaAerea.TabIndex = 10;
            this.btnABMRutaAerea.Text = "ABM Ruta Aerea";
            this.btnABMRutaAerea.UseVisualStyleBackColor = true;
            this.btnABMRutaAerea.Click += new System.EventHandler(this.btnABMRutaAerea_Click);
            // 
            // btnRegistrosDeUsuarios
            // 
            this.btnRegistrosDeUsuarios.Location = new System.Drawing.Point(376, 116);
            this.btnRegistrosDeUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrosDeUsuarios.Name = "btnRegistrosDeUsuarios";
            this.btnRegistrosDeUsuarios.Size = new System.Drawing.Size(240, 44);
            this.btnRegistrosDeUsuarios.TabIndex = 11;
            this.btnRegistrosDeUsuarios.Text = "Registro de Usuarios";
            this.btnRegistrosDeUsuarios.UseVisualStyleBackColor = true;
            this.btnRegistrosDeUsuarios.Click += new System.EventHandler(this.btnRegistrosDeUsuarios_Click);
            // 
            // btnGenerarViaje
            // 
            this.btnGenerarViaje.Location = new System.Drawing.Point(376, 178);
            this.btnGenerarViaje.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarViaje.Name = "btnGenerarViaje";
            this.btnGenerarViaje.Size = new System.Drawing.Size(240, 44);
            this.btnGenerarViaje.TabIndex = 12;
            this.btnGenerarViaje.Text = "Generar Viaje";
            this.btnGenerarViaje.UseVisualStyleBackColor = true;
            this.btnGenerarViaje.Click += new System.EventHandler(this.btnGenerarViaje_Click);
            // 
            // btnRegistroDeLlegadaDestino
            // 
            this.btnRegistroDeLlegadaDestino.Location = new System.Drawing.Point(376, 250);
            this.btnRegistroDeLlegadaDestino.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistroDeLlegadaDestino.Name = "btnRegistroDeLlegadaDestino";
            this.btnRegistroDeLlegadaDestino.Size = new System.Drawing.Size(240, 44);
            this.btnRegistroDeLlegadaDestino.TabIndex = 13;
            this.btnRegistroDeLlegadaDestino.Text = "Registro De Llegada Destino";
            this.btnRegistroDeLlegadaDestino.UseVisualStyleBackColor = true;
            this.btnRegistroDeLlegadaDestino.Click += new System.EventHandler(this.btnRegistroDeLlegadaDestino_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(376, 315);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(240, 44);
            this.btnCompra.TabIndex = 14;
            this.btnCompra.Text = "Compra de pasaje/encomienda";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(523, 11);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 17);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Iniciar Sesion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_canjear_millas
            // 
            this.btn_canjear_millas.Location = new System.Drawing.Point(376, 384);
            this.btn_canjear_millas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_canjear_millas.Name = "btn_canjear_millas";
            this.btn_canjear_millas.Size = new System.Drawing.Size(240, 44);
            this.btn_canjear_millas.TabIndex = 17;
            this.btn_canjear_millas.Text = "Canjear Millas";
            this.btn_canjear_millas.UseVisualStyleBackColor = true;
            // 
            // btn_consulta_millas
            // 
            this.btn_consulta_millas.Location = new System.Drawing.Point(16, 384);
            this.btn_consulta_millas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consulta_millas.Name = "btn_consulta_millas";
            this.btn_consulta_millas.Size = new System.Drawing.Size(240, 44);
            this.btn_consulta_millas.TabIndex = 16;
            this.btn_consulta_millas.Text = "Consultar Millas";
            this.btn_consulta_millas.UseVisualStyleBackColor = true;
            this.btn_consulta_millas.Click += new System.EventHandler(this.btn_consulta_millas_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(632, 466);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 313;
            this.lineShape1.X2 = 312;
            this.lineShape1.Y1 = 116;
            this.lineShape1.Y2 = 440;
            // 
            // AerolineasPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 466);
            this.Controls.Add(this.btn_canjear_millas);
            this.Controls.Add(this.btn_consulta_millas);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnRegistroDeLlegadaDestino);
            this.Controls.Add(this.btnGenerarViaje);
            this.Controls.Add(this.btnRegistrosDeUsuarios);
            this.Controls.Add(this.btnABMRutaAerea);
            this.Controls.Add(this.btnABM_Ciudad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnABMRol);
            this.Controls.Add(this.btnABMAronaves);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnRegistrosDeUsuarios;
        private System.Windows.Forms.Button btnGenerarViaje;
        private System.Windows.Forms.Button btnRegistroDeLlegadaDestino;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_canjear_millas;
        private System.Windows.Forms.Button btn_consulta_millas;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;

    }
}

