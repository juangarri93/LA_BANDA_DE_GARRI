namespace AerolineaFrba.Devolucion
{
    partial class LiberacionDeKGs
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
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroDeCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncomienda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 23);
            this.label7.TabIndex = 65;
            this.label7.Text = "Fecha Devolucion :";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(192, 35);
            this.dtpFechaDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDevolucion.MaxDate = new System.DateTime(2050, 1, 25, 0, 0, 0, 0);
            this.dtpFechaDevolucion.MinDate = new System.DateTime(1990, 1, 25, 0, 0, 0, 0);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaDevolucion.ShowUpDown = true;
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(156, 20);
            this.dtpFechaDevolucion.TabIndex = 66;
            this.dtpFechaDevolucion.Value = new System.DateTime(2015, 1, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nro De Compra/PNR :";
            // 
            // txtNroDeCompra
            // 
            this.txtNroDeCompra.Location = new System.Drawing.Point(192, 89);
            this.txtNroDeCompra.Name = "txtNroDeCompra";
            this.txtNroDeCompra.Size = new System.Drawing.Size(156, 20);
            this.txtNroDeCompra.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "Motivo de la Cancelacion :";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(227, 193);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(296, 102);
            this.txtMotivo.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nro De Encomienda :";
            // 
            // txtEncomienda
            // 
            this.txtEncomienda.Location = new System.Drawing.Point(192, 138);
            this.txtEncomienda.Name = "txtEncomienda";
            this.txtEncomienda.Size = new System.Drawing.Size(156, 20);
            this.txtEncomienda.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 45);
            this.button1.TabIndex = 73;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 45);
            this.button2.TabIndex = 74;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LiberacionDeKGs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 386);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEncomienda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNroDeCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaDevolucion);
            this.Controls.Add(this.label7);
            this.Name = "LiberacionDeKGs";
            this.Text = "LiberacionDeKGs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroDeCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncomienda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}