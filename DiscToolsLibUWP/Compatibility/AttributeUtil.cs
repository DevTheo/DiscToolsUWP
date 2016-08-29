using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscUtils.Partitions;
using System.Reflection;

namespace DiscUtils
{
    internal static class AttributeUtil
    {
        internal static IEnumerable<object> GetCustomAttributes(Type type, Type attr, bool v)
        {
            return type.GetTypeInfo().CustomAttributes.Where(ca => ca.GetType() == attr).Select( i => (object)i);
        }
        internal static object GetCustomAttribute(Type type, Type attr, bool v)
        {
            return GetCustomAttributes(type, attr, v).Where(i => i != null).FirstOrDefault();
        }
    }
}
