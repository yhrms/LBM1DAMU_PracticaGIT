using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_P2._3E_J2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;
            int numPalabrasAdicionales;

            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // telegrama urgente?
            if (rbUrgente.Checked)
                tipoTelegrama = 'u';

            //Obtengo el número de palabras que forma el telegrama
            //numPalabras = textoTelegrama.Length;
            numPalabras = textoTelegrama.Split(' ').Length;

            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                {
                    numPalabrasAdicionales = numPalabras - 10;
                    coste = (0.5 * numPalabrasAdicionales) + 2.5;
                }
                    
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbUrgente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
