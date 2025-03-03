using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class CustomControl1 : Control
    {
        public CustomControl1()
        {
            InitializeComponent();

            this.ColorInicio = Color.LightBlue;
            this.ColorFin = Color.Blue;
            this.UsarGradiente = false;
            this.ImagenMarca = null;
        }

        private int grosor;
        private int offsetX;
        private int offsetY;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            grosor = 0; //Grosor de las líneas de dibujo
            offsetX = 0; //Desplazamiento a la derecha del texto
            offsetY = 0; //Desplazamiento hacia abajo del texto

            int h = this.Font.Height;// Altura de fuente, usada como referencia en varias partes
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (usarGradiente)
            {
                using (LinearGradientBrush lgd = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFin, LinearGradientMode.Horizontal))
                {
                    g.FillRectangle(lgd, this.ClientRectangle);
                }
            }
            else
            {
                using (SolidBrush sb = new SolidBrush(this.BackColor))
                {
                    g.FillRectangle(sb, this.ClientRectangle);
                }
            }

            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            switch (Marca)
            {
                case EMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;

                case EMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;

                case EMarca.Imagen:
                    if (imagenMarca != null)
                    {
                        Rectangle imagen = new Rectangle(grosor, grosor, h, h);
                        g.DrawImage(imagenMarca, imagen);
                        offsetX = h + grosor;
                        offsetY = grosor;
                    }
                    break;
            }

            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        public enum EMarca
        {
            Nada,
            Cruz,
            Circulo,
            Imagen
        }

        private EMarca marca = EMarca.Nada;

        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public EMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }

        private Color colorInicio;
        private Color colorFin;
        private bool usarGradiente;
        private Image imagenMarca;

        [Category("Appearance")]
        [Description("Color inicial del fondo del gradiente")]
        public Color ColorInicio
        {
            set
            {
                colorInicio = value;
                this.Refresh();
            }

            get { return colorInicio; }
        }

        [Category("Appearance")]
        [Description("Color final del fondo del gradiente")]
        public Color ColorFin
        {
            set
            {
                colorFin = value;
                this.Refresh();
            }

            get { return colorFin; }
        }

        [Category("Appearance")]
        [Description("Indica si hay o no gradiente")]
        public bool UsarGradiente
        {
            set
            {
                usarGradiente = value;
                this.Refresh();
            }

            get { return usarGradiente; }
        }

        [Category("Appearance")]
        [Description("Imagen que se usará como marca si Marca está en Imagen")]
        public Image ImagenMarca
        {
            get { return imagenMarca; }
            set { imagenMarca = value; this.Refresh(); }
        }

        public event EventHandler ClickEnMarca;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (Marca == EMarca.Nada) return;

            int h = this.Font.Height;

            Rectangle areaMarca = new Rectangle(grosor, grosor, h, h);


            if (areaMarca.Contains(e.Location))
            {
                ClickEnMarca?.Invoke(this, e);
            }
        }
    }
}
