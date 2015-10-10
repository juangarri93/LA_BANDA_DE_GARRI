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
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltroNumero = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataListadoAeronaves = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkBoxbajaLogica1 = new System.Windows.Forms.CheckBox();
            this.btnBajaLogica = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoAeronaves)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBajaLogica);
            this.tabPage1.Controls.Add(this.checkBoxbajaLogica1);
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
            // btnFiltroNumero
            // 
            this.btnFiltroNumero.Location = new System.Drawing.Point(285, 14);
            this.btnFiltroNumero.Name = "btnFiltroNumero";
            this.btnFiltroNumero.Size = new System.Drawing.Size(104, 23);
            this.btnFiltroNumero.TabIndex = 7;
            this.btnFiltroNumero.Text = "Filtrar";
            this.btnFiltroNumero.Click += new System.EventHandler(this.btnFiltroNumero_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(68, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(188, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Baja Logica";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 69;
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
            // checkBoxbajaLogica1
            // 
            this.checkBoxbajaLogica1.AutoSize = true;
            this.checkBoxbajaLogica1.Location = new System.Drawing.Point(9, 59);
            this.checkBoxbajaLogica1.Name = "checkBoxbajaLogica1";
            this.checkBoxbajaLogica1.Size = new System.Drawing.Size(82, 17);
            this.checkBoxbajaLogica1.TabIndex = 10;
            this.checkBoxbajaLogica1.Text = "Baja Logica";
            this.checkBoxbajaLogica1.UseVisualStyleBackColor = true;
            // 
            // btnBajaLogica
            // 
            this.btnBajaLogica.Location = new System.Drawing.Point(161, 55);
            this.btnBajaLogica.Name = "btnBajaLogica";
            this.btnBajaLogica.Size = new System.Drawing.Size(104, 23);
            this.btnBajaLogica.TabIndex = 11;
            this.btnBajaLogica.Text = "Baja Logica";
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
            this.ClientSize = new System.Drawing.Size(932, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "ABMCiudadBajaModif";
            this.Text = "ABMCiudadBajaModif";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoAeronaves)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBajaLogica;
        private System.Windows.Forms.CheckBox checkBoxbajaLogica1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataListadoCiudades;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnFiltroNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;


    }
}