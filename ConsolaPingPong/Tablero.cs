using PinPong.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPingPong
{
    public class Tablero : IGameObject
    {
        public int Ancho { get; set; } = 50;
        public int Alto { get; set; } = 10;
        public Pelota Pelota { get; set; }
        public Tablero(Pelota pelota) {
            Pelota = pelota;
        }

        public void OnDraw()
        {
            for (int i = 0; i < Ancho; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("_");
                Console.SetCursorPosition(i, Alto);
                Console.Write("-");
            }
            for (int i = 1; i < Alto+1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(Ancho, i);
                Console.Write("|");
            }
        }
    }
}
