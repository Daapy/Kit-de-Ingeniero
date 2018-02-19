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
        //variable que manejar la excepcion de que el boton seleccionado vuelva a la normalidad al se abandonado por el mouse
        public int opcionSeleccionada;
        //
        

        private void btn_Click(object sender, EventArgs e)
        {
            controlarInterfaz(0, btnConvertUnid, lblConvertUnid);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            controlarInterfaz(1, btnFormGene, lblFormGene);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            controlarInterfaz(3, btnGaussJordan, lblGaussJordan);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            controlarInterfaz(2, btnCalculadora, lblCalculadora);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            controlarInterfaz(4, btnFisica, lblFisica);
        }

        private void btnConvertUnid_MouseMove(object sender, MouseEventArgs e)
        {
            rellenarIcono(0, btnConvertUnid, lblConvertUnid);
        }

        private void btnConvertUnid_MouseLeave(object sender, EventArgs e)
        {
            normalizarIcono(0, btnConvertUnid, lblConvertUnid);
        }

        private void btnFormGene_MouseMove(object sender, MouseEventArgs e)
        {
            rellenarIcono(1, btnFormGene, lblFormGene);
        }

        private void btnFormGene_MouseLeave(object sender, EventArgs e)
        {
            normalizarIcono(1, btnFormGene, lblFormGene);
        }

        private void btnGaussJordan_MouseMove(object sender, MouseEventArgs e)
        {
            rellenarIcono(2, btnGaussJordan, lblGaussJordan);
        }

        private void btnGaussJordan_MouseLeave(object sender, EventArgs e)
        {
            normalizarIcono(2, btnGaussJordan, lblGaussJordan);
        }

        private void btnCalculadora_MouseMove(object sender, MouseEventArgs e)
        {
            rellenarIcono(3, btnCalculadora, lblCalculadora);
        }

        private void btnCalculadora_MouseLeave(object sender, EventArgs e)
        {
            normalizarIcono(3, btnCalculadora, lblCalculadora);
        }

        private void btnFisica_MouseMove(object sender, MouseEventArgs e)
        {
            rellenarIcono(4, btnFisica, lblFisica);
        }

        private void btnFisica_MouseLeave(object sender, EventArgs e)
        {
            normalizarIcono(4, btnFisica, lblFisica);
        }

        //funcion que controla el orden de los controles en base al boton seleccionado
        private void controlarInterfaz(int numInterfaz, PictureBox img, Label lbl)
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

        //funcion para rellenar el icono del footer al pasar el mouse sobre el.
        private void rellenarIcono(int numBtn, PictureBox img, Label lbl)
        {
            switch (numBtn)
            {
                case 0:
                    img.Image = Properties.Resources.imgUnidadesNaranja;
                    lbl.ForeColor = Color.FromArgb(247, 182, 51);
                    break;
                case 1:
                    img.Image = Properties.Resources.imgFormulaNaranja;
                    lbl.ForeColor = Color.FromArgb(247, 182, 51);
                    break;
                case 2:
                    img.Image = Properties.Resources.imgGaussNaranja;
                    lbl.ForeColor = Color.FromArgb(247, 182, 51);
                    break;
                case 3:
                    img.Image = Properties.Resources.imgCalculadoraNaranaja;
                    lbl.ForeColor = Color.FromArgb(247, 182, 51);
                    break;
                case 4:
                    img.Image = Properties.Resources.imgFIsicaNaranja;
                    lbl.ForeColor = Color.FromArgb(247, 182, 51);
                    break;
            }
        }

        //funcion para regresar el icono a la normalidad al abandonar el control
        private void normalizarIcono(int numBtn, PictureBox img, Label lbl)
        {
            switch (numBtn)
            {
                case 0:
                     img.Image = Properties.Resources.imgUnidadesBlanca;
                     lbl.ForeColor = Color.White;
                    break;
                case 1:
                     img.Image = Properties.Resources.imgFormulaBlanca;
                     lbl.ForeColor = Color.White;
                    break;
                case 2:
                     img.Image = Properties.Resources.imgGaussBlanca;
                     lbl.ForeColor = Color.White;
                    break;

                case 3:
                    img.Image = Properties.Resources.imgCalculadoraBlanca;
                    lbl.ForeColor = Color.White;
                    break;
                case 4:
                    img.Image = Properties.Resources.imgFIsicaBlanca;
                    lbl.ForeColor = Color.White;
                    break;
            }
        }
    }
}
