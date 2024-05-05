using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace cool_maple.Converter
{
    public class Type2Color : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is string))
                return Brushes.Transparent;

            string typeColor = "#cccccc";

            switch (value.ToString())
            {
                case "레전드리":
                    typeColor = "#00ff00";
                    break;
                case "유니크":
                    typeColor = "#ffcc00";
                    break;
                case "에픽":
                    typeColor = "#cc66ff";
                    break;
                case "레어":
                    typeColor = "#4e77aa";
                    break;
            }

            try
            {
                return new SolidColorBrush((Color)ColorConverter.ConvertFromString(typeColor));
            }
            catch (FormatException)
            {
                // 문자열이 올바른 형식이 아닌 경우, Brushes.Transparent를 반환합니다.
                return Brushes.Transparent;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
