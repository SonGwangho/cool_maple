using System.Globalization;
using System.Windows.Data;

namespace cool_maple.Converter
{
    public class Int2DotString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "";
            return string.Format(CultureInfo.InvariantCulture, "{0:#,0}", (int)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
