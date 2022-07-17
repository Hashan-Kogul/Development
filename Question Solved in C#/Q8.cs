using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_2018ICTS85
{
    class Program08
    {
        public static void Main8(string[] args)
        {
            string[,] array = new string[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter Animal Name :{0} : {1} ", i, j);
                    array[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
