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
                case 0: // Toma Todo
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
                    TodosPonen();
                    break;
                case 1: // Pon 1
                    if (EsTurnoJugador)
                    {
                        FichasJugador--;
                        JugadorPozo?.Invoke(-1);
                        
                        
                    }
                    else
                    {
                        FichasComputadora--;
                        ComputadoraPozo?.Invoke(-1);
                        
                        
                    }
                    Pozo++;
                    break;
                case 2: // Toma 2
                    if (EsTurnoJugador)
                    {
                        if (Pozo>2)
                        {
                            FichasJugador += 2;
                            JugadorPozo?.Invoke(2);
                            
                            Pozo -= 2;
                        }
                        else
                        {
                            FichasJugador += Pozo;
                            JugadorPozo?.Invoke(Pozo);
         
                            Pozo = 0;
                            TodosPonen();
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
                            TodosPonen();
                        }

                    }
                    
                    break;
                case 3: // Todos ponen
                    TodosPonen();
                    break;
                case 4: //Toma 1
                    if (EsTurnoJugador)
                    {
                        FichasJugador++;
                        JugadorPozo?.Invoke(1);
                    }
                    else
                    {
                        FichasComputadora++;
                        ComputadoraPozo?.Invoke(1);
                    }
                    Pozo--;
                    if (Pozo==0)
                    {
                        TodosPonen();
                    }
                    break;
                case 5: //Pon 2
                    if (EsTurnoJugador)
                    {
                        if (FichasJugador>2)
                        {
                            FichasJugador -= 2;
                            JugadorPozo?.Invoke(-2);
                        }
                        else
                        {
                            int fichas = FichasJugador;
                            FichasJugador = 0;
                            JugadorPozo?.Invoke(fichas * -1);
                            JugadorPierde?.Invoke();
                        }
                    }
                    else
                    {
                        if (FichasComputadora > 2)
                        {
                            FichasComputadora -= 2;
                            ComputadoraPozo?.Invoke(-2);
                        }
                        else {
                            int fichas = FichasComputadora;
                            FichasComputadora = 0;
                            ComputadoraPozo?.Invoke(fichas * -1);
                            JugadorGana?.Invoke();
                        }
                    }
                    break;
                default:
                    break;
            }
            return valor;
        }

        private void TodosPonen()
        {
            FichasJugador--;
            FichasComputadora--;
            JugadorPozo?.Invoke(-1);
            ComputadoraPozo?.Invoke(-1);
        }
    }
}
