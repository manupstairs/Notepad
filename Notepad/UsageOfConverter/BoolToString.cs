using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace UsageOfConverter
{
    public class BoolToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? "YES" : "NO";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var yesOrNo = value.ToString();
            if (yesOrNo.Equals("YES", StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }

    public class StringToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Enum.Parse(typeof(Visibility), value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
