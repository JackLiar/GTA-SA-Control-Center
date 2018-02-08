using System;
using System.Globalization;
using System.Windows.Data;

namespace ControlCenter.Cheats.Converters
{
    public class CommandParameterConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is string uid && values[1] is string code)
            {
                return new Tuple<string, string>(uid, code);
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}