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
    public partial class btnNaranjaBrillante : UserControl
    {
        private Color arribColor = Color.FromArgb(255, 130, 67);
        private Color abajColor = Color.FromArgb(199, 88, 32);
        private Color arribHover = Color.FromArgb(132, 58, 21);
        private Color abajHover = Color.FromArgb(132, 58, 21);

        private Size tamaño = new Size(130, 40);

        private Image img;
        private Size imgSize = new Size(25, 25);

        private String text = "Botón";
        private int bRadius = 8;

        private Font fontD = new Font("Tahoma", 10, FontStyle.Bold, GraphicsUnit.Point);


        [Category("Editores")]
        public Font Fuente
        {
            get { return fontD; }
            set
            {
                fontD = value;
                botonNaranjaBrillante.Font = fontD;
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
                botonNaranjaBrillante.BaseColor1 = arribColor;
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
                botonNaranjaBrillante.BaseColor2 = abajColor;

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
                botonNaranjaBrillante.OnHoverBaseColor1 = arribHover;
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
                botonNaranjaBrillante.OnHoverBaseColor2 = abajHover;
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
                botonNaranjaBrillante.Size = tamaño;
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
                botonNaranjaBrillante.Text = text = text.Replace("@", "" + "\n");
            }
        }

        public enum TextoAlineo
        {
            Center,
            Left,
            Right
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
                    case TextoAlineo.Center:
                        botonNaranjaBrillante.TextAlign = HorizontalAlignment.Center;
                        break;

                    case TextoAlineo.Right:
                        botonNaranjaBrillante.TextAlign = HorizontalAlignment.Right;
                        break;

                    case TextoAlineo.Left:
                        botonNaranjaBrillante.TextAlign = HorizontalAlignment.Left;
                        break;

                }
            }
        }

        [Category("Editores")]
        public Image Imagen
        {
            get
            {
                return img;
            }
            set
            {
                img = value;
                botonNaranjaBrillante.Image = img;
            }
        }
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
                botonNaranjaBrillante.ImageSize = imgSize;
            }
        }
        [Category("Editores")]
        public int Radio
        {
            get { return bRadius; }
            set
            {
                bRadius = value;
                botonNaranjaBrillante.Radius = bRadius;
            }

        }
        public btnNaranjaBrillante()
        {
            InitializeComponent();
        }
    }
}
