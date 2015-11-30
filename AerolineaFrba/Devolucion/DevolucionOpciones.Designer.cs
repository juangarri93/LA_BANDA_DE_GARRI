namespace AerolineaFrba.Devolucion
{
    partial class DevolucionOpciones
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
            this.btnDevolverPasaje = new System.Windows.Forms.Button();
            this.btnLiberacionDeKGs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDevolverPasaje
            // 
            this.btnDevolverPasaje.Enabled = false;
            this.btnDevolverPasaje.Location = new System.Drawing.Point(42, 86);
            this.btnDevolverPasaje.Name = "btnDevolverPasaje";
            this.btnDevolverPasaje.Size = new System.Drawing.Size(162, 61);
            this.btnDevolverPasaje.TabIndex = 13;
            this.btnDevolverPasaje.Text = "Devolver Pasaje/s";
            this.btnDevolverPasaje.UseVisualStyleBackColor = true;
            this.btnDevolverPasaje.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLiberacionDeKGs
            // 
            this.btnLiberacionDeKGs.Enabled = false;
            this.btnLiberacionDeKGs.Location = new System.Drawing.Point(270, 86);
            this.btnLiberacionDeKGs.Name = "btnLiberacionDeKGs";
            this.btnLiberacionDeKGs.Size = new System.Drawing.Size(162, 61);
            this.btnLiberacionDeKGs.TabIndex = 14;
            this.btnLiberacionDeKGs.Text = "Liberacion De KGs";
            this.btnLiberacionDeKGs.UseVisualStyleBackColor = true;
            this.btnLiberacionDeKGs.Click += new System.EventHandler(this.btnLiberacionDeKGs_Click);
            // 
            // DevolucionOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 235);
            this.Controls.Add(this.btnLiberacionDeKGs);
            this.Controls.Add(this.btnDevolverPasaje);
            this.Name = "DevolucionOpciones";
            this.Text = "DevolucionOpcion :";
            this.Load += new System.EventHandler(this.DevolucionOpciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDevolverPasaje;
        private System.Windows.Forms.Button btnLiberacionDeKGs;

    }
}