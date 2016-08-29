using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscUtils
{
    internal static class CompatibilityExtensions
    {
        internal static void Close(this Stream strm)
        {
            strm.Dispose();
        }

        internal static string ToUpper(this string str, CultureInfo ci)
        {
            return str.ToUpper();
        }
    }
}
