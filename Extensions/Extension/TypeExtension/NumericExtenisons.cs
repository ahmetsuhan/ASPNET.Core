using System;
using System.Collections.Generic;
using System.Text;

namespace Extension.TypeExtension
{
    public static class NumericExtenisons
    {

        public
            static bool InRange(this int p , int start, int end)
        {
            return p >= start && p <= end;
        }

        public static bool NotInRange(this int p , int start, int end)
        {
            return !InRange(p,start,end);
        }

        public static int ConvertToCrossRate(this int p)
        {
            ///business code 
            const int crossRate = 7;
            return p *= crossRate;
        }

        public static bool IsPrimeNumber(this int p)
        {
            if (p <= 1)
            {
                return false;
            }
            if (p == 2 || p==3)
            {
                return true;
            }

            for (int i = 2; i < p; i++)
            {
                if(p%i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
