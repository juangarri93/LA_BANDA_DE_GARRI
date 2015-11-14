namespace AerolineaFrba.Abm_Rol
{
    partial class ModificarFuncionalidadParaUnRol
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
            this.Funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelMuestraNombre = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Funcionalidades
            // 
            this.Funcionalidades.FormattingEnabled = true;
            this.Funcionalidades.Location = new System.Drawing.Point(14, 17);
            this.Funcionalidades.Name = "Funcionalidades";
            this.Funcionalidades.Size = new System.Drawing.Size(257, 229);
            this.Funcionalidades.TabIndex = 19;
            this.Funcionalidades.SelectedIndexChanged += new System.EventHandler(this.Funcionalidades_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre Rol :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(299, 101);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 48);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelMuestraNombre
            // 
            this.labelMuestraNombre.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestraNombre.Location = new System.Drawing.Point(479, 17);
            this.labelMuestraNombre.Name = "labelMuestraNombre";
            this.labelMuestraNombre.Size = new System.Drawing.Size(161, 32);
            this.labelMuestraNombre.TabIndex = 22;
            this.labelMuestraNombre.Text = "Nombre Rol";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(485, 101);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 48);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ModificarFuncionalidadParaUnRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 262);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.labelMuestraNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Funcionalidades);
            this.Name = "ModificarFuncionalidadParaUnRol";
            this.Text = "ModificarFuncionalidadParaUnRol";
            this.Load += new System.EventHandler(this.ModificarFuncionalidadParaUnRol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Funcionalidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelMuestraNombre;
        private System.Windows.Forms.Button btnVolver;
    }
}