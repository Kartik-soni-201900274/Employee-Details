using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Employee_Details
{
    public static class StringExtensions
    {
         public static string ToCamelCase(this string inputString)
        {
            string[] words = inputString.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i].ToLower());
            }

            return String.Join(" ", words);
        }
    }
}
