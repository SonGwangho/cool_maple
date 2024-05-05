using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace cool_maple.Converter
{
    public class String2Url : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is string))
                return null;

            // 문자열을 이미지로 변환하여 반환합니다.
            try
            {
                string imagePath = (string)value;
                return new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
