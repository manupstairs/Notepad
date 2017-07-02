using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InteractivityAndCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel ViewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            ViewModel.ShowMessageEvent += ViewModel_ShowMessageEvent;
            this.DataContext = ViewModel;
        }

        private void ViewModel_ShowMessageEvent(object sender, string e)
        {
            MessageBox.Show(e);
        }
    }
}
