namespace AerolineaFrba.Devolucion
{
    partial class DevolverPasaje
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
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroDeCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnBuscarNroDeCompra = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(188, 26);
            this.dtpFechaDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDevolucion.MaxDate = new System.DateTime(2050, 1, 25, 0, 0, 0, 0);
            this.dtpFechaDevolucion.MinDate = new System.DateTime(1990, 1, 25, 0, 0, 0, 0);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaDevolucion.ShowUpDown = true;
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(156, 20);
            this.dtpFechaDevolucion.TabIndex = 63;
            this.dtpFechaDevolucion.Value = new System.DateTime(2015, 1, 25, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 23);
            this.label7.TabIndex = 64;
            this.label7.Text = "Fecha Devolucion :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 65;
            this.label1.Text = "Nro De Compra/PNR :";
            // 
            // txtNroDeCompra
            // 
            this.txtNroDeCompra.Location = new System.Drawing.Point(188, 73);
            this.txtNroDeCompra.Name = "txtNroDeCompra";
            this.txtNroDeCompra.Size = new System.Drawing.Size(156, 20);
            this.txtNroDeCompra.TabIndex = 66;
            this.txtNroDeCompra.TextChanged += new System.EventHandler(this.txtNroDeCompra_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Motivo de la Cancelacion :";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(230, 120);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(296, 102);
            this.txtMotivo.TabIndex = 68;
            // 
            // btnBuscarNroDeCompra
            // 
            this.btnBuscarNroDeCompra.Location = new System.Drawing.Point(45, 248);
            this.btnBuscarNroDeCompra.Name = "btnBuscarNroDeCompra";
            this.btnBuscarNroDeCompra.Size = new System.Drawing.Size(189, 46);
            this.btnBuscarNroDeCompra.TabIndex = 69;
            this.btnBuscarNroDeCompra.Text = "Ver Pasajes";
            this.btnBuscarNroDeCompra.UseVisualStyleBackColor = true;
            this.btnBuscarNroDeCompra.Click += new System.EventHandler(this.btnBuscarNroDeCompra_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 46);
            this.button1.TabIndex = 70;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DevolverPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarNroDeCompra);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNroDeCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaDevolucion);
            this.Name = "DevolverPasaje";
            this.Text = "DevolverPasaje";
            this.Load += new System.EventHandler(this.DevolverPasaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroDeCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnBuscarNroDeCompra;
        private System.Windows.Forms.Button button1;
    }
}