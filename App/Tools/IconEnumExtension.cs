using System.ComponentModel;
using System.Reflection;
#nullable disable
namespace Tools
{
    public static class IconEnumExtension
    {
        /// <summary>
        /// 生成open iconic 图标库的 css 枚举类
        /// 该方法返回class内容
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetIconClass<T>(this T value)
        {
            string iconclass = value switch
            {
                OpenIconc _ => "oi oi-",
                BootstrapIcon _ => "bi bi-",
                _ => "bi bi-"
            };

            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return iconclass + attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
