using SimplyEnglish.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace SimplyEnglish.Converter
{
    public class VisibilityPanelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var visibility = (Answer)value;
            if ((string)parameter == "1" &&  visibility == Answer.WrongAnswer)
                return Visibility.Visible;
            if ((string)parameter == "2" && visibility != Answer.WrongAnswer)
                return Visibility.Visible;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
