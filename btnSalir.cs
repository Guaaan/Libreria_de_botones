using btnLib.Properties;
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

namespace btnLib
{
    public partial class btnSalir : UserControl
    {
        private Color arribColor = Color.FromArgb(255, 0, 0);
        private Color abajColor = Color.FromArgb(154, 0, 0);
        private Color arribHover = Color.FromArgb(102, 0, 0);
        private Color abajHover = Color.FromArgb(102, 0, 0);

        private Size tamaño = new Size(175, 50);

        //opciones de imagen

        
        //private Image img1 = System.Drawing.Image.FromFile(@"exit.png");
        //private Image img2 = System.Drawing.Image.FromFile(@"back.png");
        //private Image img;


        private Size imgSize = new Size(25, 25);

        private String text = "Salir";
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
                botonSalir.TextOffsetX = offsetTxt;
            }
        }

        [Category("Editores")]
        public int Offset_imagen
        {
            get { return offsetImg; }
            set
            {
                offsetImg = value;
                botonSalir.ImageOffsetX = offsetImg;
            }
        }

        [Category("Editores")]
        public Font Fuente
        {
            get { return fontD; }
            set
            {
                fontD = value;
                botonSalir.Font = fontD;
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
                botonSalir.BaseColor1 = arribColor;
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
                botonSalir.BaseColor2 = abajColor;

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
                botonSalir.OnHoverBaseColor1 = arribHover;
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
                botonSalir.OnHoverBaseColor2 = abajHover;
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
                botonSalir.Size = tamaño;
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
                botonSalir.Text = text = text.Replace("@", "" + "\n");
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
                        botonSalir.TextAlign = HorizontalAlignment.Center;
                        break;

                    case TextoAlineo.Right:
                        botonSalir.TextAlign = HorizontalAlignment.Right;
                        break;

                    case TextoAlineo.Left:
                        botonSalir.TextAlign = HorizontalAlignment.Left;
                        break;

                }
            }
        }


        //lista de opciones de imagen
        /*public enum ElegirFoto
        {
            Volver,
            Salir
        }
        ElegirFoto elegirFoto;
        [Category("Editores")]
        public ElegirFoto Cambiar_foto
        { 
            get { return elegirFoto; }
            set
            {
                elegirFoto = value; Invalidate();
                switch (elegirFoto)
                {
                    case ElegirFoto.Volver:
                        botonSalir.Image = img1;
                        break;

                    case ElegirFoto.Salir:
                        botonSalir.Image = img2;
                            break;
                    
                }
            }
        }*/


        /*[(Category("Editores")]
        public Image Imagen
        {
            get
            {
                return img;
            }
            set
            {
                img = value;
                botonSalir.Image = img;
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
                botonSalir.ImageSize = imgSize;
            }
        }
        [Category("Editores")]
        public int Radio
        {
            get { return bRadius; }
            set
            {
                bRadius = value;
                botonSalir.Radius = bRadius;
            }

        }

        public btnSalir()
        {
            InitializeComponent();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
