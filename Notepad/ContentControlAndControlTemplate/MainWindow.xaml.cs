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

namespace ContentControlAndControlTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ShapeItem> Items { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Items = new List<ShapeItem>
            {
                new ShapeItem
                {
                    Shape = "Rectangle",
                    Color = "Red"
                },
                new ShapeItem
                {
                    Shape = "Ellipse",
                    Color = "Blue"
                },
                new ShapeItem
                {
                    Shape = "Rectangle",
                    Color = "Green"
                },
                new ShapeItem
                {
                    Shape = "Ellipse",
                    Color = "Yellow"
                }
            };
            this.DataContext = this;
        }
    }

    public class ShapeItem
    {
        public string Shape { get; set; }

        public string Color { get; set; }
    }
}
