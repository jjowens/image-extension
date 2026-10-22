using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageExtension.json
{
    public static class ImageExtensionJson
    {

        public static string GetPropertyItemByNameAsJson(this Image img, ImagePropertyName propertyName)
        {
            if (!img.PropertyIdList.Contains((int)propertyName))
            {
                return string.Empty;
            }

            return string.Format("\"{0}\": \"{1}\"", propertyName.ToString(), img.GetPropertyItemValueByName(propertyName));
        }

        public static string GetPropertyItemsByNameAsJson(this Image img, ImagePropertyName[] propertyNames)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{");
            foreach (ImagePropertyName propertyName in propertyNames)
            {
                if (!img.PropertyIdList.Contains((int)propertyName))
                {
                    continue;
                }

                sb.AppendFormat("\"{0}\": \"{1}\",", propertyName.ToString(), img.GetPropertyItemValueByName(propertyName));
            }
            sb.Append("}");

            return sb.ToString();
        }

    }
}
