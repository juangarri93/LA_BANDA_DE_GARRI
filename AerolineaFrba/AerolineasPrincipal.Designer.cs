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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AerolineasPrincipal));
            this.btnABMAronaves = new System.Windows.Forms.Button();
            this.btnABMRol = new System.Windows.Forms.Button();
            this.btnABM_Ciudad = new System.Windows.Forms.Button();
            this.btnABMRutaAerea = new System.Windows.Forms.Button();
            this.btnRegistrosDeUsuarios = new System.Windows.Forms.Button();
            this.btnGenerarViaje = new System.Windows.Forms.Button();
            this.btnRegistroDeLlegadaDestino = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_canjear_millas = new System.Windows.Forms.Button();
            this.btn_consulta_millas = new System.Windows.Forms.Button();
            this.btnEstadist = new System.Windows.Forms.Button();
            this.btnCancelacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnABMAronaves
            // 
            this.btnABMAronaves.Location = new System.Drawing.Point(662, 222);
            this.btnABMAronaves.Name = "btnABMAronaves";
            this.btnABMAronaves.Size = new System.Drawing.Size(180, 36);
            this.btnABMAronaves.TabIndex = 0;
            this.btnABMAronaves.Text = "ABM Aeronaves";
            this.btnABMAronaves.UseVisualStyleBackColor = true;
            this.btnABMAronaves.Click += new System.EventHandler(this.btnABM_Aeronaves_Click);
            // 
            // btnABMRol
            // 
            this.btnABMRol.Location = new System.Drawing.Point(660, 96);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(180, 36);
            this.btnABMRol.TabIndex = 1;
            this.btnABMRol.Text = "ABM Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            this.btnABMRol.Click += new System.EventHandler(this.btnABM_Rol_Click);
            // 
            // btnABM_Ciudad
            // 
            this.btnABM_Ciudad.Location = new System.Drawing.Point(476, 96);
            this.btnABM_Ciudad.Name = "btnABM_Ciudad";
            this.btnABM_Ciudad.Size = new System.Drawing.Size(180, 36);
            this.btnABM_Ciudad.TabIndex = 9;
            this.btnABM_Ciudad.Text = "ABM Ciudad";
            this.btnABM_Ciudad.UseVisualStyleBackColor = true;
            this.btnABM_Ciudad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnABMRutaAerea
            // 
            this.btnABMRutaAerea.Location = new System.Drawing.Point(476, 138);
            this.btnABMRutaAerea.Name = "btnABMRutaAerea";
            this.btnABMRutaAerea.Size = new System.Drawing.Size(180, 36);
            this.btnABMRutaAerea.TabIndex = 10;
            this.btnABMRutaAerea.Text = "ABM Ruta Aerea";
            this.btnABMRutaAerea.UseVisualStyleBackColor = true;
            this.btnABMRutaAerea.Click += new System.EventHandler(this.btnABMRutaAerea_Click);
            // 
            // btnRegistrosDeUsuarios
            // 
            this.btnRegistrosDeUsuarios.Location = new System.Drawing.Point(662, 54);
            this.btnRegistrosDeUsuarios.Name = "btnRegistrosDeUsuarios";
            this.btnRegistrosDeUsuarios.Size = new System.Drawing.Size(180, 36);
            this.btnRegistrosDeUsuarios.TabIndex = 11;
            this.btnRegistrosDeUsuarios.Text = "Registro de Usuarios";
            this.btnRegistrosDeUsuarios.UseVisualStyleBackColor = true;
            this.btnRegistrosDeUsuarios.Click += new System.EventHandler(this.btnRegistrosDeUsuarios_Click);
            // 
            // btnGenerarViaje
            // 
            this.btnGenerarViaje.Location = new System.Drawing.Point(662, 138);
            this.btnGenerarViaje.Name = "btnGenerarViaje";
            this.btnGenerarViaje.Size = new System.Drawing.Size(180, 36);
            this.btnGenerarViaje.TabIndex = 12;
            this.btnGenerarViaje.Text = "Generar Viaje";
            this.btnGenerarViaje.UseVisualStyleBackColor = true;
            this.btnGenerarViaje.Click += new System.EventHandler(this.btnGenerarViaje_Click);
            // 
            // btnRegistroDeLlegadaDestino
            // 
            this.btnRegistroDeLlegadaDestino.Location = new System.Drawing.Point(662, 180);
            this.btnRegistroDeLlegadaDestino.Name = "btnRegistroDeLlegadaDestino";
            this.btnRegistroDeLlegadaDestino.Size = new System.Drawing.Size(180, 36);
            this.btnRegistroDeLlegadaDestino.TabIndex = 13;
            this.btnRegistroDeLlegadaDestino.Text = "Registro De Llegada Destino";
            this.btnRegistroDeLlegadaDestino.UseVisualStyleBackColor = true;
            this.btnRegistroDeLlegadaDestino.Click += new System.EventHandler(this.btnRegistroDeLlegadaDestino_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(476, 54);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(180, 36);
            this.btnCompra.TabIndex = 14;
            this.btnCompra.Text = "Compra de pasaje/encomienda";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(376, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 17);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Iniciar Sesion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_canjear_millas
            // 
            this.btn_canjear_millas.Location = new System.Drawing.Point(476, 12);
            this.btn_canjear_millas.Name = "btn_canjear_millas";
            this.btn_canjear_millas.Size = new System.Drawing.Size(180, 36);
            this.btn_canjear_millas.TabIndex = 17;
            this.btn_canjear_millas.Text = "Canjear Millas";
            this.btn_canjear_millas.UseVisualStyleBackColor = true;
            this.btn_canjear_millas.Click += new System.EventHandler(this.btn_canjear_millas_Click);
            // 
            // btn_consulta_millas
            // 
            this.btn_consulta_millas.Location = new System.Drawing.Point(660, 12);
            this.btn_consulta_millas.Name = "btn_consulta_millas";
            this.btn_consulta_millas.Size = new System.Drawing.Size(180, 36);
            this.btn_consulta_millas.TabIndex = 16;
            this.btn_consulta_millas.Text = "Consultar Millas";
            this.btn_consulta_millas.UseVisualStyleBackColor = true;
            this.btn_consulta_millas.Click += new System.EventHandler(this.btn_consulta_millas_Click);
            // 
            // btnEstadist
            // 
            this.btnEstadist.Location = new System.Drawing.Point(476, 222);
            this.btnEstadist.Name = "btnEstadist";
            this.btnEstadist.Size = new System.Drawing.Size(180, 36);
            this.btnEstadist.TabIndex = 18;
            this.btnEstadist.Text = "Listado Estadístico";
            this.btnEstadist.UseVisualStyleBackColor = true;
            this.btnEstadist.Click += new System.EventHandler(this.btnEstadist_Click);
            // 
            // btnCancelacion
            // 
            this.btnCancelacion.Location = new System.Drawing.Point(474, 180);
            this.btnCancelacion.Name = "btnCancelacion";
            this.btnCancelacion.Size = new System.Drawing.Size(180, 36);
            this.btnCancelacion.TabIndex = 19;
            this.btnCancelacion.Text = "Cancelacion Pasaje y/o Encomienda";
            this.btnCancelacion.UseVisualStyleBackColor = true;
            this.btnCancelacion.Click += new System.EventHandler(this.btnCancelacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 205);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 48);
            this.label1.TabIndex = 21;
            this.label1.Text = "Aerolinea FRBA";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(9, 12);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(95, 17);
            this.linkLabel2.TabIndex = 22;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Cerrar Sesion";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // AerolineasPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(851, 269);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelacion);
            this.Controls.Add(this.btnEstadist);
            this.Controls.Add(this.btn_canjear_millas);
            this.Controls.Add(this.btn_consulta_millas);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnRegistroDeLlegadaDestino);
            this.Controls.Add(this.btnGenerarViaje);
            this.Controls.Add(this.btnRegistrosDeUsuarios);
            this.Controls.Add(this.btnABMRutaAerea);
            this.Controls.Add(this.btnABM_Ciudad);
            this.Controls.Add(this.btnABMRol);
            this.Controls.Add(this.btnABMAronaves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AerolineasPrincipal";
            this.Text = "Aerolineas FRBA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnABMAronaves;
        private System.Windows.Forms.Button btnABMRol;
        private System.Windows.Forms.Button btnABM_Ciudad;
        private System.Windows.Forms.Button btnABMRutaAerea;
        private System.Windows.Forms.Button btnRegistrosDeUsuarios;
        private System.Windows.Forms.Button btnGenerarViaje;
        private System.Windows.Forms.Button btnRegistroDeLlegadaDestino;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_canjear_millas;
        private System.Windows.Forms.Button btn_consulta_millas;
        private System.Windows.Forms.Button btnEstadist;
        private System.Windows.Forms.Button btnCancelacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;

    }
}

