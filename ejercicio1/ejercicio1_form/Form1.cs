using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Tecla presionada: "; 
            label2.Text = "Texto cambiado 0 veces";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = this.Text.Remove(0, 5);

            if (labelTextBox1.Position == ejercicio1.LabelTextBox.cPosition.Left)
            {
                labelTextBox1.Position  = ejercicio1.LabelTextBox.cPosition.Right;
                this.Text = labelTextBox1.Position.ToString() + this.Text;
            }
            else
            {
                labelTextBox1.Position = ejercicio1.LabelTextBox.cPosition.Left;
                this.Text = " " + labelTextBox1.Position.ToString() + this.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Separation != 0)
            {
                labelTextBox1.Separation = 0;
            }
            else
            {
                labelTextBox1.Separation = 10;
            }
        }

        private void LabelTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = $"Tecla presionada: {e.KeyCode}";
        }

        int vecesCambiado = 0;
        private void LabelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            vecesCambiado++;
            label2.Text = $"Texto cambiado {vecesCambiado} veces";
        }

        private void ClickEnMarca(object sender, EventArgs e)
        {
            MessageBox.Show("¡Clic en la marca!");
        }
    }
}
