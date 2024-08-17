using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace library_backend.Helper
{
    public static class EnumExtension
    {
        public static string GetDescription<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }
        public static T GetValueFromDescription<T>(string description) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(DescriptionAttribute), true).Cast<DescriptionAttribute>().FirstOrDefault();
                if (attribute != null)
                {
                    if (attribute.Description == description) return (T)field.GetValue(null);
                }
            }

            throw new ArgumentException("Not found.", nameof(description));
        }
    }
}
