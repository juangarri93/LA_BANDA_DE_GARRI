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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRutaAerea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerarViaje = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAeronave = new System.Windows.Forms.ComboBox();
            this.dtFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtFechaLLegada = new System.Windows.Forms.DateTimePicker();
            this.dtFechaLLegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 65;
            this.label1.Text = "Fecha Salida :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 37);
            this.label2.TabIndex = 66;
            this.label2.Text = "Fecha Llegada :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 65);
            this.label3.TabIndex = 67;
            this.label3.Text = "Fecha Llegada Estimada :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 37);
            this.label5.TabIndex = 70;
            this.label5.Text = "Ruta Aerea  :";
            // 
            // cbRutaAerea
            // 
            this.cbRutaAerea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRutaAerea.FormattingEnabled = true;
            this.cbRutaAerea.Location = new System.Drawing.Point(187, 290);
            this.cbRutaAerea.Margin = new System.Windows.Forms.Padding(4);
            this.cbRutaAerea.Name = "cbRutaAerea";
            this.cbRutaAerea.Size = new System.Drawing.Size(200, 24);
            this.cbRutaAerea.TabIndex = 71;
            this.cbRutaAerea.SelectedIndexChanged += new System.EventHandler(this.cbRutaAerea_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 37);
            this.label6.TabIndex = 72;
            this.label6.Text = "Generar Viaje ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(21, 418);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 42);
            this.btnCancelar.TabIndex = 73;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerarViaje
            // 
            this.btnGenerarViaje.Location = new System.Drawing.Point(211, 418);
            this.btnGenerarViaje.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarViaje.Name = "btnGenerarViaje";
            this.btnGenerarViaje.Size = new System.Drawing.Size(176, 42);
            this.btnGenerarViaje.TabIndex = 75;
            this.btnGenerarViaje.Text = "Generar Viaje";
            this.btnGenerarViaje.UseVisualStyleBackColor = true;
            this.btnGenerarViaje.Click += new System.EventHandler(this.btnGenerarViaje_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 37);
            this.label4.TabIndex = 79;
            this.label4.Text = "Aeronave :";
            // 
            // cbAeronave
            // 
            this.cbAeronave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAeronave.FormattingEnabled = true;
            this.cbAeronave.Location = new System.Drawing.Point(187, 351);
            this.cbAeronave.Margin = new System.Windows.Forms.Padding(4);
            this.cbAeronave.Name = "cbAeronave";
            this.cbAeronave.Size = new System.Drawing.Size(200, 24);
            this.cbAeronave.TabIndex = 80;
            this.cbAeronave.SelectedIndexChanged += new System.EventHandler(this.cbAeronave_SelectedIndexChanged);
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaSalida.Location = new System.Drawing.Point(240, 95);
            this.dtFechaSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.Size = new System.Drawing.Size(110, 22);
            this.dtFechaSalida.TabIndex = 86;
            // 
            // dtFechaLLegada
            // 
            this.dtFechaLLegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaLLegada.Location = new System.Drawing.Point(240, 165);
            this.dtFechaLLegada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaLLegada.Name = "dtFechaLLegada";
            this.dtFechaLLegada.Size = new System.Drawing.Size(110, 22);
            this.dtFechaLLegada.TabIndex = 87;
            // 
            // dtFechaLLegadaEstimada
            // 
            this.dtFechaLLegadaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaLLegadaEstimada.Location = new System.Drawing.Point(240, 230);
            this.dtFechaLLegadaEstimada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaLLegadaEstimada.Name = "dtFechaLLegadaEstimada";
            this.dtFechaLLegadaEstimada.Size = new System.Drawing.Size(110, 22);
            this.dtFechaLLegadaEstimada.TabIndex = 88;
            // 
            // GenerarViaje
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(418, 485);
            this.Controls.Add(this.dtFechaLLegadaEstimada);
            this.Controls.Add(this.dtFechaLLegada);
            this.Controls.Add(this.dtFechaSalida);
            this.Controls.Add(this.cbAeronave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerarViaje);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbRutaAerea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerarViaje";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GenerarViaje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRutaAerea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerarViaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAeronave;
        private System.Windows.Forms.DateTimePicker dtFechaSalida;
        private System.Windows.Forms.DateTimePicker dtFechaLLegada;
        private System.Windows.Forms.DateTimePicker dtFechaLLegadaEstimada;
    }
}