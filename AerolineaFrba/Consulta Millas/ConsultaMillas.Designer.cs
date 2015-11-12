﻿namespace AerolineaFrba.Consulta_Millas
{
    partial class ConsultaMillas
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
            this.filtrarDNI = new System.Windows.Forms.GroupBox();
            this.btnConsultarMillas = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lDni = new System.Windows.Forms.Label();
            this.dtvMillas = new System.Windows.Forms.DataGridView();
            this.lTotalViajes = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lMillas = new System.Windows.Forms.Label();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filtrarDNI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMillas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtrarDNI
            // 
            this.filtrarDNI.Controls.Add(this.btnConsultarMillas);
            this.filtrarDNI.Controls.Add(this.txtDni);
            this.filtrarDNI.Controls.Add(this.lDni);
            this.filtrarDNI.Location = new System.Drawing.Point(26, 24);
            this.filtrarDNI.Name = "filtrarDNI";
            this.filtrarDNI.Size = new System.Drawing.Size(532, 70);
            this.filtrarDNI.TabIndex = 6;
            this.filtrarDNI.TabStop = false;
            this.filtrarDNI.Text = "Ingrese DNI";
            // 
            // btnConsultarMillas
            // 
            this.btnConsultarMillas.Location = new System.Drawing.Point(410, 28);
            this.btnConsultarMillas.Name = "btnConsultarMillas";
            this.btnConsultarMillas.Size = new System.Drawing.Size(87, 26);
            this.btnConsultarMillas.TabIndex = 7;
            this.btnConsultarMillas.Text = "Consultar Millas";
            this.btnConsultarMillas.UseVisualStyleBackColor = true;
            this.btnConsultarMillas.Click += new System.EventHandler(this.btnConsultarMillas_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(118, 32);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(266, 20);
            this.txtDni.TabIndex = 1;
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Location = new System.Drawing.Point(77, 32);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(26, 13);
            this.lDni.TabIndex = 0;
            this.lDni.Text = "DNI";
            // 
            // dtvMillas
            // 
            this.dtvMillas.AllowUserToAddRows = false;
            this.dtvMillas.AllowUserToDeleteRows = false;
            this.dtvMillas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvMillas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvMillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMillas.Location = new System.Drawing.Point(26, 100);
            this.dtvMillas.MultiSelect = false;
            this.dtvMillas.Name = "dtvMillas";
            this.dtvMillas.ReadOnly = true;
            this.dtvMillas.Size = new System.Drawing.Size(532, 249);
            this.dtvMillas.TabIndex = 7;
            // 
            // lTotalViajes
            // 
            this.lTotalViajes.AutoSize = true;
            this.lTotalViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalViajes.Location = new System.Drawing.Point(8, 23);
            this.lTotalViajes.Name = "lTotalViajes";
            this.lTotalViajes.Size = new System.Drawing.Size(102, 16);
            this.lTotalViajes.TabIndex = 8;
            this.lTotalViajes.Text = "Total de Viajes:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(247, 23);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 32);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(425, 23);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 32);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lMillas
            // 
            this.lMillas.AutoSize = true;
            this.lMillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMillas.Location = new System.Drawing.Point(8, 43);
            this.lMillas.Name = "lMillas";
            this.lMillas.Size = new System.Drawing.Size(99, 16);
            this.lMillas.TabIndex = 12;
            this.lMillas.Text = "Total de Millas:";
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(336, 23);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(83, 32);
            this.btnCanjear.TabIndex = 13;
            this.btnCanjear.Text = "Canjear Millas";
            this.btnCanjear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lMillas);
            this.groupBox1.Controls.Add(this.btnCanjear);
            this.groupBox1.Controls.Add(this.lTotalViajes);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Location = new System.Drawing.Point(26, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 70);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sus Millas";
            // 
            // ConsultaMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtvMillas);
            this.Controls.Add(this.filtrarDNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultaMillas";
            this.Text = "Consulta de Millas";
            this.filtrarDNI.ResumeLayout(false);
            this.filtrarDNI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMillas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filtrarDNI;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.Button btnConsultarMillas;
        private System.Windows.Forms.DataGridView dtvMillas;
        private System.Windows.Forms.Label lTotalViajes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lMillas;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}