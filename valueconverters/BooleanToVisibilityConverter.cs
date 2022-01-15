using System;
using System.Globalization;
using System.Windows;
namespace Abituria
{
    public class BooleanToVisibilityConverter : BaseValueConverter<BooleanToVisibilityConverter>///Konwerter wartości logicznej na typ Visibility
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)///Metoda konwertuje jeden typ na drugi
        {
            if (parameter == null)
                return (bool)value ? Visibility.Hidden : Visibility.Visible;
            else
                return (bool)value ? Visibility.Visible : Visibility.Hidden;
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();///Metoda konwertuje wartość na typ źródłowy
    }
}