using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LearnAttributes
{
    internal static class PropertyInfoExtension
    {
        public static IEnumerable<Attribute> GetAttributes(this PropertyInfo prop)
        {
            var data = new List<Attribute>();
            return prop.GetCustomAttributes(true).Select(a => (Attribute)a);
        }

        public static bool HasAttribute(this PropertyInfo prop, Type attribute)
        {
            return prop.GetAttributes().Any(a => a.GetType() == attribute);
        }

        public static object[] GetAttributes(this PropertyInfo prop, Type attrType, bool inherit)
        {
            return prop.GetCustomAttributes(attrType, inherit);
        }
    }
}
