using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ContentControlAndControlTemplate
{
    public class ShapeTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var shapeName = item as string;
            if (shapeName == "Rectangle")
            {
                return Application.Current.MainWindow.FindResource("rectangleContent") as DataTemplate;
            }
            else if (shapeName == "Ellipse")
            {
                return Application.Current.MainWindow.FindResource("ellipseContent") as DataTemplate;
            }
            return base.SelectTemplate(item, container);
        }
    }
}
