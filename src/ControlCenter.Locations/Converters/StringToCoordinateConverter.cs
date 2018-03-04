using System;
using System.Globalization;
using System.Windows.Data;
using ControlCenter.Locations.Models;

namespace ControlCenter.Locations.Converters
{
    public class StringToCoordinateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var split = (value as string)?.Split(';');
            if (split != null)
            {
                float.TryParse(split[0], out var x);
                float.TryParse(split[1], out var y);
                float.TryParse(split[2], out var z);
                float.TryParse(split[3], out var angle);
                return new Coordinate(x, y, z, angle);
            }
            return new Coordinate(0,0,0,0);
        }

        public static Coordinate Convert(string vector)
        {
            var split = (vector as string)?.Split(';');
            if (split != null)
            {
                float.TryParse(split[0], out var x);
                float.TryParse(split[1], out var y);
                float.TryParse(split[2], out var z);
                float.TryParse(split[3], out var angle);
                return new Coordinate(x, y, z, angle);
            }
            return new Coordinate(0, 0, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
