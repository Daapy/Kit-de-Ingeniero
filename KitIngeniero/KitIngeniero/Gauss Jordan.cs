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
    public partial class Gauss_Jordan : UserControl
    {
        public Gauss_Jordan()
        {
            InitializeComponent();
        }

        private void Gauss_Jordan_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResvrMatriz_Click(object sender, EventArgs e)
        {

        }
        
        private void algoritmoGauss(ref double[,] matriz, int filas = 4, int columnas =3)
        {
            for (int filaPivote = 0; filaPivote < filas; filaPivote++)
            {
                double normalizar = matriz[filaPivote, filaPivote];
                for (int i = 0; i < columnas; i++)
                {
                    matriz[filaPivote, i] = matriz[filaPivote, i] / normalizar;
                }

                int filaActual = filaPivote + 1;
                if (filaActual == filas) filaActual = 0;

                for (int fila = 0; fila < filas - 1; fila++)
                {
                    double k = matriz[filaActual,filaPivote];

                    for (int c = filaPivote; c < columnas; c++)
                    {
                        matriz[filaActual, c] = matriz[filaActual, c] - (k * matriz[filaPivote, c]);
                    }
                    if (filaActual == filas - 1) filas = 0;
                    else filas++;
                }
            }
        }
    }
}
