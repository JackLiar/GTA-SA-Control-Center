using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using ControlCenter.Cheats.Models;

namespace ControlCenter.Cheats.Converters
{
    public class CheatListConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var list = (ObservableCollection<string>) values[0];
            var dic = (Dictionary<string, Cheat>) values[1];
            var result = new ObservableCollection<Cheat>();

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
