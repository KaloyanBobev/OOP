using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.ExtensionMethodSubstring
{
   public static class Substring
    {
        public static StringBuilder SubstringBiuld(this StringBuilder str, int index, int length)
        {
            if (index < 0 || length < 1 || index >= str.Length || length > str.Length || index + length > str.Length)
            {
                throw new ArgumentException("Wrong entered values!!!");
            }

            StringBuilder subStr = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                subStr.Append(str[i]);
            }

            return subStr;
        }

        public static StringBuilder SubstringBiuld(this StringBuilder str, int index)
        {

            if (index < 0 || index >= str.Length)
            {
                throw new ArgumentException("Wrong entered values!!!");
            }
            StringBuilder subStr = new StringBuilder();

            for (int i = index; i < str.Length; i++)
            {
                subStr.Append(str[i]);
            }

            return subStr;
        }

    }
}
