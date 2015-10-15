namespace AerolineaFrba.Generacion_Viaje
{
    partial class GenerarViaje
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
            this.dtFechaLLegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.dtFechaLLegada = new System.Windows.Forms.DateTimePicker();
            this.dtFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRutaAerea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerarViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtFechaLLegadaEstimada
            // 
            this.dtFechaLLegadaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaLLegadaEstimada.Location = new System.Drawing.Point(267, 189);
            this.dtFechaLLegadaEstimada.MaxDate = new System.DateTime(2050, 1, 25, 23, 59, 0, 0);
            this.dtFechaLLegadaEstimada.MinDate = new System.DateTime(2015, 1, 25, 23, 59, 0, 0);
            this.dtFechaLLegadaEstimada.Name = "dtFechaLLegadaEstimada";
            this.dtFechaLLegadaEstimada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtFechaLLegadaEstimada.ShowUpDown = true;
            this.dtFechaLLegadaEstimada.Size = new System.Drawing.Size(121, 20);
            this.dtFechaLLegadaEstimada.TabIndex = 62;
            this.dtFechaLLegadaEstimada.Value = new System.DateTime(2015, 1, 25, 23, 59, 0, 0);
            // 
            // dtFechaLLegada
            // 
            this.dtFechaLLegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaLLegada.Location = new System.Drawing.Point(267, 133);
            this.dtFechaLLegada.MaxDate = new System.DateTime(2050, 1, 25, 23, 59, 0, 0);
            this.dtFechaLLegada.MinDate = new System.DateTime(2015, 1, 25, 23, 59, 0, 0);
            this.dtFechaLLegada.Name = "dtFechaLLegada";
            this.dtFechaLLegada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtFechaLLegada.ShowUpDown = true;
            this.dtFechaLLegada.Size = new System.Drawing.Size(121, 20);
            this.dtFechaLLegada.TabIndex = 63;
            this.dtFechaLLegada.Value = new System.DateTime(2015, 1, 25, 23, 59, 0, 0);
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaSalida.Location = new System.Drawing.Point(267, 77);
            this.dtFechaSalida.MaxDate = new System.DateTime(2050, 1, 25, 23, 59, 0, 0);
            this.dtFechaSalida.MinDate = new System.DateTime(2015, 1, 25, 23, 59, 0, 0);
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtFechaSalida.ShowUpDown = true;
            this.dtFechaSalida.Size = new System.Drawing.Size(121, 20);
            this.dtFechaSalida.TabIndex = 64;
            this.dtFechaSalida.Value = new System.DateTime(2015, 1, 25, 23, 59, 0, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 65;
            this.label1.Text = "Fecha Salida :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 30);
            this.label2.TabIndex = 66;
            this.label2.Text = "Fecha Llegada :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 30);
            this.label3.TabIndex = 67;
            this.label3.Text = "Fecha Llegada Estimada :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 30);
            this.label5.TabIndex = 70;
            this.label5.Text = "Ruta Aerea  :";
            // 
            // cbRutaAerea
            // 
            this.cbRutaAerea.FormattingEnabled = true;
            this.cbRutaAerea.Location = new System.Drawing.Point(267, 245);
            this.cbRutaAerea.Name = "cbRutaAerea";
            this.cbRutaAerea.Size = new System.Drawing.Size(121, 21);
            this.cbRutaAerea.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 30);
            this.label6.TabIndex = 72;
            this.label6.Text = "Generar Viaje ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(477, 119);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 34);
            this.btnCancelar.TabIndex = 73;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 74;
            this.button1.Text = "Buscar Aeronave";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGenerarViaje
            // 
            this.btnGenerarViaje.Location = new System.Drawing.Point(477, 198);
            this.btnGenerarViaje.Name = "btnGenerarViaje";
            this.btnGenerarViaje.Size = new System.Drawing.Size(132, 34);
            this.btnGenerarViaje.TabIndex = 75;
            this.btnGenerarViaje.Text = "Generar Viaje";
            this.btnGenerarViaje.UseVisualStyleBackColor = true;
            // 
            // GenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 356);
            this.Controls.Add(this.btnGenerarViaje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbRutaAerea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaSalida);
            this.Controls.Add(this.dtFechaLLegada);
            this.Controls.Add(this.dtFechaLLegadaEstimada);
            this.Name = "GenerarViaje";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GenerarViaje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaLLegadaEstimada;
        private System.Windows.Forms.DateTimePicker dtFechaLLegada;
        private System.Windows.Forms.DateTimePicker dtFechaSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRutaAerea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerarViaje;
    }
}