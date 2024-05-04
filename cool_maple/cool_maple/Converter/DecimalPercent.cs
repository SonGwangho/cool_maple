using System.Globalization;
using System.Windows.Data;

namespace cool_maple.Converter
{
    public class DecimalPercent : IValueConverter
    {
        public object Convert(object values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.ToString() + "%";
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
