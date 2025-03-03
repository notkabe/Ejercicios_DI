namespace ejercicio1_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTextBox1 = new ejercicio1.LabelTextBox();
            this.customControl11 = new ejercicio1.CustomControl1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cambiar Posicion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cambiar Separacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "AAA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AAA";
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(47, 33);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Position = ejercicio1.LabelTextBox.cPosition.Left;
            this.labelTextBox1.PswChr = '\0';
            this.labelTextBox1.Separation = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(262, 20);
            this.labelTextBox1.TabIndex = 1;
            this.labelTextBox1.TextLbl = "label1";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.TxtChanged += new System.EventHandler(this.LabelTextBox1_TxtChanged);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LabelTextBox_KeyUp);
            // 
            // customControl11
            // 
            this.customControl11.ColorFin = System.Drawing.Color.Blue;
            this.customControl11.ColorInicio = System.Drawing.Color.LightBlue;
            this.customControl11.ImagenMarca = null;
            this.customControl11.Location = new System.Drawing.Point(47, 102);
            this.customControl11.Marca = ejercicio1.CustomControl1.EMarca.Circulo;
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(142, 53);
            this.customControl11.TabIndex = 5;
            this.customControl11.Text = "customControl11";
            this.customControl11.UsarGradiente = false;
            this.customControl11.ClickEnMarca += new System.EventHandler(this.ClickEnMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customControl11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ejercicio1.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ejercicio1.CustomControl1 customControl11;
    }
}

