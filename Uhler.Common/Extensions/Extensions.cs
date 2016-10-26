using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Uhler.Common.Extensions
{
    public static class Extensions
    {
        public static DateTime ToDate(this string s)
        {
            DateTime dateTime;

            if (DateTime.TryParse(s, out dateTime))
                return dateTime;
            else
                return DateTime.MinValue;
        }

        public static int ToInt(this string s)
        {
            int intValue = 0;

            if (int.TryParse(s, out intValue))
                return intValue;
            else
                return 0;
        }

        public static Boolean ToBool(this string s)
        {
            Boolean boolValue;

            if (Boolean.TryParse(s, out boolValue))
                return boolValue;
            else
                return false;
        }

        public static int WordCount(this string s)
        {
            return s.Split(new char[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string Alphabetize(this string s)
        {
            char[] alphabetize = s.ToArray();
            Array.Sort(alphabetize);
            return new string(alphabetize);
        }
    }
}
