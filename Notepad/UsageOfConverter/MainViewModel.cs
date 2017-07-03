using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UsageOfConverter
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string visibilitySatus;

        public string VisibilitySatus
        {
            get { return visibilitySatus; }
            set {
                visibilitySatus = value;
                this.OnPropertyChanged();
            }
        }

        public List<string> Items { get; set; }

        public MainViewModel()
        {
            Items = new List<string>
            {
                "Visible","Hidden","Collapsed"
            };
            VisibilitySatus = "Visible";
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
