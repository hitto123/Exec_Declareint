using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        { int number1 =30;
          int number2 = 20;
            if (number1 > number2)
            {
                int temp=number1;
                number1 = number2;
                number2 = temp;
            }
            Console.WriteLine($"{number1}~{number2}");
        }
    }
}
