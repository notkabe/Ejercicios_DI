using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ejercicio3_Form
{
    public partial class Form1 : Form
    {
        private string[] images;
        private int currentIndex;
        private int imageInterval;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";

            Rellena_ComboBox();

            timer1.Interval = 1000;
        }

        private void Rellena_ComboBox()
        {
            for (int i = 1; i <= 20; i++)
            {
                comboBox1.Items.Add(i);
            }

            comboBox1.SelectedIndex = 4;
        }

        private void ImagePlayer_PlayClick(object sender, EventArgs e)
        {
            if (images != null && images.Length > 0)
            {
                if (timer1.Enabled) timer1.Stop();
                else timer1.Start();
            }
            else
            {
                MessageBox.Show("No hay imágenes válidas en el directorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImagePlayer_DesbordaTiempo(object sender, EventArgs e)
        {
            imagePlayer1.Min++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageInterval = (Convert.ToInt32(comboBox1.SelectedIndex) + 1) * 1000;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    images = Directory.GetFiles(fbd.SelectedPath, "*.jpg")
                                      .Concat(Directory.GetFiles(fbd.SelectedPath, "*.png"))
                    .ToArray();

                    if (images.Length > 0) ShowImage(0);
                }
            }
        }

        private void ShowImage(int index)
        {
            if (images != null && images.Length > 0)
            {
                pictureBox1.ImageLocation = images[index];
                currentIndex = index;
            }
        }

        private void NextImage()
        {
            currentIndex = (currentIndex + 1) % images.Length;
            ShowImage(currentIndex);
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            imagePlayer1.Sec++;
            imagePlayer1.UpdateTimeLabel();

            if (imagePlayer1.Sec % Convert.ToInt32(comboBox1.SelectedItem) == 0)
            {
                NextImage();
            }
        }
    }
}
