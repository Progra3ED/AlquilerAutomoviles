namespace AlquilerAutomoviles
{
    partial class FormReporte
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
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.labelRecorrido = new System.Windows.Forms.Label();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.buttonRecorrido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(31, 65);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.Size = new System.Drawing.Size(781, 215);
            this.dataGridViewReporte.TabIndex = 0;
            // 
            // labelRecorrido
            // 
            this.labelRecorrido.AutoSize = true;
            this.labelRecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecorrido.Location = new System.Drawing.Point(513, 308);
            this.labelRecorrido.Name = "labelRecorrido";
            this.labelRecorrido.Size = new System.Drawing.Size(125, 20);
            this.labelRecorrido.TabIndex = 1;
            this.labelRecorrido.Text = "Mayor Recorrido";
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(151, 374);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(204, 63);
            this.buttonReporte.TabIndex = 2;
            this.buttonReporte.Text = "Mostrar Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // buttonRecorrido
            // 
            this.buttonRecorrido.Location = new System.Drawing.Point(629, 392);
            this.buttonRecorrido.Name = "buttonRecorrido";
            this.buttonRecorrido.Size = new System.Drawing.Size(111, 45);
            this.buttonRecorrido.TabIndex = 3;
            this.buttonRecorrido.Text = "Calcular el mayor recorrido";
            this.buttonRecorrido.UseVisualStyleBackColor = true;
            this.buttonRecorrido.Click += new System.EventHandler(this.buttonRecorrido_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 547);
            this.Controls.Add(this.buttonRecorrido);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.labelRecorrido);
            this.Controls.Add(this.dataGridViewReporte);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Label labelRecorrido;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Button buttonRecorrido;
    }
}