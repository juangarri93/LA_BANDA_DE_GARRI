namespace AerolineaFrba.ABM_Compra
{
    partial class Butacas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acá va lo de seleccionar butacas......";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(242, 504);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(136, 47);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(386, 504);
            this.btnPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(137, 47);
            this.btnPago.TabIndex = 4;
            this.btnPago.Text = "Pagar";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // Butacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 592);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "Butacas";
            this.Text = "Butacas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnPago;
    }
}