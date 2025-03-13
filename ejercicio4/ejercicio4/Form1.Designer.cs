namespace ejercicio4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labeli2 = new System.Windows.Forms.Label();
            this.labeli3 = new System.Windows.Forms.Label();
            this.labeli4 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labeli1 = new System.Windows.Forms.Label();
            this.labelPalabra = new System.Windows.Forms.Label();
            this.labelErrores = new System.Windows.Forms.Label();
            this.labelLetrasError = new System.Windows.Forms.Label();
            this.componenteAhorcado1 = new ejercicio4.ComponenteAhorcado();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labeli2
            // 
            this.labeli2.AutoSize = true;
            this.labeli2.Location = new System.Drawing.Point(12, 183);
            this.labeli2.Name = "labeli2";
            this.labeli2.Size = new System.Drawing.Size(90, 13);
            this.labeli2.TabIndex = 2;
            this.labeli2.Text = "Introduce tu letra:";
            // 
            // labeli3
            // 
            this.labeli3.AutoSize = true;
            this.labeli3.Location = new System.Drawing.Point(12, 238);
            this.labeli3.Name = "labeli3";
            this.labeli3.Size = new System.Drawing.Size(49, 13);
            this.labeli3.TabIndex = 3;
            this.labeli3.Text = "Errores : ";
            // 
            // labeli4
            // 
            this.labeli4.AutoSize = true;
            this.labeli4.Location = new System.Drawing.Point(12, 270);
            this.labeli4.Name = "labeli4";
            this.labeli4.Size = new System.Drawing.Size(86, 13);
            this.labeli4.TabIndex = 4;
            this.labeli4.Text = "Letras erróneas :";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(309, 182);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(67, 21);
            this.buttonCheck.TabIndex = 6;
            this.buttonCheck.Text = "check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labeli1
            // 
            this.labeli1.AutoSize = true;
            this.labeli1.Location = new System.Drawing.Point(12, 32);
            this.labeli1.Name = "labeli1";
            this.labeli1.Size = new System.Drawing.Size(52, 13);
            this.labeli1.TabIndex = 7;
            this.labeli1.Text = "Palabra : ";
            // 
            // labelPalabra
            // 
            this.labelPalabra.AutoSize = true;
            this.labelPalabra.Location = new System.Drawing.Point(71, 32);
            this.labelPalabra.Name = "labelPalabra";
            this.labelPalabra.Size = new System.Drawing.Size(65, 13);
            this.labelPalabra.TabIndex = 8;
            this.labelPalabra.Text = "labelPalabra";
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Location = new System.Drawing.Point(67, 238);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(62, 13);
            this.labelErrores.TabIndex = 9;
            this.labelErrores.Text = "labelErrores";
            // 
            // labelLetrasError
            // 
            this.labelLetrasError.AutoSize = true;
            this.labelLetrasError.Location = new System.Drawing.Point(104, 270);
            this.labelLetrasError.Name = "labelLetrasError";
            this.labelLetrasError.Size = new System.Drawing.Size(80, 13);
            this.labelLetrasError.TabIndex = 10;
            this.labelLetrasError.Text = "labelLetrasError";
            // 
            // componenteAhorcado1
            // 
            this.componenteAhorcado1.Errores = 7;
            this.componenteAhorcado1.Location = new System.Drawing.Point(572, 12);
            this.componenteAhorcado1.MinimumSize = new System.Drawing.Size(150, 200);
            this.componenteAhorcado1.Name = "componenteAhorcado1";
            this.componenteAhorcado1.Size = new System.Drawing.Size(192, 220);
            this.componenteAhorcado1.TabIndex = 11;
            this.componenteAhorcado1.Text = "componenteAhorcado1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.componenteAhorcado1);
            this.Controls.Add(this.labelLetrasError);
            this.Controls.Add(this.labelErrores);
            this.Controls.Add(this.labelPalabra);
            this.Controls.Add(this.labeli1);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labeli4);
            this.Controls.Add(this.labeli3);
            this.Controls.Add(this.labeli2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labeli2;
        private System.Windows.Forms.Label labeli3;
        private System.Windows.Forms.Label labeli4;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labeli1;
        private System.Windows.Forms.Label labelPalabra;
        private System.Windows.Forms.Label labelErrores;
        private System.Windows.Forms.Label labelLetrasError;
        private ComponenteAhorcado componenteAhorcado1;
    }
}

