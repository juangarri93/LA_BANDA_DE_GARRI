namespace AerolineaFrba.Abm_Ciudad
{
    partial class ABMCiudadBajaModif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMCiudadBajaModif));
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltroNombre = new System.Windows.Forms.Button();
            this.checkBoxbajaLogica1 = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.botonBajaLogica = new System.Windows.Forms.Button();
            this.dataListadoCiudades = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ciudad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(366, 71);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(114, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Cantidad de Ciudades:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(368, 183);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(69, 42);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(365, 146);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(72, 23);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.Text = "Nombre:";
            this.txtNombre.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtNomb
            // 
            this.txtNomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtNomb.Location = new System.Drawing.Point(435, 146);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(180, 20);
            this.txtNomb.TabIndex = 24;
            this.txtNomb.TextChanged += new System.EventHandler(this.txtNomb_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCodigo.Location = new System.Drawing.Point(435, 111);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(180, 20);
            this.txtCodigo.TabIndex = 29;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Codigo Ciudad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFiltroNombre
            // 
            this.btnFiltroNombre.Location = new System.Drawing.Point(324, 11);
            this.btnFiltroNombre.Name = "btnFiltroNombre";
            this.btnFiltroNombre.Size = new System.Drawing.Size(104, 23);
            this.btnFiltroNombre.TabIndex = 12;
            this.btnFiltroNombre.Text = "Filtro Nombre";
            this.btnFiltroNombre.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBoxbajaLogica1
            // 
            this.checkBoxbajaLogica1.AutoSize = true;
            this.checkBoxbajaLogica1.Location = new System.Drawing.Point(19, 65);
            this.checkBoxbajaLogica1.Name = "checkBoxbajaLogica1";
            this.checkBoxbajaLogica1.Size = new System.Drawing.Size(122, 17);
            this.checkBoxbajaLogica1.TabIndex = 12;
            this.checkBoxbajaLogica1.Text = "Habilitar-Deshabilitar";
            this.checkBoxbajaLogica1.UseVisualStyleBackColor = true;
            this.checkBoxbajaLogica1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(78, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(188, 20);
            this.txtBuscar.TabIndex = 31;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // botonBajaLogica
            // 
            this.botonBajaLogica.Location = new System.Drawing.Point(171, 62);
            this.botonBajaLogica.Name = "botonBajaLogica";
            this.botonBajaLogica.Size = new System.Drawing.Size(165, 23);
            this.botonBajaLogica.TabIndex = 13;
            this.botonBajaLogica.Text = "Habilitar-Deshabilitar";
            this.botonBajaLogica.Click += new System.EventHandler(this.botonBajaLogica_Click);
            // 
            // dataListadoCiudades
            // 
            this.dataListadoCiudades.AllowUserToAddRows = false;
            this.dataListadoCiudades.AllowUserToDeleteRows = false;
            this.dataListadoCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataListadoCiudades.ColumnHeadersHeight = 30;
            this.dataListadoCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListadoCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataListadoCiudades.Location = new System.Drawing.Point(10, 110);
            this.dataListadoCiudades.MultiSelect = false;
            this.dataListadoCiudades.Name = "dataListadoCiudades";
            this.dataListadoCiudades.ReadOnly = true;
            this.dataListadoCiudades.Size = new System.Drawing.Size(326, 242);
            this.dataListadoCiudades.TabIndex = 33;
            this.dataListadoCiudades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoCiudades_CellContentClick);
            this.dataListadoCiudades.DoubleClick += new System.EventHandler(this.dataListadoCiudades_DoubleClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Baja Logica";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 69;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(461, 183);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 42);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(545, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 42);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_2);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(583, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 33);
            this.button3.TabIndex = 36;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ABMCiudadBajaModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 360);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.botonBajaLogica);
            this.Controls.Add(this.dataListadoCiudades);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxbajaLogica1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFiltroNombre);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNomb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ABMCiudadBajaModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja/Modificacion Ciudades";
            this.Load += new System.EventHandler(this.ABMBajaModificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltroNombre;
        private System.Windows.Forms.CheckBox checkBoxbajaLogica1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button botonBajaLogica;
        private System.Windows.Forms.DataGridView dataListadoCiudades;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button3;



    }
}