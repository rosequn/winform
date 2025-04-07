using System.ComponentModel;
using System.Reflection;

public static class EnumHelper
{
    public static string GetDescription(Enum value)
    {
        FieldInfo fi = value.GetType().GetField(value.ToString());
        DescriptionAttribute[] attributes =
            (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
        return attributes.Length > 0 ? attributes[0].Description : value.ToString();
    }

    public static List<KeyValuePair<Enum, string>> GetEnumListWithDescriptions<T>() where T : Enum
    {
        return Enum.GetValues(typeof(T))
            .Cast<Enum>()
            .Select(e => new KeyValuePair<Enum, string>(e, GetDescription(e)))
            .ToList();
    }
}
