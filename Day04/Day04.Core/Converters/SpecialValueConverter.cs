using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace Day04.Core.Converters
{
    public enum Special
    {
        WindowsPhone,
        Android,
        IOS
    };



    public class SpecialValueConverter : MvxValueConverter<string, Special>
    {
        protected override Special Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            value = value ?? "";
            if(value.Length <= 3)
                return Special.IOS;

            if (value.Length > 6)
                return Special.WindowsPhone;

            return Special.Android;
        }
    }
}