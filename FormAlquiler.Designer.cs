namespace AlquilerAutomoviles
{
    partial class FormAlquiler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPlaca = new System.Windows.Forms.ComboBox();
            this.dateTimePickerAlquilado = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDevuelto = new System.Windows.Forms.DateTimePicker();
            this.textBoxKilometros = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alquilado el";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Devuelto el";
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(237, 58);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(153, 20);
            this.textBoxNit.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kilometros Recorridos";
            // 
            // comboBoxPlaca
            // 
            this.comboBoxPlaca.FormattingEnabled = true;
            this.comboBoxPlaca.Location = new System.Drawing.Point(237, 143);
            this.comboBoxPlaca.Name = "comboBoxPlaca";
            this.comboBoxPlaca.Size = new System.Drawing.Size(170, 21);
            this.comboBoxPlaca.TabIndex = 6;
            // 
            // dateTimePickerAlquilado
            // 
            this.dateTimePickerAlquilado.Location = new System.Drawing.Point(237, 218);
            this.dateTimePickerAlquilado.Name = "dateTimePickerAlquilado";
            this.dateTimePickerAlquilado.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAlquilado.TabIndex = 7;
            // 
            // dateTimePickerDevuelto
            // 
            this.dateTimePickerDevuelto.Location = new System.Drawing.Point(237, 308);
            this.dateTimePickerDevuelto.Name = "dateTimePickerDevuelto";
            this.dateTimePickerDevuelto.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDevuelto.TabIndex = 8;
            // 
            // textBoxKilometros
            // 
            this.textBoxKilometros.Location = new System.Drawing.Point(237, 386);
            this.textBoxKilometros.Name = "textBoxKilometros";
            this.textBoxKilometros.Size = new System.Drawing.Size(100, 20);
            this.textBoxKilometros.TabIndex = 9;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(351, 459);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(182, 42);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FormAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 558);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxKilometros);
            this.Controls.Add(this.dateTimePickerDevuelto);
            this.Controls.Add(this.dateTimePickerAlquilado);
            this.Controls.Add(this.comboBoxPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlquiler";
            this.Text = "FormAlquiler";
            this.Load += new System.EventHandler(this.FormAlquiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPlaca;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlquilado;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevuelto;
        private System.Windows.Forms.TextBox textBoxKilometros;
        private System.Windows.Forms.Button buttonGuardar;
    }
}