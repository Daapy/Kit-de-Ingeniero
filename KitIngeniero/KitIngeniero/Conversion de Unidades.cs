using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitIngeniero
{
    public partial class Conversion_de_Unidades : UserControl
    {
        public Conversion_de_Unidades()
        {
            InitializeComponent();
        }

        private void btnConvA_Click(object sender, EventArgs e)
        {
            if (btnKiloA.selected==true)
            {
                if (btnOnzaB.selected==true)
                {
                    txbResA.Text= (Convert.ToInt16(txbUnidadA.Text) * (35.274)).ToString();

                }
                if (btnLibB.selected==true)
                {
                    txbResA.Text = (Convert.ToInt16(txbUnidadA.Text) * (2.20462)).ToString();
                }
            }

            if (btnOnzaA.selected == true)
            {
                if (btnKiloB.selected == true)
                {
                    txbResA.Text = (Convert.ToInt16(txbUnidadA.Text) * (0.0283495)).ToString();

                }
                if (btnLibB.selected == true)
                {
                    txbResA.Text = (Convert.ToInt16(txbUnidadA.Text) * (0.0625)).ToString();
                }
            }

            if (btnLibA.selected == true)
            {
                if (btnKiloB.selected == true)
                {
                    txbResA.Text = (Convert.ToInt16(txbUnidadA.Text) * (0.453592)).ToString();

                }
                if (btnOnzaB.selected == true)
                {
                    txbResA.Text = (Convert.ToInt16(txbUnidadA.Text) * (16)).ToString();
                }
            }
        }

        private void btnKiloA_Click(object sender, EventArgs e)
        {
            btnKiloB.Enabled = false;
            btnOnzaB.Enabled = true;
            btnLibB.Enabled = true;
        }

        private void btnOnzaA_Click(object sender, EventArgs e)
        {
            btnKiloB.Enabled = true;
            btnOnzaB.Enabled = false;
            btnLibB.Enabled = true;
        }

        private void btnLibA_Click(object sender, EventArgs e)
        {
            btnKiloB.Enabled = true;
            btnOnzaB.Enabled = true;
            btnLibB.Enabled = false;
        }
    }
}
