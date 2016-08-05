using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace Day04.Core.Converters
{
    public class StringLengthValueConverter : MvxValueConverter<string, int>
    {
        protected override int Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return 0;
            return value.Length;
        }
    }
}
