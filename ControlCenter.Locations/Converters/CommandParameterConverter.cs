using System;
using System.Globalization;
using System.Windows.Data;

namespace ControlCenter.Locations.Converters
{
    public class CommandParameterConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is string uid && values[1] is string x && values[2] is string y && values[3] is string z &&
                values[4] is string angle)
            {
                return new Tuple<string, string>(uid, x + ";" + y + ";" + z + ";" + angle);
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}