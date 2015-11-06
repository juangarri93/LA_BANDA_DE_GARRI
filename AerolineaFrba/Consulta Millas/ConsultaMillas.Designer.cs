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
            this.filtrarDNI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMillas)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrarDNI
            // 
            this.filtrarDNI.Controls.Add(this.btnConsultarMillas);
            this.filtrarDNI.Controls.Add(this.txtDni);
            this.filtrarDNI.Controls.Add(this.lDni);
            this.filtrarDNI.Location = new System.Drawing.Point(35, 29);
            this.filtrarDNI.Margin = new System.Windows.Forms.Padding(4);
            this.filtrarDNI.Name = "filtrarDNI";
            this.filtrarDNI.Padding = new System.Windows.Forms.Padding(4);
            this.filtrarDNI.Size = new System.Drawing.Size(710, 86);
            this.filtrarDNI.TabIndex = 6;
            this.filtrarDNI.TabStop = false;
            this.filtrarDNI.Text = "Ingrese DNI";
            // 
            // btnConsultarMillas
            // 
            this.btnConsultarMillas.Location = new System.Drawing.Point(547, 34);
            this.btnConsultarMillas.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarMillas.Name = "btnConsultarMillas";
            this.btnConsultarMillas.Size = new System.Drawing.Size(116, 32);
            this.btnConsultarMillas.TabIndex = 7;
            this.btnConsultarMillas.Text = "Consultar Millas";
            this.btnConsultarMillas.UseVisualStyleBackColor = true;
            this.btnConsultarMillas.Click += new System.EventHandler(this.btnConsultarMillas_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(157, 39);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(353, 22);
            this.txtDni.TabIndex = 1;
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Location = new System.Drawing.Point(103, 39);
            this.lDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(31, 17);
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
            this.dtvMillas.Location = new System.Drawing.Point(35, 123);
            this.dtvMillas.Margin = new System.Windows.Forms.Padding(4);
            this.dtvMillas.MultiSelect = false;
            this.dtvMillas.Name = "dtvMillas";
            this.dtvMillas.ReadOnly = true;
            this.dtvMillas.Size = new System.Drawing.Size(710, 306);
            this.dtvMillas.TabIndex = 7;
            // 
            // lTotalViajes
            // 
            this.lTotalViajes.AutoSize = true;
            this.lTotalViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalViajes.Location = new System.Drawing.Point(31, 452);
            this.lTotalViajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTotalViajes.Name = "lTotalViajes";
            this.lTotalViajes.Size = new System.Drawing.Size(125, 20);
            this.lTotalViajes.TabIndex = 8;
            this.lTotalViajes.Text = "Total de Viajes:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(510, 465);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 39);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(634, 465);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 39);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lMillas
            // 
            this.lMillas.AutoSize = true;
            this.lMillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMillas.Location = new System.Drawing.Point(31, 484);
            this.lMillas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMillas.Name = "lMillas";
            this.lMillas.Size = new System.Drawing.Size(123, 20);
            this.lMillas.TabIndex = 12;
            this.lMillas.Text = "Total de Millas:";
            // 
            // ConsultaMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 527);
            this.Controls.Add(this.lMillas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lTotalViajes);
            this.Controls.Add(this.dtvMillas);
            this.Controls.Add(this.filtrarDNI);
            this.Name = "ConsultaMillas";
            this.Text = "Consulta de Millas";
            this.filtrarDNI.ResumeLayout(false);
            this.filtrarDNI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMillas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}