using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _9.CW_8._11._2020_Delegates
{
    public static class ExampleExtentions
    {
        public static int NumberWords(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return 0;
            }
            data = Regex.Replace(data.Trim(), @"\s+", " ");
            return data.Split(' ').Length;
        }

        public static string NumberWords(this string data, string word)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException();
            }
            return data + ' ' + word;
        }
    }
}
