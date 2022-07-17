using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_2018ICTS85
{
    class Program04
    {
        public static void Main4(string[] args)
        {
            int radious = 7;
            double perimeter;
            double area;

            area = 22 / 7 * radious * radious;
            perimeter = 2 * 22 / 7 * radious;

            Console.WriteLine("Area is : {0}", area);
            Console.WriteLine("Perimeter is : {0}", perimeter);

            Console.ReadKey();
        }
    }
}
