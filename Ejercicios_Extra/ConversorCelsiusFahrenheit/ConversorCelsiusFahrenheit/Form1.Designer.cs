namespace ConversorCelsiusFahrenheit
{
    partial class Form1
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
            this.Conectar_button = new System.Windows.Forms.Button();
            this.Desconectar_button = new System.Windows.Forms.Button();
            this.celsius = new System.Windows.Forms.TextBox();
            this.fahrenheit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.convFah = new System.Windows.Forms.Button();
            this.convCel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Conectar_button
            // 
            this.Conectar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectar_button.Location = new System.Drawing.Point(45, 49);
            this.Conectar_button.Name = "Conectar_button";
            this.Conectar_button.Size = new System.Drawing.Size(208, 37);
            this.Conectar_button.TabIndex = 0;
            this.Conectar_button.Text = "Conectar";
            this.Conectar_button.UseVisualStyleBackColor = true;
            this.Conectar_button.Click += new System.EventHandler(this.Conectar_button_Click_1);
            // 
            // Desconectar_button
            // 
            this.Desconectar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desconectar_button.Location = new System.Drawing.Point(259, 49);
            this.Desconectar_button.Name = "Desconectar_button";
            this.Desconectar_button.Size = new System.Drawing.Size(208, 37);
            this.Desconectar_button.TabIndex = 1;
            this.Desconectar_button.Text = "Desconectar";
            this.Desconectar_button.UseVisualStyleBackColor = true;
            this.Desconectar_button.Click += new System.EventHandler(this.Desconectar_button_Click_1);
            // 
            // celsius
            // 
            this.celsius.Location = new System.Drawing.Point(45, 191);
            this.celsius.Name = "celsius";
            this.celsius.Size = new System.Drawing.Size(148, 22);
            this.celsius.TabIndex = 2;
            // 
            // fahrenheit
            // 
            this.fahrenheit.Location = new System.Drawing.Point(45, 300);
            this.fahrenheit.Name = "fahrenheit";
            this.fahrenheit.Size = new System.Drawing.Size(148, 22);
            this.fahrenheit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduce un valor en grados Celsius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introduce un valor en grados Fahrenheit:";
            // 
            // convFah
            // 
            this.convFah.Location = new System.Drawing.Point(364, 180);
            this.convFah.Name = "convFah";
            this.convFah.Size = new System.Drawing.Size(148, 44);
            this.convFah.TabIndex = 6;
            this.convFah.Text = "Convertir a grados Fahrenheit";
            this.convFah.UseVisualStyleBackColor = true;
            this.convFah.Click += new System.EventHandler(this.convFah_Click);
            // 
            // convCel
            // 
            this.convCel.Location = new System.Drawing.Point(364, 289);
            this.convCel.Name = "convCel";
            this.convCel.Size = new System.Drawing.Size(148, 44);
            this.convCel.TabIndex = 7;
            this.convCel.Text = "Convertir a grados Celsius\r\n";
            this.convCel.UseVisualStyleBackColor = true;
            this.convCel.Click += new System.EventHandler(this.convCel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convCel);
            this.Controls.Add(this.convFah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fahrenheit);
            this.Controls.Add(this.celsius);
            this.Controls.Add(this.Desconectar_button);
            this.Controls.Add(this.Conectar_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conectar_button;
        private System.Windows.Forms.Button Desconectar_button;
        private System.Windows.Forms.TextBox celsius;
        private System.Windows.Forms.TextBox fahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convFah;
        private System.Windows.Forms.Button convCel;
    }
}

