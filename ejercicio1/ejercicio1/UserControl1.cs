using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ejercicio1.LabelTextBox;

namespace ejercicio1
{
    public partial class LabelTextBox : UserControl
    {
        bool subrayado = true;

        public LabelTextBox()
        {
            InitializeComponent();
            recolocar();

            this.Text = "Ejercicio 1";
        }

        public enum cPosition
        {
            Left, Right
        }

        private cPosition position = cPosition.Left;
        [Category("Mis Propiedades")]
        [Description("Indica si el label se sitúa a la derecha o izquierda en referido al textbox")]
        [RefreshProperties(RefreshProperties.Repaint)]

        public cPosition Position
        {
            set
            {
                if (Enum.IsDefined(typeof(cPosition), value))
                {
                    position = value;
                    Refresh();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return position;
            }
        }

        private int separation = 0;
        [Category("Mis Propiedades")]
        [Description("Píxels de separación entre Label y Textbox")]
        [RefreshProperties(RefreshProperties.Repaint)]

        public int Separation
        {
            set
            {
                if (value >= 0)
                {
                    separation = value;
                    OnSeparationChanged(EventArgs.Empty);
                    Refresh();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separation;
            }
        }

        [Category("Mis Propiedades")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                Refresh();
            }
            get
            {
                return lbl.Text;
            }
        }
        [Category("Mis Propiedades")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        //private void recolocar()
        //{
        //    switch (position)
        //    {
        //        case cPosition.Left:
        //            lbl.Location = new Point(0, 0);
        //            txt.Location = new Point(lbl.Width + Separation, 0);
        //            this.Width = txt.Width + lbl.Width + Separation;
        //            this.Height = Math.Max(txt.Height, lbl.Height);
        //            break;

        //        case cPosition.Right:
        //            txt.Location = new Point(0, 0);
        //            lbl.Location = new Point(txt.Width + Separation, 0);
        //            this.Width = txt.Width + lbl.Width + Separation;
        //            this.Height = Math.Max(txt.Height, lbl.Height);
        //            break;
        //    }
        //}

        private void recolocar()
        {
            switch (position)
            {
                case cPosition.Left:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separation, 0);

                    lbl.Width = this.Width - txt.Width - Separation;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;

                case cPosition.Right:
                    txt.Location = new Point(0, 0);
                    lbl.Location = new Point(txt.Width + Separation, 0);

                    lbl.Width = this.Width - txt.Width - Separation;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }

        //B
        protected void OnSeparationChanged(EventArgs e)
        {
            var parentForm = this.FindForm();

            if (parentForm != null)
            {
                String texto = parentForm.Text;
                texto = texto.Remove(5, parentForm.Text.Count() - 5);
                parentForm.Text = texto + $" - Separacion: {separation}";

            }
        }

        //C
        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        //D
        public void txt_TextChanged(object sender, EventArgs e)
        {
            OnTxtChanged(e);
        }

        protected virtual void OnTxtChanged(EventArgs e)
        {
            TxtChanged?.Invoke(this, e);
        }

        public event System.EventHandler TxtChanged;

        //E
        [Category("Mis Propiedades")]
        [Description("Enlace a la propiedad PasswordChar del Textbox.")]
        public char PswChr
        {
            get => txt.PasswordChar;
            set => txt.PasswordChar = value;
        }

        // Ejercicio 2 Apartado a
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            recolocar();

            if (subrayado)
            {
                e.Graphics.DrawLine(new Pen(Color.Violet),
                       lbl.Left, this.Height - 1,
                       lbl.Left + lbl.Width, this.Height - 1);
            }
        }
    }
}
