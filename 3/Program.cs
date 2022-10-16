using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 9 % 2;
            Console.WriteLine("9/2="+number +"餘數為一所以是奇數");
            int number2 = 202 % 2;
            Console.WriteLine("202/2="+number2+"餘數為零所以是偶數");
        }
    }
}
