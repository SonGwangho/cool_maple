using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace cool_maple.Converter
{
    public class Type2String : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is string))
                return "";

            switch (value.ToString())
            {
                case "레전드리":
                    return "L";
                case "유니크":
                    return "U";
                case "에픽":
                    return "E";
                case "레어":
                    return "R";
            }

            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
