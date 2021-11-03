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
    public partial class PanelTitulo : UserControl
    {

        private Color cFondo = Color.FromArgb(0, 76, 155);
        private String text = "Botón";

        [Category("Editores")]
        public String Titulo
        {
            get { return text; }
            set
            {
                text = value;
                lblTitulo.Text = text;
            }
        }



        [Category("Editores")]
        public Color Color1_Arriba
        {
            get
            {
                return cFondo;
            }
            set
            {
                cFondo = value;
                pnlFondo.BackColor = cFondo;
            }
        }

        public PanelTitulo()
        {
            InitializeComponent();
        }
    }
}
