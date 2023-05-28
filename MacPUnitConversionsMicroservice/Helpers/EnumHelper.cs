using System.ComponentModel.DataAnnotations;
using System;
using System.Reflection;

namespace MacPUnitConversionsMicroservice.Helpers
{
    public static class EnumHelper
    {
        public static string GetEnumDisplayName(Enum value)
        {
            if (value == null)
            {
                return "";
            }
            DisplayAttribute att = value.GetAttribute<DisplayAttribute>();
            if (att != null)
            {
                return att.Name;
            }
            else
            {
                return value.ToString();
            }
        }

        private static T GetAttribute<T>(this Enum enumVal) where T : System.Attribute
        {
            Type? type = enumVal.GetType();
            MemberInfo[] memInfo = type.GetMember(enumVal.ToString());
            object[] attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }
    }
}
