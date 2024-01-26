using PinPong.Core;

namespace ConsolaPingPong
{
    public class Jugador : IGameObject
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; } = 0;
        public object? Source {  get; set; }

        public int Score { get; set; }

        public ICommand MoveUp { get; set; }
        public ICommand MoveDown { get; set; }

        public ConsoleKey KeyUp { get; set; } = ConsoleKey.UpArrow;
        public ConsoleKey KeyDown { get; set; } = ConsoleKey.DownArrow;


        public Jugador() {
            MoveDown = new GameCommand(Down, CanMove);
            MoveUp = new GameCommand(Up, CanMove);
        }

        private bool CanMove(object parameter)
        {
            ConsoleKeyInfo keyInfo = (ConsoleKeyInfo)parameter;
            
            if (keyInfo.Key == KeyUp)
            {
                return PositionY > 1;
            }

            if (keyInfo.Key == KeyDown)
            {
                return PositionY < 10;
            }

            return false;
        }
        private void Up(object parameter) {
            ConsoleKeyInfo keyInfo = (ConsoleKeyInfo)parameter;
            if (keyInfo.Key != KeyUp)
            {
                PositionY++;
            }
        }

        private void Down(object parameter)
        {
            ConsoleKeyInfo keyInfo = (ConsoleKeyInfo)parameter;
            if (keyInfo.Key != KeyDown)
            {
                PositionY--;
            }
        }

        public void OnDraw()
        {
            #region Se pinta Jugador A
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(Source);
            #endregion
           
        }
    }
}
