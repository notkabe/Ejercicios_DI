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
    public partial class ComponenteAhorcado : Control  //Ecalado según rtamaño componente. Asegurar que cambia el error antes de lanzar el evento.
    {
        public ComponenteAhorcado()
        {
            InitializeComponent();
        }

        public event EventHandler CambiaError;
        public event EventHandler Ahorcado;

        private int errores;
        public int Errores
        {
            set
            {
                if (errores != value)
                {
                    errores = value;
                    CambiaError?.Invoke(this, EventArgs.Empty);

                    if (errores == 9)
                    {
                        Ahorcado?.Invoke(this, EventArgs.Empty);
                    }

                    Refresh();
                }

            }

            get => errores;
        }

        private Pen pen = new Pen(Color.Black, 2);
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float baseWidth = 150f;
            float baseHeight = 200f;

            float scaleX = this.Width / baseWidth;
            float scaleY = this.Height / baseHeight;

            pen.Width = 2 * Math.Min(scaleX, scaleY);

            g.DrawLine(pen, 10 * scaleX, 180 * scaleY, 100 * scaleX, 180 * scaleY); // Suelo
            if (errores > 0) g.DrawLine(pen, 55 * scaleX, 180 * scaleY, 55 * scaleX, 20 * scaleY);  // Poste
            if (errores > 1) g.DrawLine(pen, 55 * scaleX, 20 * scaleY, 120 * scaleX, 20 * scaleY);  // Viga superior
            if (errores > 2) g.DrawLine(pen, 120 * scaleX, 20 * scaleY, 120 * scaleX, 40 * scaleY); // Cuerda
            if (errores > 3) g.DrawEllipse(pen, (105 * scaleX), (40 * scaleY), 30 * scaleX, 30 * scaleY); // Cabeza
            if (errores > 4) g.DrawLine(pen, 120 * scaleX, 70 * scaleY, 120 * scaleX, 120 * scaleY);  // Cuerpo
            if (errores > 5) g.DrawLine(pen, 120 * scaleX, 90 * scaleY, 100 * scaleX, 110 * scaleY);  // Brazo izquierdo
            if (errores > 6) g.DrawLine(pen, 120 * scaleX, 90 * scaleY, 140 * scaleX, 110 * scaleY);  // Brazo derecho
            if (errores > 7) g.DrawLine(pen, 120 * scaleX, 120 * scaleY, 100 * scaleX, 150 * scaleY); // Pierna izquierda
            if (errores > 7) g.DrawLine(pen, 120 * scaleX, 120 * scaleY, 140 * scaleX, 150 * scaleY); // Pierna derecha
        }
    }
}
