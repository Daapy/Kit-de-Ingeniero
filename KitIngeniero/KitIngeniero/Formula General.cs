using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formulaGeneral;

namespace KitIngeniero
{
    public partial class Formula_General : UserControl
    {
        public Formula_General()
        {
            InitializeComponent();
        }

        #region Funciones para el procesamiento y muestra de resultados
        /*
         * Funcion para la llamada del procesamiento y la precentación de resultados
         */
        void calculo()
        {
            try
            {
                // Variables locales
                double a = Convert.ToDouble(textA.Text);
                double b = Convert.ToDouble(textB.Text);
                double c = Convert.ToDouble(textC.Text);
                //Llamada del metodo
                double[] x = FG.calcularFG(a, b, c);
                // Muestra los resultados
                lblX1.Text = x[0].ToString();
                lblX2.Text = x[1].ToString();
                lblError.Text = "";
            }
            catch (Exception)
            {
                lblError.Text = "ERROR";
            }
        }

        /*
         * Funcion para limpiar las cajas de texto y los resultados
         */
        void limpiar()
        {
            lblX1.Text = "";
            lblX2.Text = "";
            textA.Text = "";
            textB.Text = "";
            textC.Text = "";
            lblError.Text = "";
        }
        #endregion

        private void btnResvrMatriz_Click(object sender, EventArgs e)
        {
            calculo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
