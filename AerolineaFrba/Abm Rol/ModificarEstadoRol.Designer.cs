namespace AerolineaFrba.Abm_Rol
{
    partial class ModificarEstadoRol
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
            this.dgRolesEstado = new System.Windows.Forms.DataGridView();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRolesEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRolesEstado
            // 
            this.dgRolesEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgRolesEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRolesEstado.Enabled = false;
            this.dgRolesEstado.Location = new System.Drawing.Point(89, 12);
            this.dgRolesEstado.Name = "dgRolesEstado";
            this.dgRolesEstado.ReadOnly = true;
            this.dgRolesEstado.Size = new System.Drawing.Size(368, 181);
            this.dgRolesEstado.TabIndex = 0;
            this.dgRolesEstado.DoubleClick += new System.EventHandler(this.dgRolesEstado_DoubleClick);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(89, 274);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(133, 36);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(324, 274);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(133, 36);
            this.btVolver.TabIndex = 2;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // ModificarEstadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 322);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.dgRolesEstado);
            this.Name = "ModificarEstadoRol";
            this.Text = "ModificarEstadoRol";
            this.Load += new System.EventHandler(this.ModificarEstadoRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRolesEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgRolesEstado;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;


    }
}