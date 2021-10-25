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
        private Color arribColor;
        private Color abajColor;
        private Color arribHover;
        private Color abajHover;

        private Size tamaño;
        private Image img;
        private Size imgSize;

        private String text;

        

        // Declares the name and type of the property.
        [Category("Colores")]
        public Color Color1_Arriba
        {
            // Retrieves the value of the private variable colBColor.
            get
            {
                return abajColor;
            }
            // Stores the selected value in the private variable colBColor, and
            // updates the background color of the label control lblDisplay.
            set
            {
                abajColor = value;
                botonPrimary.BaseColor1 = abajColor;
            }
        }
        // Provides a similar set of instructions for the foreground color.
        [Category("Colores")]
        public Color Color2_Abajo
        {
            get
            {
                return arribColor;
            }
            set
            {
                arribColor = value;
                botonPrimary.BaseColor2 = arribColor;
            }
        }

        [Category("Colores")]
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
        [Category("Colores")]
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
                botonPrimary.Text = text = text.Replace("@", " "+ "\n"); 
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

        public btnPrimary()
        {
            InitializeComponent();
        }
    }
}
