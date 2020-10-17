using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen1Componentes
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generarCodigoAleatorio();
            textBoxJuego.Enabled = true;
            buttonComparar.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxJuego_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonComparar_Click(object sender, EventArgs e)
        {
            String intento = textBoxJuego.Text;

            intentoJuego(intento);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void labelParciales_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private void labelMisIntentos_Click(object sender, EventArgs e)
        {

        }

        private void labelNumAciertos_Click(object sender, EventArgs e)
        {

        }

        private void mensajeParcial_Click(object sender, EventArgs e)
        {

        }


        /* ****************************** */
        /* Funciones de lógica del juego */
        /* ****************************** */


        // Función que genera e código aleatorio
        private void generarCodigoAleatorio()
        {
            var obj = new Random();
            const string coloresChars = "ARBNVM";
            var longitud = coloresChars.Length;
            var codigo = "";

            for (int i = 0; i < 4; i++)
            {
                codigo += coloresChars[obj.Next(longitud)];
            }

            labelGanador.Text = codigo;
        }

        private void intentoJuego(String pIntento)
        {
            int aciertos = 0;
            String codigoJuego = labelGanador.Text;
            int intentosJugador = Int32.Parse(labelMisIntentos.Text);
            intentosJugador++;

            //Caracteres del código del juego
            String cod0 = codigoJuego.Substring(0, 1);
            String cod1 = codigoJuego.Substring(1, 1);
            String cod2 = codigoJuego.Substring(2, 1);
            String cod3 = codigoJuego.Substring(3, 1);

            //Caracteres del codigo ingresado
            String letra0 = pIntento.Substring(0, 1);
            String letra1 = pIntento.Substring(1, 1);
            String letra2 = pIntento.Substring(2, 1);
            String letra3 = pIntento.Substring(3, 1);

            if (pIntento.Equals(codigoJuego))
            {
                juegoGanado();
            }else{

                if (letra0.Equals(cod0))
                {
                    aciertos++;
                }
                if (letra1.Equals(cod1))
                {
                    aciertos++;
                }
                if (letra2.Equals(cod2))
                {
                    aciertos++;
                }
                if (letra3.Equals(cod3))
                {
                    aciertos++;
                }
            }

            if (aciertos == 0)
            {
                mensajeParcial.Visible = false;
                mensajeFallido.Visible = true;
                labelMisIntentos.Text = intentosJugador.ToString();

                int intentosDisponibles = 8 - intentosJugador;
                labelIntentosDisponibles.Text = intentosDisponibles.ToString();

                if (intentosJugador == 8)
                {
                    juegoPerdido();
                }
                textBoxJuego.Clear();

            }
            if(aciertos > 0){
                mensajeFallido.Visible = false;
                juegoParcial(aciertos, intentosJugador);
            }      
        }

        // Función que muestra mensaje de partida ganadas
        private void juegoGanado()
        {
            mensajeFallido.Visible = false;
            mensajeParcial.Visible = false;
            mensajeGanado.Visible = true;
            label7.Visible = true;
            labelGanador.Visible = true;
            textBoxJuego.Enabled = false;
            buttonComparar.Enabled = false;
        }

        // Función que muestra mensaje de acierto parcial
        private void juegoParcial(int pAciertos, int pIntentosJugador)
        {
            labelMisIntentos.Text = pIntentosJugador.ToString();
            int intentosParciales = Int32.Parse(labelParciales.Text);
            intentosParciales++;
            labelParciales.Text = intentosParciales.ToString();

            int intentosDisponibles = 8 - pIntentosJugador;
            labelIntentosDisponibles.Text = intentosDisponibles.ToString();

            mensajeParcial.Visible = true;

            if (pIntentosJugador == 8)
            {
                juegoPerdido();
            }
            textBoxJuego.Clear();
        }

        // Función que muestra mensaje de juego perdido
        private void juegoPerdido()
        {
            mensajePerdido.Visible = true;
            label7.Visible = true;
            labelGanador.Visible = true;
            buttonComparar.Enabled = false;
            textBoxJuego.Enabled = false;
        }
    }
}
