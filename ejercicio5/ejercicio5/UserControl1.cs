using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class UserControl1 : UserControl
    {
        Color color;

        public UserControl1()
        {
            InitializeComponent();

            this.Width = 100;
            textBox1.Height = 30;
        }

        private void Component_Resize(object sender, EventArgs e)
        {
            this.Height = textBox1.Height + 20;
            textBox1.Width = this.Width - 20;
        }

        public event EventHandler TxtChanged;

        protected virtual void OnTxtChanged()
        {
            if (tipo == eTipo.Numérico)
            {
                if (int.TryParse(textBox1.Text, out int num))
                {
                    color = Color.Green;
                }
                else
                {
                    color = Color.Red;
                }
            }
            else
            {
                if (!textBox1.Text.Any(char.IsDigit))
                {
                    color = Color.Green;
                }
                else
                {
                    color = Color.Red;
                }
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                color = BackColor;
            }

            Refresh();

            TxtChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OnTxtChanged();
        }

        private string texto = "";
        [Category("AAA Mis Propiedades")]
        [Description("Cambia el texto del textbox")]
        public string Texto
        {
            set => textBox1.Text = value;
            get => textBox1.Text;
        }

        private bool multilinea = false;
        [Category("AAA Mis Propiedades")]
        [Description("Indica si permite o no multilinea en el textbox")]
        public bool Multilinea
        {
            set => multilinea = value;
            get => multilinea;
        }

        public enum eTipo { Numérico, Textual }
        private eTipo tipo = eTipo.Numérico;
        [Category("AAA Mis Propiedades")]
        [Description("Indica el tipo de textbox a comprobar")]
        public eTipo Tipo
        {
            set => tipo = value;
            get => tipo;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(color, 1))
            {
                g.DrawRectangle(pen, new Rectangle(5, 5, this.Width - 10, this.Height - 10));
            }
        }
    }
                //g.DrawRectangle(pen, new Rectangle(this.Width - 5, this.Height - 5, 5, 5));
}
