using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace btnLib
{
    public partial class btnPrimary: UserControl
    {
        private Color arribColor = Color.FromArgb(43, 187, 209);
        private Color abajColor = Color.FromArgb(33, 148, 166);
        private Color arribHover = Color.FromArgb(28, 124, 139);
        private Color abajHover = Color.FromArgb(28, 124, 139);

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
                botonPrimary.TextOffsetX = offsetTxt;
            }
        }

        [Category("Editores")]
        public int Offset_imagen
        {
            get { return offsetImg; }
            set
            {
                offsetImg = value;
                botonPrimary.ImageOffsetX = offsetImg;
            }
        }

        [Category("Editores")]
        public Font Fuente
        {
            get { return fontD; }
            set
            {
                fontD = value;
                botonPrimary.Font = fontD;
            }
        }


        // Declares the name and type of the property.
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
                botonPrimary.BaseColor1 = arribColor;
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
                botonPrimary.BaseColor2 = abajColor;

            }
        }

        [Category("Editores")]
        public Color Hover1_Arriba
        {
            // Retrieves the value of the private variable colBColor.
            get
            {
                return arribHover;
            }
            // Stores the selected value in the private variable colBColor, and
            // updates the background color of the label control lblDisplay.
            set
            {
                arribHover = value;
                botonPrimary.OnHoverBaseColor1 = arribHover;
            }
        }
        // Provides a similar set of instructions for the foreground color.
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
                botonPrimary.OnHoverBaseColor2 = abajHover;
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
                botonPrimary.Size = tamaño;
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
                botonPrimary.Text = text = text.Replace("@", ""+ "\n"); 
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
                        botonPrimary.TextAlign = HorizontalAlignment.Center;
                        break;

                    case TextoAlineo.Right:
                        botonPrimary.TextAlign = HorizontalAlignment.Right;
                        break;

                    case TextoAlineo.Left:
                        botonPrimary.TextAlign = HorizontalAlignment.Left;
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
                botonPrimary.Image = img;
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
                botonPrimary.ImageSize = imgSize;
            }
        }
        [Category("Editores")]
        public int Radio
        {
            get { return bRadius; }
            set
            {
                bRadius = value;
                botonPrimary.Radius = bRadius;
            }

        }


        public btnPrimary()
        {
            InitializeComponent();
        }
    }
}
