using System;
using System.Globalization;
using Day17.Core.Services.DataStore;
using MvvmCross.Platform.Converters;

namespace Day17.Core.Converters
{
    public class ItemLocationValueConverter : MvxValueConverter<CollectedItem>
    {
        protected override object Convert(CollectedItem value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!value.LocationKnown)
                return "unknown";

            return $"({value.Latitude:0.0000}, {value.Longitude:0.0000})";
        }
    }
}