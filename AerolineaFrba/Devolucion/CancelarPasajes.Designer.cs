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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtViaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtButaca = new System.Windows.Forms.TextBox();
            this.btnCancelarPasajes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtButacasCompradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtButacasCompradas
            // 
            this.dtButacasCompradas.AllowUserToAddRows = false;
            this.dtButacasCompradas.AllowUserToDeleteRows = false;
            this.dtButacasCompradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtButacasCompradas.Location = new System.Drawing.Point(25, 12);
            this.dtButacasCompradas.Name = "dtButacasCompradas";
            this.dtButacasCompradas.ReadOnly = true;
            this.dtButacasCompradas.Size = new System.Drawing.Size(442, 189);
            this.dtButacasCompradas.TabIndex = 0;
            this.dtButacasCompradas.DoubleClick += new System.EventHandler(this.dtButacasCompradas_DoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(630, 12);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Viaje:";
            // 
            // txtViaje
            // 
            this.txtViaje.Location = new System.Drawing.Point(630, 66);
            this.txtViaje.Multiline = true;
            this.txtViaje.Name = "txtViaje";
            this.txtViaje.Size = new System.Drawing.Size(100, 23);
            this.txtViaje.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Butaca:";
            // 
            // txtButaca
            // 
            this.txtButaca.Location = new System.Drawing.Point(630, 120);
            this.txtButaca.Multiline = true;
            this.txtButaca.Name = "txtButaca";
            this.txtButaca.Size = new System.Drawing.Size(100, 23);
            this.txtButaca.TabIndex = 6;
            // 
            // btnCancelarPasajes
            // 
            this.btnCancelarPasajes.Location = new System.Drawing.Point(530, 229);
            this.btnCancelarPasajes.Name = "btnCancelarPasajes";
            this.btnCancelarPasajes.Size = new System.Drawing.Size(96, 39);
            this.btnCancelarPasajes.TabIndex = 9;
            this.btnCancelarPasajes.Text = "Cancelar Pasaje/s";
            this.btnCancelarPasajes.UseVisualStyleBackColor = true;
            this.btnCancelarPasajes.Click += new System.EventHandler(this.btnCancelarPasajes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CancelarPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelarPasajes);
            this.Controls.Add(this.txtButaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtViaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtButacasCompradas);
            this.Name = "CancelarPasajes";
            this.Text = "CancelarPasajes";
            this.Load += new System.EventHandler(this.CancelarPasajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtButacasCompradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtButacasCompradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtViaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtButaca;
        private System.Windows.Forms.Button btnCancelarPasajes;
        private System.Windows.Forms.Button button2;


    }
}