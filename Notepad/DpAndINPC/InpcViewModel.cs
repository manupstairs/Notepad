using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DpAndINPC
{
    public class InpcViewModel : INotifyPropertyChanged
    {
        private string age;

        public string Age
        {
            get { return age; }
            set
            {
                age = value;
                this.OnPropertyChanged();
            }
        }

        public ObservableCollection<int> Numbers { get; set; } = new ObservableCollection<int>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
