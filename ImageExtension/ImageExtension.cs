using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageExtension
{
    public static class ImageExtension
    {
        public static PropertyItem GetPropertyItemByName(this Image img, ImagePropertyName propertyName)
        {
            if (!img.PropertyIdList.Contains((int)propertyName))
            {
                return null;
            }

            return img.GetPropertyItem((int)propertyName);
        }

        public static string GetPropertyItemValueByName(this Image img, ImagePropertyName propertyName)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            if (!img.PropertyIdList.Contains((int)propertyName))
            {
                return string.Empty;
            }

            return encoding.GetString(img.GetPropertyItem((int)propertyName).Value).TrimEnd('\0');
        }

    }
}
