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
    public partial class btnGris : UserControl
    {
        private Color arribColor = Color.FromArgb(255, 255, 255);
        private Color abajColor = Color.FromArgb(170, 170, 170);
        private Color arribHover = Color.FromArgb(88, 88, 88);
        private Color abajHover = Color.FromArgb(64, 64, 64);

        private Size tamaño = new Size(130, 40);

        private Image img;
        private Size imgSize = new Size(25, 25);

        private String text = "Botón";
        private int bRadius = 8;

        private Font fontD = new Font("Tahoma", 10, FontStyle.Bold, GraphicsUnit.Point);
        private int offsetImg = 0;
        private int offsetTxt = 0;

        [Category("Editores")]
        public int Offset_Texto
        {
            get { return offsetTxt; }
            set
            {
                offsetTxt = value;
                botonGris.TextOffsetX = offsetTxt;
            }
        }

        [Category("Editores")]
        public int Offset_imagen
        {
            get { return offsetImg; }
            set
            {
                offsetImg = value;
                botonGris.ImageOffsetX = offsetImg;
            }
        }

        [Category("Editores")]
        public Font Fuente
        {
            get { return fontD; }
            set
            {
                fontD = value;
                botonGris.Font = fontD;
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
                botonGris.BaseColor1 = arribColor;
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
                botonGris.BaseColor2 = abajColor;

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
                botonGris.OnHoverBaseColor1 = arribHover;
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
                botonGris.OnHoverBaseColor2 = abajHover;
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
                botonGris.Size = tamaño;
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
                botonGris.Text = text = text.Replace("@", "" + "\n");
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
                        botonGris.TextAlign = HorizontalAlignment.Center;
                        break;

                    case TextoAlineo.Right:
                        botonGris.TextAlign = HorizontalAlignment.Right;
                        break;

                    case TextoAlineo.Left:
                        botonGris.TextAlign = HorizontalAlignment.Left;
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
                botonGris.Image = img;
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
                botonGris.ImageSize = imgSize;
            }
        }

        [Category("Editores")]
        public int Radio
        {
            get { return bRadius; }
            set
            {
                bRadius = value;
                botonGris.Radius = bRadius;
            }

        }

        public btnGris()
        {
            InitializeComponent();
        }
    }
}
