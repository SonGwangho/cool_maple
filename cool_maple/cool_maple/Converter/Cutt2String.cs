using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace cool_maple.Converter
{
    public class Cutt2String : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is string))
                return "";

            if (value.ToString() == "255")
                return "교환 불가";

            return value.ToString() + "회";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
