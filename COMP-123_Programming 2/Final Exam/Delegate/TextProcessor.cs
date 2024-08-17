using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class TextProcessor
    {
        public static string Uppercase(string text)
        {
            return text.ToUpper();
        }

        public static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);            
            return reversed;
        }
        public static string RemoveSpaces(string text)
        {
            return text.Replace(" ","");
        }
    }
}
