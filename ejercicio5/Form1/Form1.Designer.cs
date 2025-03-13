namespace Form1
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
            this.userControl11 = new ejercicio5.UserControl1();
            this.userControl12 = new ejercicio5.UserControl1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(103, 110);
            this.userControl11.Multilinea = false;
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(144, 40);
            this.userControl11.TabIndex = 0;
            this.userControl11.Texto = "";
            this.userControl11.Tipo = ejercicio5.UserControl1.eTipo.Textual;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(103, 192);
            this.userControl12.Multilinea = false;
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(144, 40);
            this.userControl12.TabIndex = 1;
            this.userControl12.Texto = "";
            this.userControl12.Tipo = ejercicio5.UserControl1.eTipo.Numérico;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Textual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numérico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ejercicio5.UserControl1 userControl11;
        private ejercicio5.UserControl1 userControl12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

