using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InteractivityAndCommand
{
    public class MainViewModel : IShowMessage
    {
        public ICommand SelectCommand { get; set; }

        public ICommand StarCommand { get; set; }

        public ICommand AvatarCommand { get; set; }

        public MainViewModel()
        {
            this.SelectCommand = new EasyCommand(Select);
            this.StarCommand = new EasyCommand(Star);
            this.AvatarCommand = new EasyCommand(Avatar);
        }

        public event EventHandler<string> ShowMessageEvent;

        private void Select()
        {
            ShowMessageEvent?.Invoke(this, "Select");
        }

        private void Star()
        {
            ShowMessageEvent?.Invoke(this, "Star");
        }

        private void Avatar()
        {
            ShowMessageEvent?.Invoke(this, "Avatar");
        }
    }
}
