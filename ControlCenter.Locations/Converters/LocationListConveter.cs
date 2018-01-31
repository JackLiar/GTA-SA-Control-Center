using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using ControlCenter.Locations.Models;

namespace ControlCenter.Locations.Converters
{
    public class LocationListConveter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var list = (ObservableCollection<string>) values[0];
            var dic = (Dictionary<string, Location>) values[1];
            var result = new ObservableCollection<Location>();

            if (list != null && dic != null)
            {
                foreach (var s in list)
                {
                    try
                    {
                        result.Add(dic[s]);
                    }
                    catch (KeyNotFoundException e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}