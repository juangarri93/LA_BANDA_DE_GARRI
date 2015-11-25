namespace AerolineaFrba.Abm_Compra
{
    partial class AltaCompra
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
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.dtpFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.cantPasajes = new System.Windows.Forms.ComboBox();
            this.txtCantKG = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.chkPasajes = new System.Windows.Forms.CheckBox();
            this.chkEncomienda = new System.Windows.Forms.CheckBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblViaje = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(22, 150);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(220, 21);
            this.cmbDestino.TabIndex = 17;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ciudad de destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ciudad de origen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha de viaje";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(22, 93);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(220, 21);
            this.cmbOrigen.TabIndex = 13;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // dtpFechaViaje
            // 
            this.dtpFechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaViaje.Location = new System.Drawing.Point(22, 42);
            this.dtpFechaViaje.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaViaje.Name = "dtpFechaViaje";
            this.dtpFechaViaje.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaViaje.TabIndex = 12;
            this.dtpFechaViaje.ValueChanged += new System.EventHandler(this.dtpFechaViaje_ValueChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(65, 236);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 39);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // dgvCompra
            // 
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(266, 16);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.RowTemplate.Height = 24;
            this.dgvCompra.Size = new System.Drawing.Size(512, 449);
            this.dgvCompra.TabIndex = 20;
            this.dgvCompra.DoubleClick += new System.EventHandler(this.dgvCompra_DoubleClick);
            // 
            // cantPasajes
            // 
            this.cantPasajes.FormattingEnabled = true;
            this.cantPasajes.Location = new System.Drawing.Point(145, 286);
            this.cantPasajes.Margin = new System.Windows.Forms.Padding(2);
            this.cantPasajes.Name = "cantPasajes";
            this.cantPasajes.Size = new System.Drawing.Size(98, 21);
            this.cantPasajes.TabIndex = 21;
            this.cantPasajes.SelectedIndexChanged += new System.EventHandler(this.cantPasajes_SelectedIndexChanged);
            // 
            // txtCantKG
            // 
            this.txtCantKG.Enabled = false;
            this.txtCantKG.Location = new System.Drawing.Point(188, 328);
            this.txtCantKG.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantKG.Name = "txtCantKG";
            this.txtCantKG.Size = new System.Drawing.Size(54, 20);
            this.txtCantKG.TabIndex = 24;
            this.txtCantKG.TextChanged += new System.EventHandler(this.txtCantKG_TextChanged);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(65, 362);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(141, 41);
            this.btnComprar.TabIndex = 25;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // chkPasajes
            // 
            this.chkPasajes.AutoSize = true;
            this.chkPasajes.Location = new System.Drawing.Point(22, 288);
            this.chkPasajes.Margin = new System.Windows.Forms.Padding(2);
            this.chkPasajes.Name = "chkPasajes";
            this.chkPasajes.Size = new System.Drawing.Size(113, 17);
            this.chkPasajes.TabIndex = 27;
            this.chkPasajes.Text = "Pasajes a comprar";
            this.chkPasajes.UseVisualStyleBackColor = true;
            this.chkPasajes.CheckedChanged += new System.EventHandler(this.chkPasajes_CheckedChanged);
            // 
            // chkEncomienda
            // 
            this.chkEncomienda.AutoSize = true;
            this.chkEncomienda.Location = new System.Drawing.Point(22, 328);
            this.chkEncomienda.Margin = new System.Windows.Forms.Padding(2);
            this.chkEncomienda.Name = "chkEncomienda";
            this.chkEncomienda.Size = new System.Drawing.Size(164, 17);
            this.chkEncomienda.TabIndex = 28;
            this.chkEncomienda.Text = "Kgs a enviar por encomienda";
            this.chkEncomienda.UseVisualStyleBackColor = true;
            this.chkEncomienda.CheckedChanged += new System.EventHandler(this.chkEncomienda_CheckedChanged);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(23, 185);
            this.lblSeleccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(101, 13);
            this.lblSeleccion.TabIndex = 29;
            this.lblSeleccion.Text = "Viajes Encontrados:";
            // 
            // lblViaje
            // 
            this.lblViaje.AutoSize = true;
            this.lblViaje.Location = new System.Drawing.Point(23, 213);
            this.lblViaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViaje.Name = "lblViaje";
            this.lblViaje.Size = new System.Drawing.Size(71, 13);
            this.lblViaje.TabIndex = 30;
            this.lblViaje.Text = "Viaje número:";
            this.lblViaje.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(65, 414);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(141, 48);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // AltaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 474);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblViaje);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.chkEncomienda);
            this.Controls.Add(this.chkPasajes);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtCantKG);
            this.Controls.Add(this.cantPasajes);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.dtpFechaViaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.AltaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.DateTimePicker dtpFechaViaje;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.ComboBox cantPasajes;
        private System.Windows.Forms.TextBox txtCantKG;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.CheckBox chkPasajes;
        private System.Windows.Forms.CheckBox chkEncomienda;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblViaje;
        private System.Windows.Forms.Button btnVolver;
    }
}