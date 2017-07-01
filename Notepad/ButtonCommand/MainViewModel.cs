using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ButtonCommand
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int? selectedItem;
        public int? SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                this.OnPropertyChanged();
            }
        }

        public ObservableCollection<int> Items { get; set; }

        public ICommand AddCommand { get; set; } 
        
        public ICommand DelCommand { get; set; }

        public CommandBindingCollection CommandBindings { get; set; }

        public MainViewModel()
        {
            Items = new ObservableCollection<int>();
            AddCommand = new EasyCommand(AddItem);
            DelCommand = new RoutedUICommand();
            var delCommandBinding = new CommandBinding(DelCommand, DeleteItem);
            CommandBindings = new CommandBindingCollection
            {
                delCommandBinding
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void AddItem()
        {
            Items.Add(new Random().Next(100));
        }

        private void DeleteItem(object sender, ExecutedRoutedEventArgs e)
        {
            if (this.SelectedItem.HasValue)
            {
                this.Items.Remove(this.SelectedItem.Value);
            }
        }
    }
}
