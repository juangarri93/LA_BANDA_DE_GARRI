﻿namespace AerolineaFrba.Abm_Ruta
{
    partial class ABMRutaBajaModificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMRutaBajaModificacion));
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.txtPrecioKG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Habilitado = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cmbBajaLogica = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtCodigoRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHabilitado = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cbTipoDeServicio = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(114, 172);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(148, 21);
            this.cbDestino.TabIndex = 70;
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(114, 133);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(148, 21);
            this.cbOrigen.TabIndex = 69;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(692, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 33);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(312, 257);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 33);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(114, 257);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(148, 20);
            this.txtPrecioBase.TabIndex = 66;
            // 
            // txtPrecioKG
            // 
            this.txtPrecioKG.Location = new System.Drawing.Point(114, 217);
            this.txtPrecioKG.Name = "txtPrecioKG";
            this.txtPrecioKG.Size = new System.Drawing.Size(148, 20);
            this.txtPrecioKG.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Precio KG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tipo Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Origen";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(502, 257);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(127, 33);
            this.btnEditar.TabIndex = 72;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Precio base";
            // 
            // Habilitado
            // 
            this.Habilitado.AutoSize = true;
            this.Habilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Habilitado.Location = new System.Drawing.Point(11, 305);
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.Size = new System.Drawing.Size(70, 16);
            this.Habilitado.TabIndex = 73;
            this.Habilitado.Text = "Habilitado";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbBajaLogica});
            this.dataGridView.Location = new System.Drawing.Point(312, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(507, 215);
            this.dataGridView.TabIndex = 75;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // cmbBajaLogica
            // 
            this.cmbBajaLogica.HeaderText = "Baja Logica";
            this.cmbBajaLogica.Name = "cmbBajaLogica";
            this.cmbBajaLogica.ReadOnly = true;
            // 
            // txtCodigoRuta
            // 
            this.txtCodigoRuta.Location = new System.Drawing.Point(114, 63);
            this.txtCodigoRuta.Name = "txtCodigoRuta";
            this.txtCodigoRuta.Size = new System.Drawing.Size(148, 20);
            this.txtCodigoRuta.TabIndex = 78;
            this.txtCodigoRuta.TextChanged += new System.EventHandler(this.txtCodigoRuta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Codigo Ruta";
            // 
            // cbHabilitado
            // 
            this.cbHabilitado.FormattingEnabled = true;
            this.cbHabilitado.Location = new System.Drawing.Point(114, 300);
            this.cbHabilitado.Name = "cbHabilitado";
            this.cbHabilitado.Size = new System.Drawing.Size(148, 21);
            this.cbHabilitado.TabIndex = 80;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(502, 311);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 33);
            this.btnVolver.TabIndex = 81;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cbTipoDeServicio
            // 
            this.cbTipoDeServicio.FormattingEnabled = true;
            this.cbTipoDeServicio.Location = new System.Drawing.Point(114, 98);
            this.cbTipoDeServicio.Name = "cbTipoDeServicio";
            this.cbTipoDeServicio.Size = new System.Drawing.Size(148, 21);
            this.cbTipoDeServicio.TabIndex = 82;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(12, 27);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(50, 16);
            this.Id.TabIndex = 83;
            this.Id.Text = "Id Ruta";
            this.Id.Click += new System.EventHandler(this.Id_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(114, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 20);
            this.txtId.TabIndex = 84;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(805, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 33);
            this.button3.TabIndex = 85;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ABMRutaBajaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 356);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.cbTipoDeServicio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cbHabilitado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoRuta);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Habilitado);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.txtPrecioKG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ABMRutaBajaModificacion";
            this.Text = "Baja/Modificacion de Ruta";
            this.Load += new System.EventHandler(this.ABMRutaBajaModificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.TextBox txtPrecioKG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Habilitado;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmbBajaLogica;
        private System.Windows.Forms.TextBox txtCodigoRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHabilitado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cbTipoDeServicio;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button3;
    }
}