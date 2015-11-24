namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class Registro
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
            this.lMatricula = new System.Windows.Forms.Label();
            this.filtrarMatricula = new System.Windows.Forms.GroupBox();
            this.btnConsultarMatr = new System.Windows.Forms.Button();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpHorario = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.filtrarMatricula.SuspendLayout();
            this.SuspendLayout();
            // 
            // lMatricula
            // 
            this.lMatricula.AutoSize = true;
            this.lMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lMatricula.Location = new System.Drawing.Point(17, 30);
            this.lMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMatricula.Name = "lMatricula";
            this.lMatricula.Size = new System.Drawing.Size(78, 20);
            this.lMatricula.TabIndex = 0;
            this.lMatricula.Text = "Matrícula";
            // 
            // filtrarMatricula
            // 
            this.filtrarMatricula.Controls.Add(this.btnConsultarMatr);
            this.filtrarMatricula.Controls.Add(this.cbOrigen);
            this.filtrarMatricula.Controls.Add(this.cbDestino);
            this.filtrarMatricula.Controls.Add(this.label4);
            this.filtrarMatricula.Controls.Add(this.txtMatricula);
            this.filtrarMatricula.Controls.Add(this.label3);
            this.filtrarMatricula.Controls.Add(this.lMatricula);
            this.filtrarMatricula.Location = new System.Drawing.Point(13, 13);
            this.filtrarMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.filtrarMatricula.Name = "filtrarMatricula";
            this.filtrarMatricula.Padding = new System.Windows.Forms.Padding(4);
            this.filtrarMatricula.Size = new System.Drawing.Size(477, 208);
            this.filtrarMatricula.TabIndex = 13;
            this.filtrarMatricula.TabStop = false;
            this.filtrarMatricula.Text = "Ingrese Matrícula, Origen y Destino";
            this.filtrarMatricula.Enter += new System.EventHandler(this.filtrarMatricula_Enter);
            // 
            // btnConsultarMatr
            // 
            this.btnConsultarMatr.Location = new System.Drawing.Point(21, 154);
            this.btnConsultarMatr.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarMatr.Name = "btnConsultarMatr";
            this.btnConsultarMatr.Size = new System.Drawing.Size(437, 32);
            this.btnConsultarMatr.TabIndex = 7;
            this.btnConsultarMatr.Text = "Consultar Matrícula";
            this.btnConsultarMatr.UseVisualStyleBackColor = true;
            this.btnConsultarMatr.Click += new System.EventHandler(this.btnConsultarMatr_Click);
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(188, 69);
            this.cbOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(281, 24);
            this.cbOrigen.TabIndex = 30;
            this.cbOrigen.SelectedIndexChanged += new System.EventHandler(this.cbOrigen_SelectedIndexChanged);
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(188, 109);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(281, 24);
            this.cbDestino.TabIndex = 31;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ciudad de destino:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(188, 28);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(281, 22);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ciudad de origen:";
            // 
            // tpHorario
            // 
            this.tpHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpHorario.Location = new System.Drawing.Point(209, 286);
            this.tpHorario.Margin = new System.Windows.Forms.Padding(4);
            this.tpHorario.Name = "tpHorario";
            this.tpHorario.ShowUpDown = true;
            this.tpHorario.Size = new System.Drawing.Size(281, 22);
            this.tpHorario.TabIndex = 32;
            this.tpHorario.Value = new System.DateTime(2015, 11, 23, 22, 47, 27, 0);
            this.tpHorario.ValueChanged += new System.EventHandler(this.tpHorario_ValueChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(25, 339);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 41);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(190, 338);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 42);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(362, 338);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(109, 43);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Horario de arrivo:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Location = new System.Drawing.Point(209, 238);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.MinDate = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(281, 22);
            this.dtpFecha.TabIndex = 23;
            this.dtpFecha.Value = new System.DateTime(2015, 11, 23, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha de arrivo:";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 394);
            this.Controls.Add(this.tpHorario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtrarMatricula);
            this.Name = "Registro";
            this.Text = "Registro de llegada a destino";
            this.filtrarMatricula.ResumeLayout(false);
            this.filtrarMatricula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMatricula;
        private System.Windows.Forms.GroupBox filtrarMatricula;
        private System.Windows.Forms.Button btnConsultarMatr;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.DateTimePicker tpHorario;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;


    }
}