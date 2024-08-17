using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2B
{
    internal class Program
    {
        public delegate int MathOperation(int num1, int num2);
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        static void Main(string[] args)
        {
            MathOperation addDelegate = (MathOperation)Add;
            MathOperation subtractDelegate = (MathOperation)Subtract;
            int num1=10,num2=5; 

            int resultAdd = addDelegate(num1, num2);
            Console.WriteLine($"Addition result: {num1} + {num2} = {resultAdd}");

            int resultSubtract = subtractDelegate(num1, num2);
            Console.WriteLine($"Subtraction result: {num1} - {num2} = {resultSubtract}");

            Console.ReadKey();
        }
    }
}
