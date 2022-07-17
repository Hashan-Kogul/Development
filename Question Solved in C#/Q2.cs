using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_2018ICTS85
{
    class Program02
    {
        public static void Main2(string[] args)
        {
            int num;

            Console.Write("Enter a digit:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}{3}{4}", num, num, num, num, num);
            Console.WriteLine("{0} {1} {2} {3} {4}", num, num, num, num, num);
            Console.WriteLine("{0} {1}\t{2}\t{3}\t{4}", num, num, num, num, num);

            Console.ReadKey();
        }
    }
}
