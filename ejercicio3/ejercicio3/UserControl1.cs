using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class ImagePlayer : UserControl
    {
        public ImagePlayer()
        {
            InitializeComponent();

            playButton.Text = "▶";
            label1.Text = "00:00";
        }

        private int sec = 0, min = 0;
        private bool isPlaying = false;

        public int Sec
        {
            get => sec;

            set
            {
                if (value < 0) throw new ArgumentException("Los segundos no pueden ser negativos.");

                sec = value % 60;

                if(value >= 60) DesbordaTiempo?.Invoke(this, EventArgs.Empty);
            }
        }

        public int Min
        {
            get => min;

            set
            {
                if (value < 0) throw new ArgumentException("Los minutos no pueden ser negativos.");

                min = value % 60;
            }
        }

        public event EventHandler DesbordaTiempo;

        public event EventHandler PlayClick;

        private void ButtonPlayPause_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            playButton.Text = isPlaying ? "⏸" : "▶";
            PlayClick?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateTimeLabel()
        {
            label1.Text = $"{min:D2}:{sec:D2}";
        }
    }
}
