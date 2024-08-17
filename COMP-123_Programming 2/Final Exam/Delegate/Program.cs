using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        public delegate string TextOperation(string text);        
        static void Main(string[] args)
        {
            // Create delegate instances pointing to the methods
            TextOperation uppercaseDelegate = TextProcessor.Uppercase;
            TextOperation reverseDelegate = TextProcessor.Reverse;
            TextOperation removeSpacesDelegate = TextProcessor.RemoveSpaces;

            string inputText = "Hello, World!";

            // Perform text processing using the delegates
            string resultUppercase = uppercaseDelegate(inputText);
            Console.WriteLine($"Uppercase result: {resultUppercase}");

            string resultReverse = reverseDelegate(inputText);
            Console.WriteLine($"Reverse result: {resultReverse}");

            string resultRemoveSpaces = removeSpacesDelegate(inputText);
            Console.WriteLine($"Remove spaces result: {resultRemoveSpaces}");

            Console.ReadKey();
        }
    }
}
