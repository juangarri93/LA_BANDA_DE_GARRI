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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataListadoCiudades = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.botonBajaLogica = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.checkBoxbajaLogica1 = new System.Windows.Forms.CheckBox();
            this.btnFiltroNombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCiudades)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.dataListadoCiudades);
            this.tabPage1.Controls.Add(this.botonBajaLogica);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.checkBoxbajaLogica1);
            this.tabPage1.Controls.Add(this.btnFiltroNombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.txtNomb);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(791, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 42);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_2);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(699, 210);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 42);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
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
            this.dataListadoCiudades.Location = new System.Drawing.Point(9, 99);
            this.dataListadoCiudades.MultiSelect = false;
            this.dataListadoCiudades.Name = "dataListadoCiudades";
            this.dataListadoCiudades.ReadOnly = true;
            this.dataListadoCiudades.Size = new System.Drawing.Size(563, 242);
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
            // botonBajaLogica
            // 
            this.botonBajaLogica.Location = new System.Drawing.Point(161, 63);
            this.botonBajaLogica.Name = "botonBajaLogica";
            this.botonBajaLogica.Size = new System.Drawing.Size(198, 23);
            this.botonBajaLogica.TabIndex = 13;
            this.botonBajaLogica.Text = "Habilitar-Deshabilitar";
            this.botonBajaLogica.Click += new System.EventHandler(this.botonBajaLogica_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(68, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(188, 20);
            this.txtBuscar.TabIndex = 31;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // checkBoxbajaLogica1
            // 
            this.checkBoxbajaLogica1.AutoSize = true;
            this.checkBoxbajaLogica1.Location = new System.Drawing.Point(9, 67);
            this.checkBoxbajaLogica1.Name = "checkBoxbajaLogica1";
            this.checkBoxbajaLogica1.Size = new System.Drawing.Size(122, 17);
            this.checkBoxbajaLogica1.TabIndex = 12;
            this.checkBoxbajaLogica1.Text = "Habilitar-Deshabilitar";
            this.checkBoxbajaLogica1.UseVisualStyleBackColor = true;
            this.checkBoxbajaLogica1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnFiltroNombre
            // 
            this.btnFiltroNombre.Location = new System.Drawing.Point(314, 12);
            this.btnFiltroNombre.Name = "btnFiltroNombre";
            this.btnFiltroNombre.Size = new System.Drawing.Size(104, 23);
            this.btnFiltroNombre.TabIndex = 12;
            this.btnFiltroNombre.Text = "Filtro Nombre";
            this.btnFiltroNombre.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Codigo Ciudad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCodigo.Location = new System.Drawing.Point(691, 89);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 29;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNomb
            // 
            this.txtNomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtNomb.Location = new System.Drawing.Point(691, 124);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(121, 20);
            this.txtNomb.TabIndex = 24;
            this.txtNomb.TextChanged += new System.EventHandler(this.txtNomb_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(595, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(72, 23);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.Text = "Nombre:";
            this.txtNombre.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(602, 210);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(69, 42);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(432, 72);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(114, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Cantidad de Ciudades:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ciudad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 365);
            this.tabControl1.TabIndex = 7;
            // 
            // ABMCiudadBajaModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 395);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ABMCiudadBajaModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMBajaModificacion";
            this.Load += new System.EventHandler(this.ABMBajaModificacion_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCiudades)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.Label lblTotal;


        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtCodigo;
     
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltroNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button botonBajaLogica;
        private System.Windows.Forms.CheckBox checkBoxbajaLogica1;
        private System.Windows.Forms.DataGridView dataListadoCiudades;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;


    }
}