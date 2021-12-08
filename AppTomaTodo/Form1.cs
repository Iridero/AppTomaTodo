using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTomaTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GirarA(int n)
        {
            
        }
        bool esTurnoJugador;
        bool juegoIniciado = false;
        int vueltas = 0;
        int actual = 0;
        int cara = 0;
        string[] caras = new string[] { "TOMA\nTODO", "PON\n1", "TOMA\n2", "TODOS\nPONEN", "TOMA\n1", "PON\n2" };
        private void tmrGiro_Tick(object sender, EventArgs e)
        {
            if (vueltas == 3)
            {
                tmrGiro.Interval += 200;
            }

            actual = ++actual % 6;
            lblPirinola.Text = caras[actual];

            if (cara == actual)
            {
                if (vueltas == 3)
                {
                    tmrGiro.Stop();
                    tmrGiro.Interval = 200;
                    vueltas = 0;
                    vueltas++;
                }
                else
                {
                    vueltas++;
                }
            }
        }

        private void lblPirinola_Click(object sender, EventArgs e)
        {
            if (!juegoIniciado)
            {
                pirinola.IniciarJuego();
                actual = 0;
            }
            cara = pirinola.GirarPirinola(esTurnoJugador);
            esTurnoJugador = !esTurnoJugador;
            vueltas = 0;
            tmrGiro.Interval = 200;
            tmrGiro.Start();
            /*Random random = new Random();
            cara = random.Next(6);
            tmrGiro.Start(); */
        }
        Pirinola pirinola = new Pirinola();
        private void Form1_Load(object sender, EventArgs e)
        {
            pirinola.JugadorGana += Pirinola_JugadorGana;
            pirinola.JugadorPierde += Pirinola_JugadorPierde;
            pirinola.JugadorPozo += Pirinola_JugadorPozo;
            pirinola.ComputadoraPozo += Pirinola_ComputadoraPozo;
        }

        private void Pirinola_ComputadoraPozo(int cantidad)
        {
            lblPozo.Text=$"Pozo: {pirinola.Pozo}";
            chkComputadora.Text = $"Computadora: {pirinola.FichasComputadora}";
        }

       

        private void Pirinola_JugadorPozo(int cantidad)
        {
            lblPozo.Text = $"Pozo: {pirinola.Pozo}";
            chkJugador.Text = $"Jugador: {pirinola.FichasComputadora}";
        }

        private void Pirinola_JugadorPierde()
        {
            MessageBox.Show("Lo siento, perdiste :(");
            juegoIniciado = false;
        }

        private void Pirinola_JugadorGana()
        {
            MessageBox.Show("Felicidades, Ganaste!");
            
            juegoIniciado = false;
        }
    }
}
