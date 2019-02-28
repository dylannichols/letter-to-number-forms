using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_to_number_forms
{
    class WordPercentage
    {
        public static string WordToPercent(string s)
        {
            int total = 0;
            foreach (char c in s)
            {
                total += CharToInt(c);
            }
            return total + "%";
        }

        public static int CharToInt(char c)
        {
            if (Char.IsLetter(c))
            {
                if (Char.IsUpper(c))
                {
                    return c - 'A' + 1;
                }
                else
                {
                    return c - 'a' + 1;
                }
            }
            return 0;
        }
    }
}
