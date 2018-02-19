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

        private void btnKilotroA_Click(object sender, EventArgs e)
        {
            btnKilotroB.Enabled = false;
            btnYardaB.Enabled = true;
            btnPieB.Enabled = true;
        }

        private void btnYardaA_Click(object sender, EventArgs e)
        {
            btnKilotroB.Enabled = true;
            btnYardaB.Enabled = false;
            btnPieB.Enabled = true;
        }

        private void btnPieA_Click(object sender, EventArgs e)
        {
            btnKilotroB.Enabled = true;
            btnYardaB.Enabled = true;
            btnPieB.Enabled = false;
        }

        private void btnCentA_Click(object sender, EventArgs e)
        {
            btnCentB.Enabled = false;
            btnKelB.Enabled = true;
            btnFahrB.Enabled = true;
        }

        private void btnKelA_Click(object sender, EventArgs e)
        {
            btnCentB.Enabled = true;
            btnKelB.Enabled = false;
            btnFahrB.Enabled = true;
        }

        private void btnFahrA_Click(object sender, EventArgs e)
        {
            btnCentB.Enabled = true;
            btnKelB.Enabled = true;
            btnFahrB.Enabled = false;
        }

        private void btnConvB_Click(object sender, EventArgs e)
        {
            if (btnKilotroA.selected == true)
            {
                if (btnYardaB.selected == true)
                {
                    txbResB.Text = (Convert.ToInt16(txbUnidadB.Text) * (1093.61)).ToString();

                }
                if (btnPieB.selected == true)
                {
                    txbResB.Text = (Convert.ToInt16(txbUnidadB.Text) * (3280.84)).ToString();
                }
            }

            if (btnYardaA.selected == true)
            {
                if (btnKilotroB.selected == true)
                {
                    txbResB.Text = (Convert.ToInt16(txbUnidadB.Text) * (0.0009144)).ToString();

                }
                if (btnPieB.selected == true)
                {
                    txbResB.Text = (Convert.ToInt16(txbUnidadB.Text) * (3)).ToString();
                }
            }

            if (btnPieA.selected == true)
            {
                if (btnKilotroB.selected == true)
                {
                    txbResB.Text = (Convert.ToInt16(txbUnidadB.Text) * (0.0003048)).ToString();

                }
                if (btnYardaB.selected == true)
                {
                    txbResB.Text = (Convert.ToInt16(txbUnidadB.Text) * (0.333333)).ToString();
                }
            }
        }

        private void btnConvC_Click(object sender, EventArgs e)
        {
            if (btnCentA.selected == true)
            {
                if (btnFahrB.selected == true)
                {
                    txbResC.Text = (Convert.ToInt16(txbUnidadC.Text) * (33.8)).ToString();

                }
                if (btnKelB.selected == true)
                {
                    txbResC.Text = (Convert.ToInt16(txbUnidadC.Text) * (274.15)).ToString();
                }
            }

            if (btnKelA.selected == true)
            {
                if (btnCentB.selected == true)
                {
                    txbResC.Text = (Convert.ToInt16(txbUnidadC.Text) * (-272.15)).ToString();

                }
                if (btnFahrB.selected == true)
                {
                    txbResC.Text = (Convert.ToInt16(txbUnidadC.Text) * (-457.87)).ToString();
                }
            }

            if (btnFahrA.selected == true)
            {
                if (btnCentB.selected == true)
                {
                    txbResC.Text = (Convert.ToInt16(txbUnidadC.Text) * (-17.2222)).ToString();

                }
                if (btnKelB.selected == true)
                {
                    txbResC.Text = (Convert.ToInt16(txbUnidadC.Text) * (255.928)).ToString();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbUnidadA.Text = "";
            txbResA.Text = "";
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            txbUnidadB.Text = "";
            txbResB.Text = "";
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            txbUnidadC.Text = "";
            txbResC.Text = "";
        }
    }
}
