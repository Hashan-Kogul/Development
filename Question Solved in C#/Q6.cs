using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_2018ICTS85
{
    class Program06
    {
        public static void Main6(string[] args)
        {
            int num;
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter num :");
                num = Convert.ToInt32(Console.ReadLine());

                sum += num;
            }
            Console.WriteLine("sum : {0}", sum);

            Console.ReadKey();
        }
    }
}
