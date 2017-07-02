using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InteractivityAndCommand
{
    public class EasyCommand : ICommand
    {
        private Action EasyActoin { get; set; }

        public EasyCommand(Action easyActoin)
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
            this.EasyActoin();
        }
    }
}
