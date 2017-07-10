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

namespace Notepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel MainViewModel { get; set; }

        private GridLength zeroGridLength = new GridLength(0);
        private GridLength oneStarGridLength = new GridLength(1, GridUnitType.Star);
        private GridLength fourStarGridLength = new GridLength(4, GridUnitType.Star);
        private GridLength sixStarGridLength = new GridLength(6, GridUnitType.Star);

        public MainWindow()
        {
            InitializeComponent();
            MainViewModel = new MainViewModel();
            MainViewModel.ScrollToItem += MainViewModel_ScrollToItem;
            this.DataContext = MainViewModel;
            this.SizeChanged += MainWindow_SizeChanged;
            
        }

        private void MainViewModel_ScrollToItem(object sender, NotepadPage e)
        {
            this.listView.ScrollIntoView(e);
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width <= 800)
            {
                if (listView.SelectedItem == null)
                {
                    columnRight.Width = zeroGridLength;
                    columnLeft.Width = oneStarGridLength;
                }
                else
                {
                    columnLeft.Width = zeroGridLength;
                    columnRight.Width = oneStarGridLength;
                }
            }
            else
            {
                columnLeft.Width = fourStarGridLength;
                columnRight.Width = sixStarGridLength;
            }
        }
    }
}
