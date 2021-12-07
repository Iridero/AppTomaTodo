using System;
using System.Collections.Generic;
using System.Text;

namespace AppTomaTodo
{
    public class Pirinola
    {
        public int FichasJugador { get; private set; }
        public int FichasComputadora { get; set; }
        public int Pozo { get; private set; }

        public delegate void PirinolaJuegoTerminado();
        
        public delegate void PirinolaJugadorPozo(int cantidad);
        public delegate void PirinolaComputadoraPozo(int cantidad);
        public delegate void PirinolaPozoVacio();

        public event PirinolaJuegoTerminado JugadorGana;
        public event PirinolaJuegoTerminado JugadorPierde;
        public event PirinolaJugadorPozo JugadorPozo;
        public event PirinolaComputadoraPozo ComputadoraPozo;
        public event PirinolaPozoVacio PozoVacio;

        Random r;
        public void IniciarJuego()
        {
            Pozo = 0;
            FichasComputadora = 10;
            FichasJugador = 10;
            r = new Random();
        }
        /*
         * 0 = Toma todo
         * 1 = Pon 1
         * 2 = Toma 2
         * 3 = Todos Ponen
         * 4 = Toma 1
         * 5 = Pon 2
         */
        public int GirarPirinola(bool EsTurnoJugador)
        {
            int valor = r.Next(6);
            switch (valor)
            {
                case 0:
                    if (EsTurnoJugador)
                    {
                        FichasJugador += Pozo;
                        JugadorPozo?.Invoke(Pozo);
                    }
                    else
                    {
                        FichasComputadora += Pozo;
                        ComputadoraPozo?.Invoke(Pozo);
                    }
                    Pozo = 0;
                    JugadorPozo?.Invoke(1);
                    ComputadoraPozo?.Invoke(1);
                    break;
                case 1:
                    if (EsTurnoJugador)
                    {
                        JugadorPozo?.Invoke(-1);
                        FichasJugador--;
                        if (FichasJugador <= 0)
                        {
                            JugadorPierde?.Invoke();
                        }
                    }
                    else
                    {
                        ComputadoraPozo?.Invoke(-1);
                        FichasComputadora--;
                        if (FichasComputadora<=0)
                        {
                            JugadorGana?.Invoke();
                        }
                    }
                    Pozo++;
                    break;
                case 2:
                    if (EsTurnoJugador)
                    {
                        if (Pozo>2)
                        {
                            JugadorPozo?.Invoke(2);
                            FichasJugador+=2;
                            Pozo -= 2;
                        }
                        else
                        {
                            JugadorPozo?.Invoke(Pozo);
                            FichasJugador += Pozo;
                            Pozo = 0;
                            JugadorPozo?.Invoke(1);
                            ComputadoraPozo?.Invoke(1);
                        }
                        
                    }
                    else
                    {
                        if (Pozo > 2)
                        {
                            ComputadoraPozo?.Invoke(2);
                            FichasComputadora += 2;
                            Pozo -= 2;
                        }
                        else
                        {
                            ComputadoraPozo?.Invoke(Pozo);
                            FichasComputadora += Pozo;
                            Pozo = 0;
                            JugadorPozo?.Invoke(1);
                            ComputadoraPozo?.Invoke(1);
                        }

                    }
                    
                    break;
                default:
                    break;
            }
            return valor;
        }
    }
}
