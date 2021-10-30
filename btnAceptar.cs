using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btnLib
{
    public partial class btnAceptar : UserControl
    {
        private Color arribColor = Color.FromArgb(29, 185, 84);
        private Color abajColor = Color.FromArgb(22, 139, 68);
        private Color arribHover = Color.FromArgb(3, 100, 48);
        private Color abajHover = Color.FromArgb(3, 100, 48);

        private Size tamaño = new Size(105 ,30);

        //private Image img;
        private Size imgSize = new Size(25, 25);

        private String text = "Aceptar";
        private int bRadius = 8;

        private Font fontD = new Font("Tahona", 10, FontStyle.Bold, GraphicsUnit.Point);


        [Category("Editores")]
        public Font Fuente
        {
            get { return fontD; }
            set
            {
                fontD = value;
                botonAceptar.Font = fontD;
            }
        }




        [Category("Editores")]
        public Color Color1_Arriba
        {
            get
            {
                return arribColor;
            }
            set
            {
                arribColor = value;
                botonAceptar.BaseColor1 = arribColor;
            }
        }
        [Category("Editores")]
        public Color Color2_Abajo
        {
            get
            {
                return abajColor;
            }
            set
            {
                abajColor = value;
                botonAceptar.BaseColor2 = abajColor;

            }
        }

        [Category("Editores")]
        public Color Hover1_Arriba
        {
            get
            {
                return arribHover;
            }
            set
            {
                arribHover = value;
                botonAceptar.OnHoverBaseColor1 = arribHover;
            }
        }
        [Category("Editores")]
        public Color Hover2_Abajo
        {
            get
            {
                return abajHover;
            }
            set
            {
                abajHover = value;
                botonAceptar.OnHoverBaseColor2 = abajHover;
            }
        }
        [Category("Editores")]
        public Size Tamaño_Boton
        {
            get
            {
                return tamaño;
            }

            set
            {
                tamaño = value;
                botonAceptar.Size = tamaño;
                this.Size = tamaño;
            }
        }
        [Category("Editores")]
        public String Texto
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                botonAceptar.Text = text = text.Replace("@", "" + "\n");
            }
        }

        public enum TextoAlineo
        {
            Right,
            Center,
            Left
        }
        TextoAlineo textoAlineo;

        [Category("Editores")]
        public TextoAlineo Alineacion_texto
        {
            get { return textoAlineo; }
            set
            {
                textoAlineo = value; Invalidate();
                switch (textoAlineo)
                {
                    case TextoAlineo.Right:
                        botonAceptar.TextAlign = HorizontalAlignment.Right;
                        break;

                    case TextoAlineo.Center:
                        botonAceptar.TextAlign = HorizontalAlignment.Center;
                        break;

                    case TextoAlineo.Left:
                        botonAceptar.TextAlign = HorizontalAlignment.Left;
                        break;

                }
            }
        }

        /*[Category("Editores")]
        public Image Imagen
        {
            get
            {
                return img;
            }
            set
            {
                img = value;
                botonAceptar.Image = img;
            }
        }*/
        [Category("Editores")]
        public Size Tamaño_imagen
        {
            get
            {
                return imgSize;
            }
            set
            {
                imgSize = value;
                botonAceptar.ImageSize = imgSize;
            }
        }

        [Category("Editores")]
        public int Radio
        {
            get { return bRadius; }
            set
            {
                bRadius = value;
                botonAceptar.Radius = bRadius;
            }

        }

        public btnAceptar()
        {
            InitializeComponent();
        }
    }
}
