using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitIngeniero
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        //variable que controla el comportamiento de la interfaz
        public int numInterfaz;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            controlarInterfaz(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            controlarInterfaz(1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            controlarInterfaz(3);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            controlarInterfaz(2);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            controlarInterfaz(4);
        }




        //funcion para ocultar de la vista del usuario los controles de usuario (opciones) de la ventana principal
        private void limpiarHome(Form home)
        {
            foreach (var item in home.Controls)
            {
                //el foreach recorre todos los controles del form home, si encuentra un Control de Usuario lo oculta.
                //la condicion tambien impide que oculte controles ocultos, se traduce en en ahorro de recursos.
                if (item is UserControl && (((UserControl)item).Location == new Point(0, 46) || ((UserControl)item).Location == new Point(-2, 43)))
                {

                    ((UserControl)item).Visible = false;
                    ((UserControl)item).Location = new Point(500, 46);
                }
            }
        }

        //funcion que controla el orden de los controles en base al boton seleccionado
        private void controlarInterfaz(int numInterfaz)
        {
            //limpiamos el tablero antes de colocar un control (evita que se amontonen)
            limpiarHome(this);

            switch (numInterfaz)
            {
                case 0:
                    converUnidades.Location = new Point(-2, 43);
                    converUnidades.Visible = true;
                    break;
                case 1:
                    formGene.Location = new Point(0, 46);
                    formGene.Visible = true;
                    break;
                case 2:
                    gaussJordan.Location = new Point(0, 46);
                    gaussJordan.Visible = true;
                    break;
                case 3:
                    calculadora.Location = new Point(0, 46);
                    calculadora.Visible = true;
                    break;
                case 4:
                    fisica.Location = new Point(0, 46);
                    fisica.Visible = true;
                    break;
            }
        }

        
    }
}
