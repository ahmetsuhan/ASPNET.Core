using System;
using System.Collections.Generic;
using System.Text;

namespace Extension.TypeExtension
{
    public static class StringExtension
    {


        public static bool IsEmpty(this string p)
        {
            return string.IsNullOrWhiteSpace(p);
        }
        public static bool IsFilled(this string p)
        {
            return !IsEmpty(p);
        }

        public static string ToUpper(this string p )
        {
            return p.ToUpper();
        }


        public static string ToLower(this string p)
        {
            return p.ToLower();
        }

    }
}
