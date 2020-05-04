namespace ReporteLiquidacionGUI
{
    partial class Consulta
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
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtEntidadConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TablaContratista = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaContratista)).BeginInit();
            this.SuspendLayout();
            // 
            // DtFecha
            // 
            this.DtFecha.Location = new System.Drawing.Point(445, 45);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(251, 20);
            this.DtFecha.TabIndex = 0;
            // 
            // TxtEntidadConsulta
            // 
            this.TxtEntidadConsulta.Location = new System.Drawing.Point(186, 45);
            this.TxtEntidadConsulta.Name = "TxtEntidadConsulta";
            this.TxtEntidadConsulta.Size = new System.Drawing.Size(100, 20);
            this.TxtEntidadConsulta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // TablaContratista
            // 
            this.TablaContratista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaContratista.Location = new System.Drawing.Point(106, 103);
            this.TablaContratista.Name = "TablaContratista";
            this.TablaContratista.Size = new System.Drawing.Size(600, 285);
            this.TablaContratista.TabIndex = 4;
            this.TablaContratista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaContratista_CellContentClick);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(186, 422);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(424, 47);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.TablaContratista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEntidadConsulta);
            this.Controls.Add(this.DtFecha);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.TablaContratista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtFecha;
        private System.Windows.Forms.TextBox TxtEntidadConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TablaContratista;
        private System.Windows.Forms.Button BtnConsultar;
    }
}