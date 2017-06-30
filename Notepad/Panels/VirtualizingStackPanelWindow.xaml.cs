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
using System.Windows.Shapes;

namespace Panels
{
    /// <summary>
    /// Interaction logic for VirtualizingStackPanelWindow.xaml
    /// </summary>
    public partial class VirtualizingStackPanelWindow : Window
    {
        public List<int> Items { get; set; } = new List<int>();

        public VirtualizingStackPanelWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 10000; i++)
            {
                Items.Add(i);
            }
            this.DataContext = this;
        }
    }
}
