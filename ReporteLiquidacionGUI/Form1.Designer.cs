namespace ReporteLiquidacionGUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtImpuestoEstampilla = new System.Windows.Forms.TextBox();
            this.TxtValorImpuesto = new System.Windows.Forms.TextBox();
            this.DTFechaLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación del Contratista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Contratista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " Impuesto de estampilla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "fecha en que se liquidó el impuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "  valor del impuesto";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(243, 59);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(200, 20);
            this.TxtIdentificacion.TabIndex = 5;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(243, 102);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtImpuestoEstampilla
            // 
            this.TxtImpuestoEstampilla.Location = new System.Drawing.Point(243, 143);
            this.TxtImpuestoEstampilla.Name = "TxtImpuestoEstampilla";
            this.TxtImpuestoEstampilla.Size = new System.Drawing.Size(200, 20);
            this.TxtImpuestoEstampilla.TabIndex = 7;
            // 
            // TxtValorImpuesto
            // 
            this.TxtValorImpuesto.Location = new System.Drawing.Point(243, 222);
            this.TxtValorImpuesto.Name = "TxtValorImpuesto";
            this.TxtValorImpuesto.Size = new System.Drawing.Size(200, 20);
            this.TxtValorImpuesto.TabIndex = 9;
            // 
            // DTFechaLiquidacion
            // 
            this.DTFechaLiquidacion.Location = new System.Drawing.Point(243, 183);
            this.DTFechaLiquidacion.Name = "DTFechaLiquidacion";
            this.DTFechaLiquidacion.Size = new System.Drawing.Size(200, 20);
            this.DTFechaLiquidacion.TabIndex = 10;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(137, 320);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DTFechaLiquidacion);
            this.Controls.Add(this.TxtValorImpuesto);
            this.Controls.Add(this.TxtImpuestoEstampilla);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtImpuestoEstampilla;
        private System.Windows.Forms.TextBox TxtValorImpuesto;
        private System.Windows.Forms.DateTimePicker DTFechaLiquidacion;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button button2;
    }
}

