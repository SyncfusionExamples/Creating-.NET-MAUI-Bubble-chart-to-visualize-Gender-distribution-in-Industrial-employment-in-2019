using System;
using System.Collections.Generic;
using System.Globalization;

namespace EmployementDistribution
{
    public class PopulationValueConver : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double population)
            {
                if (population > 999999999)
                {
                    return (population / 1000000000).ToString("0.00 B");
                }
                if (population > 999999)
                {
                    return (population / 1000000).ToString("0.00 M");
                }
                else
                {
                    return population;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
