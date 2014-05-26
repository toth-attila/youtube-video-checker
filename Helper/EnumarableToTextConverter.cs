using System;
using System.Collections;
using System.Text;
using System.Windows.Data;

namespace YoutubeVideoChecker.Helper
{
    public class EnumarableToTextConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is IEnumerable)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var s in value as IEnumerable)
                {
                    sb.AppendLine(s.ToString());
                }
                return sb.ToString();
            }
            return string.Empty;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
