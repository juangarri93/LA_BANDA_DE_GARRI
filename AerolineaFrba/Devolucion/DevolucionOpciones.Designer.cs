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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDevolverPasaje
            // 
            this.btnDevolverPasaje.Enabled = false;
            this.btnDevolverPasaje.Location = new System.Drawing.Point(42, 46);
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
            this.btnLiberacionDeKGs.Location = new System.Drawing.Point(270, 46);
            this.btnLiberacionDeKGs.Name = "btnLiberacionDeKGs";
            this.btnLiberacionDeKGs.Size = new System.Drawing.Size(162, 61);
            this.btnLiberacionDeKGs.TabIndex = 14;
            this.btnLiberacionDeKGs.Text = "Liberacion De KGs";
            this.btnLiberacionDeKGs.UseVisualStyleBackColor = true;
            this.btnLiberacionDeKGs.Click += new System.EventHandler(this.btnLiberacionDeKGs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 61);
            this.button1.TabIndex = 15;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DevolucionOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 205);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;

    }
}