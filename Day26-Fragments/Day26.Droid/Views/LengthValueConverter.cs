using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace Day26.Droid.Views
{
    public class LengthValueConverter : MvxValueConverter<string, int>
    {
        protected override int Convert(string value, Type targetType, object parameter, CultureInfo culture) => value.Length;
    }
}
