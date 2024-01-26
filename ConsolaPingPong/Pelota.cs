using PinPong.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPingPong
{
    public class Pelota : IGameObject
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; } = 0;
        public int SpeedX { get; set; } = 1;
        public int SpeedY { get; set; } = 1;
        public object Source { get; set; } = "*";
        
        public void OnDraw()
        {
            #region Se pinta pelota
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(Source);
            #endregion
        }

        public void Move(int maxWidth, int maxHight)
        {
            PositionX += SpeedX;
            PositionY += SpeedY;

            if (PositionX >= maxWidth)
                SpeedX = -1;

            if (PositionX <= 1)
                SpeedX = 1;

            if (PositionY >= maxHight -1)
                SpeedY = -1;

            if (PositionY <= 1)
                SpeedY = 1;
        }
    }
}
