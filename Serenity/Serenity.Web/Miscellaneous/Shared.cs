using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serenity
{
    class Shared
    {
        public static string GetFormattedDisplayText(string text)
        {
            StringBuilder builder = new StringBuilder();
            char[] chArray = text.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                char c = chArray[i];
                char ch2 = (i < (chArray.Length - 1)) ? chArray[i + 1] : ' ';
                char ch3 = (i > 0) ? chArray[i - 1] : ' ';
                if (c == '_')
                {
                    c = ' ';
                }
                if (ch2 == '_')
                {
                    ch2 = ' ';
                }
                if (ch3 == '_')
                {
                    ch3 = ' ';
                }
                if ((((builder.Length > 0) && char.IsUpper(c)) && ((ch2 != ' ') && (ch3 != ' '))) && (!char.IsUpper(ch2) || !char.IsUpper(ch3)))
                {
                    builder.Append(' ');
                }
                builder.Append(c);
            }
            return builder.ToString();
        }

    }
}
