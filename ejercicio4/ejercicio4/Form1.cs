using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4
{
    public partial class Form1 : Form
    {

        private static string palabra = "programacion";
        private static char letra = ' ';
        private static List<char> letrasError = new List<char>();
        private static List<char> letrasPalabra = new List<char>();
        private static List<char> letrasAdivinadas = new List<char>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Ahorcado";
            labelErrores.Text = "0";
            labelLetrasError.Text = "";

            letrasPalabra = palabra.Distinct().ToList();
            revelaPalabra();

            componenteAhorcado1.CambiaError += Componente_CambiaError;
            componenteAhorcado1.Ahorcado += Componente_Ahorcado;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (componenteAhorcado1.Errores == 9 || !labelPalabra.Text.Contains('*')) return;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Escribe una letra en el TextBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string texto = textBox1.Text.Trim().ToLower();

            if (texto.Length > 1)
            {
                MessageBox.Show("Escribe una sola letra en el TextBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            letra = texto[0];

            if (letrasAdivinadas.Contains(letra) || letrasError.Contains(letra))
            {
                MessageBox.Show("Ya has intentado con esa letra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (palabra.Contains(letra))
            {
                letrasAdivinadas.Add(letra);
                revelaPalabra();

                if (!labelPalabra.Text.Contains('*'))
                {
                    MessageBox.Show("¡Felicidades, has ganado!", "¡Ganaste!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Enabled = false;
                }
            }
            else
            {
                componenteAhorcado1.Errores++;
            }

            textBox1.Clear();
            textBox1.Focus();

        }

        private void Componente_CambiaError(object sender, EventArgs e)
        {
            if (!letrasError.Contains(letra))
            {
                letrasError.Add(letra);
                labelErrores.Text = componenteAhorcado1.Errores.ToString();
                labelLetrasError.Text = string.Join(" ", letrasError);
            }
        }

        private void Componente_Ahorcado(object sender, EventArgs e)
        {
            MessageBox.Show($"Mala suerte, la palabra era {palabra}", "¡Perdiste!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textBox1.Enabled = false;
        }

        private void revelaPalabra()
        {
            labelPalabra.Text = "";

            foreach (char letra in palabra)
            {
                if (letrasAdivinadas.Contains(letra))
                {
                    labelPalabra.Text += letra;
                }
                else
                {
                    labelPalabra.Text += '*';
                }
            }
        }

    }
}
