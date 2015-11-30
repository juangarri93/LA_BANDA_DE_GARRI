namespace AerolineaFrba.Devolucion
{
    partial class CancelarPasajes
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
            this.dtButacasCompradas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtButacasCompradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtButacasCompradas
            // 
            this.dtButacasCompradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtButacasCompradas.Location = new System.Drawing.Point(35, 27);
            this.dtButacasCompradas.Name = "dtButacasCompradas";
            this.dtButacasCompradas.Size = new System.Drawing.Size(311, 189);
            this.dtButacasCompradas.TabIndex = 0;
            // 
            // CancelarPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 262);
            this.Controls.Add(this.dtButacasCompradas);
            this.Name = "CancelarPasajes";
            this.Text = "CancelarPasajes";
            ((System.ComponentModel.ISupportInitialize)(this.dtButacasCompradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtButacasCompradas;
    }
}