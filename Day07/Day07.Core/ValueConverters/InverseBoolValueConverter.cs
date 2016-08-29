﻿using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace Day07.Core.ValueConverters
{
    public class InverseBoolValueConverter : MvxValueConverter<bool, bool>
    {
        protected override bool Convert(bool value, Type targetType, object parameter, CultureInfo culture)
        {
            return ! value;
        }
    }
}
