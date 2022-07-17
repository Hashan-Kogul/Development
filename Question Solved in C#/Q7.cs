using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_2018ICTS85
{
    class Program07
    {
        public static void Main7(string[] args)
        {
            char[] ar1 = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 4; 0 <= i; i--)
            {
                Console.Write(" {0} ", ar1[i]);
            }
            Console.ReadKey();
        }
    }
}
