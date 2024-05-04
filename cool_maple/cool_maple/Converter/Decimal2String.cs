using System.Globalization;
using System.Windows.Data;

namespace cool_maple.Converter
{
    public class Decimal2String : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null) return "";
            string[] units = { " 만", " 억", " 조", " 경", " 해" };
            string str = value.ToString();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            str = new string(arr);

            string result = "";
            int unitIdx = 0;

            while (str.Length > 0)
            {
                if (str.Length > 4) 
                {
                    result += str.Substring(0, 4) + units[unitIdx];
                    str = str.Substring(4);
                    unitIdx++;
                }
                else
                {
                    result += str.Substring(0, str.Length);
                    break;
                }
            }
            arr = result.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
