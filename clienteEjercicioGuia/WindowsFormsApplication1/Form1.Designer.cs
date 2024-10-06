namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Enviar_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.palindromo = new System.Windows.Forms.RadioButton();
            this.altura = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.alturaBox = new System.Windows.Forms.TextBox();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.Conectar_button = new System.Windows.Forms.Button();
            this.Desconectar_button = new System.Windows.Forms.Button();
            this.mayuscula = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(155, 38);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 22);
            this.nombre.TabIndex = 3;
            // 
            // Enviar_button
            // 
            this.Enviar_button.Location = new System.Drawing.Point(155, 264);
            this.Enviar_button.Margin = new System.Windows.Forms.Padding(4);
            this.Enviar_button.Name = "Enviar_button";
            this.Enviar_button.Size = new System.Drawing.Size(100, 28);
            this.Enviar_button.TabIndex = 5;
            this.Enviar_button.Text = "Enviar";
            this.Enviar_button.UseVisualStyleBackColor = true;
            this.Enviar_button.Click += new System.EventHandler(this.Enviar_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.mayuscula);
            this.groupBox1.Controls.Add(this.palindromo);
            this.groupBox1.Controls.Add(this.altura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.alturaBox);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Enviar_button);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(16, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 347);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // palindromo
            // 
            this.palindromo.AutoSize = true;
            this.palindromo.Location = new System.Drawing.Point(155, 168);
            this.palindromo.Margin = new System.Windows.Forms.Padding(4);
            this.palindromo.Name = "palindromo";
            this.palindromo.Size = new System.Drawing.Size(225, 20);
            this.palindromo.TabIndex = 11;
            this.palindromo.TabStop = true;
            this.palindromo.Text = "Dime si el nombre es palíndromo";
            this.palindromo.UseVisualStyleBackColor = true;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(155, 140);
            this.altura.Margin = new System.Windows.Forms.Padding(4);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(135, 20);
            this.altura.TabIndex = 10;
            this.altura.TabStop = true;
            this.altura.Text = "Dime si soy alto/a\r\n";
            this.altura.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Altura (m):";
            // 
            // alturaBox
            // 
            this.alturaBox.Location = new System.Drawing.Point(37, 264);
            this.alturaBox.Name = "alturaBox";
            this.alturaBox.Size = new System.Drawing.Size(94, 22);
            this.alturaBox.TabIndex = 10;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(155, 112);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(209, 20);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(155, 84);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(197, 20);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // Conectar_button
            // 
            this.Conectar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectar_button.Location = new System.Drawing.Point(16, 76);
            this.Conectar_button.Name = "Conectar_button";
            this.Conectar_button.Size = new System.Drawing.Size(196, 29);
            this.Conectar_button.TabIndex = 8;
            this.Conectar_button.Text = "Conectar";
            this.Conectar_button.UseVisualStyleBackColor = true;
            this.Conectar_button.Click += new System.EventHandler(this.Conectar_button_Click);
            // 
            // Desconectar_button
            // 
            this.Desconectar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desconectar_button.Location = new System.Drawing.Point(16, 522);
            this.Desconectar_button.Name = "Desconectar_button";
            this.Desconectar_button.Size = new System.Drawing.Size(196, 29);
            this.Desconectar_button.TabIndex = 9;
            this.Desconectar_button.Text = "Desconectar";
            this.Desconectar_button.UseVisualStyleBackColor = true;
            this.Desconectar_button.Click += new System.EventHandler(this.Desconectar_button_Click);
            // 
            // mayuscula
            // 
            this.mayuscula.AutoSize = true;
            this.mayuscula.Location = new System.Drawing.Point(155, 196);
            this.mayuscula.Margin = new System.Windows.Forms.Padding(4);
            this.mayuscula.Name = "mayuscula";
            this.mayuscula.Size = new System.Drawing.Size(221, 20);
            this.mayuscula.TabIndex = 12;
            this.mayuscula.TabStop = true;
            this.mayuscula.Text = "Dame el nombre en mayúsculas";
            this.mayuscula.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.Desconectar_button);
            this.Controls.Add(this.Conectar_button);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button Enviar_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Button Conectar_button;
        private System.Windows.Forms.Button Desconectar_button;
        private System.Windows.Forms.TextBox alturaBox;
        private System.Windows.Forms.RadioButton altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton palindromo;
        private System.Windows.Forms.RadioButton mayuscula;
    }
}

