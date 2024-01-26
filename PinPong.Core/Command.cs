using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinPong.Core
{
    public class GameCommand : ICommand
    {
        Action<object> _execute;
        Func<object, bool> _canExecute;

      
        public GameCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute(parameter);
            }
            else
            {
                return false;
            }
        }
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
