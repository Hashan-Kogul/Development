using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_2018ICTS85
{
    class Program03
    {
        public static void Main3(string[] args)
        {
            int num1, num2, num3;
            int sum;
            int avg;

            Console.WriteLine("Enter Number 01 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 02 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 03 : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2 + num3;
            avg = sum / 3;
            Console.Clear();
            Console.WriteLine("Average is :{0}", avg);

            Console.ReadKey();
        }
    }
}
