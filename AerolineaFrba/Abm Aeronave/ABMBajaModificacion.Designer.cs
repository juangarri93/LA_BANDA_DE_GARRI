﻿namespace AerolineaFrba.Abm_Aeronave
{
    partial class ABMBajaModificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMBajaModificacion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBajaLogica = new System.Windows.Forms.Button();
            this.checkBoxbajaLogica1 = new System.Windows.Forms.CheckBox();
            this.btnFabricante = new System.Windows.Forms.Button();
            this.btnFiltroModelo = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataListadoAeronaves = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnFiltroNumero = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditarBFS = new System.Windows.Forms.Button();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbTipoDeServicio = new System.Windows.Forms.ComboBox();
            this.txtCantidadDeButacasVentana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaFueraDeServicio = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDeReinicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadDeKG = new System.Windows.Forms.TextBox();
            this.txtCantidadDeButacasPasillo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNumeroAeronave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.CodigoAeronave = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoAeronaves)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 365);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnVolver);
            this.tabPage1.Controls.Add(this.btnBajaLogica);
            this.tabPage1.Controls.Add(this.checkBoxbajaLogica1);
            this.tabPage1.Controls.Add(this.btnFabricante);
            this.tabPage1.Controls.Add(this.btnFiltroModelo);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.dataListadoAeronaves);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.btnFiltroNumero);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Filtrar por:";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(860, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 33);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(788, 6);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBajaLogica
            // 
            this.btnBajaLogica.Location = new System.Drawing.Point(635, 47);
            this.btnBajaLogica.Name = "btnBajaLogica";
            this.btnBajaLogica.Size = new System.Drawing.Size(113, 23);
            this.btnBajaLogica.TabIndex = 11;
            this.btnBajaLogica.Text = "Baja Logica";
            this.btnBajaLogica.Click += new System.EventHandler(this.btnBajaLogica_Click);
            // 
            // checkBoxbajaLogica1
            // 
            this.checkBoxbajaLogica1.AutoSize = true;
            this.checkBoxbajaLogica1.Location = new System.Drawing.Point(506, 51);
            this.checkBoxbajaLogica1.Name = "checkBoxbajaLogica1";
            this.checkBoxbajaLogica1.Size = new System.Drawing.Size(123, 17);
            this.checkBoxbajaLogica1.TabIndex = 10;
            this.checkBoxbajaLogica1.Text = "Habilitar Baja Logica";
            this.checkBoxbajaLogica1.UseVisualStyleBackColor = true;
            this.checkBoxbajaLogica1.CheckedChanged += new System.EventHandler(this.bajaLogica1_CheckedChanged);
            // 
            // btnFabricante
            // 
            this.btnFabricante.Location = new System.Drawing.Point(358, 47);
            this.btnFabricante.Name = "btnFabricante";
            this.btnFabricante.Size = new System.Drawing.Size(104, 23);
            this.btnFabricante.TabIndex = 9;
            this.btnFabricante.Text = "Fabricante";
            this.btnFabricante.Click += new System.EventHandler(this.btnFabricante_Click);
            // 
            // btnFiltroModelo
            // 
            this.btnFiltroModelo.Location = new System.Drawing.Point(224, 47);
            this.btnFiltroModelo.Name = "btnFiltroModelo";
            this.btnFiltroModelo.Size = new System.Drawing.Size(104, 23);
            this.btnFiltroModelo.TabIndex = 8;
            this.btnFiltroModelo.Text = "Modelo";
            this.btnFiltroModelo.Click += new System.EventHandler(this.btnFiltroModelo_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(520, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Cantidad Aeronaves :";
            // 
            // dataListadoAeronaves
            // 
            this.dataListadoAeronaves.AllowUserToAddRows = false;
            this.dataListadoAeronaves.AllowUserToDeleteRows = false;
            this.dataListadoAeronaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataListadoAeronaves.ColumnHeadersHeight = 30;
            this.dataListadoAeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListadoAeronaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataListadoAeronaves.Location = new System.Drawing.Point(6, 91);
            this.dataListadoAeronaves.MultiSelect = false;
            this.dataListadoAeronaves.Name = "dataListadoAeronaves";
            this.dataListadoAeronaves.ReadOnly = true;
            this.dataListadoAeronaves.Size = new System.Drawing.Size(886, 242);
            this.dataListadoAeronaves.TabIndex = 4;
            this.dataListadoAeronaves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoAeronaves_CellContentClick);
            this.dataListadoAeronaves.DoubleClick += new System.EventHandler(this.dataListadoAeronaves_DoubleClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Baja Logica";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 69;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(202, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(145, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // btnFiltroNumero
            // 
            this.btnFiltroNumero.Location = new System.Drawing.Point(92, 47);
            this.btnFiltroNumero.Name = "btnFiltroNumero";
            this.btnFiltroNumero.Size = new System.Drawing.Size(104, 23);
            this.btnFiltroNumero.TabIndex = 7;
            this.btnFiltroNumero.Text = "Numero";
            this.btnFiltroNumero.Click += new System.EventHandler(this.FiltroNumero_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dato a Filtrar : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnEditarBFS);
            this.groupBox1.Controls.Add(this.cbFabricante);
            this.groupBox1.Controls.Add(this.cbModelo);
            this.groupBox1.Controls.Add(this.cbTipoDeServicio);
            this.groupBox1.Controls.Add(this.txtCantidadDeButacasVentana);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFechaFueraDeServicio);
            this.groupBox1.Controls.Add(this.dtFechaDeReinicio);
            this.groupBox1.Controls.Add(this.dtpFechaAlta);
            this.groupBox1.Controls.Add(this.txtCantidadDeKG);
            this.groupBox1.Controls.Add(this.txtCantidadDeButacasPasillo);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.txtNumeroAeronave);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.CodigoAeronave);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aeronaves";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(860, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 33);
            this.button2.TabIndex = 75;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 50);
            this.button1.TabIndex = 74;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarBFS
            // 
            this.btnEditarBFS.Location = new System.Drawing.Point(604, 157);
            this.btnEditarBFS.Name = "btnEditarBFS";
            this.btnEditarBFS.Size = new System.Drawing.Size(99, 50);
            this.btnEditarBFS.TabIndex = 73;
            this.btnEditarBFS.Text = "Habilitar baja fuera de servicio";
            this.btnEditarBFS.UseVisualStyleBackColor = true;
            this.btnEditarBFS.Click += new System.EventHandler(this.btnEditarBFS_Click);
            // 
            // cbFabricante
            // 
            this.cbFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(429, 25);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(121, 21);
            this.cbFabricante.TabIndex = 71;
            // 
            // cbModelo
            // 
            this.cbModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(130, 125);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(121, 21);
            this.cbModelo.TabIndex = 70;
            // 
            // cbTipoDeServicio
            // 
            this.cbTipoDeServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbTipoDeServicio.FormattingEnabled = true;
            this.cbTipoDeServicio.Location = new System.Drawing.Point(430, 56);
            this.cbTipoDeServicio.Name = "cbTipoDeServicio";
            this.cbTipoDeServicio.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDeServicio.TabIndex = 69;
            this.cbTipoDeServicio.SelectedIndexChanged += new System.EventHandler(this.cbTipoDeServicio_SelectedIndexChanged);
            // 
            // txtCantidadDeButacasVentana
            // 
            this.txtCantidadDeButacasVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCantidadDeButacasVentana.Location = new System.Drawing.Point(433, 123);
            this.txtCantidadDeButacasVentana.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadDeButacasVentana.Name = "txtCantidadDeButacasVentana";
            this.txtCantidadDeButacasVentana.Size = new System.Drawing.Size(118, 20);
            this.txtCantidadDeButacasVentana.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Cantidad de Butacas V:";
            // 
            // dtFechaFueraDeServicio
            // 
            this.dtFechaFueraDeServicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFueraDeServicio.Location = new System.Drawing.Point(758, 65);
            this.dtFechaFueraDeServicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaFueraDeServicio.MaxDate = new System.DateTime(2050, 1, 25, 0, 0, 0, 0);
            this.dtFechaFueraDeServicio.MinDate = new System.DateTime(1990, 1, 25, 0, 0, 0, 0);
            this.dtFechaFueraDeServicio.Name = "dtFechaFueraDeServicio";
            this.dtFechaFueraDeServicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtFechaFueraDeServicio.ShowUpDown = true;
            this.dtFechaFueraDeServicio.Size = new System.Drawing.Size(121, 20);
            this.dtFechaFueraDeServicio.TabIndex = 65;
            this.dtFechaFueraDeServicio.Value = new System.DateTime(2015, 1, 25, 0, 0, 0, 0);
            // 
            // dtFechaDeReinicio
            // 
            this.dtFechaDeReinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDeReinicio.Location = new System.Drawing.Point(758, 97);
            this.dtFechaDeReinicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaDeReinicio.MaxDate = new System.DateTime(2050, 1, 25, 0, 0, 0, 0);
            this.dtFechaDeReinicio.MinDate = new System.DateTime(1990, 1, 25, 0, 0, 0, 0);
            this.dtFechaDeReinicio.Name = "dtFechaDeReinicio";
            this.dtFechaDeReinicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtFechaDeReinicio.ShowUpDown = true;
            this.dtFechaDeReinicio.Size = new System.Drawing.Size(121, 20);
            this.dtFechaDeReinicio.TabIndex = 63;
            this.dtFechaDeReinicio.Value = new System.DateTime(2015, 10, 16, 0, 0, 0, 0);
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(130, 56);
            this.dtpFechaAlta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaAlta.MaxDate = new System.DateTime(2050, 1, 25, 0, 0, 0, 0);
            this.dtpFechaAlta.MinDate = new System.DateTime(1990, 1, 25, 0, 0, 0, 0);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaAlta.ShowUpDown = true;
            this.dtpFechaAlta.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaAlta.TabIndex = 62;
            this.dtpFechaAlta.Value = new System.DateTime(2015, 1, 25, 0, 0, 0, 0);
            // 
            // txtCantidadDeKG
            // 
            this.txtCantidadDeKG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCantidadDeKG.Location = new System.Drawing.Point(433, 157);
            this.txtCantidadDeKG.Name = "txtCantidadDeKG";
            this.txtCantidadDeKG.Size = new System.Drawing.Size(118, 20);
            this.txtCantidadDeKG.TabIndex = 37;
            // 
            // txtCantidadDeButacasPasillo
            // 
            this.txtCantidadDeButacasPasillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCantidadDeButacasPasillo.Location = new System.Drawing.Point(433, 93);
            this.txtCantidadDeButacasPasillo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadDeButacasPasillo.Name = "txtCantidadDeButacasPasillo";
            this.txtCantidadDeButacasPasillo.Size = new System.Drawing.Size(118, 20);
            this.txtCantidadDeButacasPasillo.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(264, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 23);
            this.label16.TabIndex = 35;
            this.label16.Text = "Cantidad de Butacas P:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(574, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 23);
            this.label14.TabIndex = 32;
            this.label14.Text = "Fecha de reinicio  :";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(574, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 23);
            this.label12.TabIndex = 29;
            this.label12.Text = "Fecha fuera de servicio :";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(264, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tipo De Servicio :";
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMatricula.Location = new System.Drawing.Point(130, 162);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(121, 20);
            this.txtMatricula.TabIndex = 19;
            // 
            // txtNumeroAeronave
            // 
            this.txtNumeroAeronave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtNumeroAeronave.Enabled = false;
            this.txtNumeroAeronave.Location = new System.Drawing.Point(130, 92);
            this.txtNumeroAeronave.Name = "txtNumeroAeronave";
            this.txtNumeroAeronave.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroAeronave.TabIndex = 17;
            this.txtNumeroAeronave.TextChanged += new System.EventHandler(this.txtNumeroAeronave_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Numero :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Alta :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(433, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 50);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(38, 213);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(213, 84);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(302, 213);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 50);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fabricante :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Matricula  :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kg Disponible :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCodigo.Location = new System.Drawing.Point(130, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // CodigoAeronave
            // 
            this.CodigoAeronave.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoAeronave.Location = new System.Drawing.Point(38, 24);
            this.CodigoAeronave.Name = "CodigoAeronave";
            this.CodigoAeronave.Size = new System.Drawing.Size(72, 23);
            this.CodigoAeronave.TabIndex = 0;
            this.CodigoAeronave.Text = "Codigo :";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(893, 311);
            this.shapeContainer1.TabIndex = 72;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 557;
            this.lineShape1.X2 = 558;
            this.lineShape1.Y1 = -24;
            this.lineShape1.Y2 = 311;
            // 
            // ABMBajaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 395);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ABMBajaModificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja/Modificacion Aeronaves";
            this.Load += new System.EventHandler(this.ABMBajaModificacion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoAeronaves)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataListadoAeronaves;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnFiltroNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidadDeKG;
        private System.Windows.Forms.TextBox txtCantidadDeButacasPasillo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNumeroAeronave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label CodigoAeronave;
        private System.Windows.Forms.Button btnFiltroModelo;
        private System.Windows.Forms.Button btnFabricante;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.DateTimePicker dtFechaFueraDeServicio;
        private System.Windows.Forms.DateTimePicker dtFechaDeReinicio;
        private System.Windows.Forms.Button btnBajaLogica;
        private System.Windows.Forms.CheckBox checkBoxbajaLogica1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txtCantidadDeButacasVentana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbTipoDeServicio;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditarBFS;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;

    }
}