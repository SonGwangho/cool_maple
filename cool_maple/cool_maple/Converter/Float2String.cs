using System.Globalization;
using System.Windows.Data;

namespace cool_maple.Converter
{
    public class Float2String : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (MathF.Floor((float)value * 100f)/100).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
