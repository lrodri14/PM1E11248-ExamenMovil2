using System;
using Xamarin.Forms;
namespace PM2E11248.Controllers

{
    public class ByteArrayImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Xamarin.Forms.ImageSource image = null;

            if (value != null)
            {
                byte[] bytesImage = (byte[])value;
                var stream = new System.IO.MemoryStream(bytesImage);
                image = Xamarin.Forms.ImageSource.FromStream(() => stream);
            }

            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}