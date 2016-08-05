﻿using System;
using System.Globalization;
using System.Text;
using MvvmCross.Platform.Converters;

namespace Day04.Core.Converters
{
    public class StringReverseValueConverter : MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            
            return Reverse(value);
        }

        protected override string ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            return Reverse(value);
        }

        private static string Reverse(string value)
        {
            if (value == null)
                return string.Empty;

            var stringBuilder = new StringBuilder(value.Length);

            for (var i = value.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(value[i]);
            }
            return stringBuilder.ToString();
        }
    }
}