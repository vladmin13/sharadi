using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace Sharadi.Converters
{
    public class Base64toImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ImageSource.FromStream(() => new MemoryStream(System.Convert.FromBase64String(value.ToString())));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}