using PinPong.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPingPong
{
    public class Game
    {
        private IGameObject tablero;
        private Pelota pelota;
        private Jugador jugadorA;
        private Jugador jugadorB;

        private static Game? _instance;
        public static Game Instance { get
            {
                _instance ??= new Game();

                return _instance;
            }
            private set { }
        }

        
        private Game() {
            jugadorA = new Jugador();
            jugadorB = new Jugador();
            pelota = new Pelota();
            tablero = new Tablero(pelota);
            pelota.Source = "°";
            jugadorA.Source = "|";
            jugadorB.Source = "|";
            jugadorA.PositionX = 1;
            jugadorA.PositionY = ((Tablero)tablero).Alto /2 - 1;
            jugadorB.PositionX = ((Tablero)tablero).Ancho - 1;
            jugadorB.PositionY = ((Tablero)tablero).Alto / 2 - 1;
            jugadorB.KeyDown = ConsoleKey.A;
            jugadorB.KeyUp = ConsoleKey.Q;

            Console.CursorVisible = false;
        }
        public void OnPlay()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyinfo = Console.ReadKey(true);
                    
                    if (jugadorA.MoveDown.CanExecute(keyinfo))
                    {
                        jugadorA.MoveDown.Execute(keyinfo);
                    }

                    if (jugadorA.MoveUp.CanExecute(keyinfo))
                    {
                        jugadorA.MoveUp.Execute(keyinfo);
                    }

                    if (jugadorB.MoveDown.CanExecute(keyinfo))
                    {
                        jugadorB.MoveDown.Execute(keyinfo);
                    }

                    if (jugadorB.MoveUp.CanExecute(keyinfo))
                    {
                        jugadorB.MoveUp.Execute(keyinfo);
                    }
                }

                tablero.OnDraw();
                jugadorA.OnDraw();
                jugadorB.OnDraw();
                pelota.OnDraw();
                pelota.Move(((Tablero)tablero).Ancho, ((Tablero)tablero).Alto);
               
                
                Thread.Sleep(600);
                Console.Clear();


            }
        }

        public void OnPause() { 
        }
    }
}
