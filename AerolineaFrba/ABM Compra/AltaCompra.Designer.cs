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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.cantPasajes = new System.Windows.Forms.ComboBox();
            this.txtCantKG = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkPasajes = new System.Windows.Forms.CheckBox();
            this.chkEncomienda = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(22, 150);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(220, 21);
            this.cmbDestino.TabIndex = 17;
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
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(22, 93);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(220, 21);
            this.cmbOrigen.TabIndex = 13;
            // 
            // dtpFechaViaje
            // 
            this.dtpFechaViaje.Location = new System.Drawing.Point(22, 42);
            this.dtpFechaViaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaViaje.Name = "dtpFechaViaje";
            this.dtpFechaViaje.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaViaje.TabIndex = 12;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(786, 474);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(16, 253);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(242, 211);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(16, 16);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(241, 228);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(65, 195);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.RowTemplate.Height = 24;
            this.dgvCompra.Size = new System.Drawing.Size(512, 449);
            this.dgvCompra.TabIndex = 20;
            this.dgvCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellContentClick);
            // 
            // cantPasajes
            // 
            this.cantPasajes.FormattingEnabled = true;
            this.cantPasajes.Location = new System.Drawing.Point(145, 286);
            this.cantPasajes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cantPasajes.Name = "cantPasajes";
            this.cantPasajes.Size = new System.Drawing.Size(98, 21);
            this.cantPasajes.TabIndex = 21;
            // 
            // txtCantKG
            // 
            this.txtCantKG.Enabled = false;
            this.txtCantKG.Location = new System.Drawing.Point(188, 328);
            this.txtCantKG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantKG.Name = "txtCantKG";
            this.txtCantKG.Size = new System.Drawing.Size(54, 20);
            this.txtCantKG.TabIndex = 24;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(65, 362);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(141, 41);
            this.btnComprar.TabIndex = 25;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(65, 414);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 41);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkPasajes
            // 
            this.chkPasajes.AutoSize = true;
            this.chkPasajes.Location = new System.Drawing.Point(22, 288);
            this.chkPasajes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.chkEncomienda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEncomienda.Name = "chkEncomienda";
            this.chkEncomienda.Size = new System.Drawing.Size(164, 17);
            this.chkEncomienda.TabIndex = 28;
            this.chkEncomienda.Text = "Kgs a enviar por encomienda";
            this.chkEncomienda.UseVisualStyleBackColor = true;
            this.chkEncomienda.CheckedChanged += new System.EventHandler(this.chkEncomienda_CheckedChanged);
            // 
            // AltaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 474);
            this.Controls.Add(this.chkEncomienda);
            this.Controls.Add(this.chkPasajes);
            this.Controls.Add(this.btnCancelar);
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
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AltaCompra";
            this.Text = "Compra";
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
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.ComboBox cantPasajes;
        private System.Windows.Forms.TextBox txtCantKG;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCancelar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.CheckBox chkPasajes;
        private System.Windows.Forms.CheckBox chkEncomienda;
    }
}