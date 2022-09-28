using System;
using System.Windows.Data;

namespace AbisSkin.Controls.Converter
{
   /// <summary>
   /// 判断值是否为空
   /// </summary>
   public class StringIsEmptyConverter : IValueConverter
   {
      #region IValueConverter 成员

      public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
      {
         return string.IsNullOrEmpty(System.Convert.ToString(value));
      }

      public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
      {
         return null;
      }

      #endregion
   }
}
