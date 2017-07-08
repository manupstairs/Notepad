using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad
{
    public class EasyCommand<T> : ICommand where T : class
    {
        private Action<T> EasyActoin { get; set; }

        public EasyCommand(Action<T> easyActoin)
        {
            this.EasyActoin = easyActoin;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.EasyActoin(parameter as T);
        }
    }
}
