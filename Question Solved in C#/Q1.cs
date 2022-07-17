using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_2018ICTS85
{
    class Program01
    {
        static void Main1(string[] args)
        {
            string name;
            string town;
            string Reg;
            Console.Write("Enter your Name:");
            name = Console.ReadLine();
            Console.Write("Enter your hometown:");
            town = Console.ReadLine();
            Console.Write("Enter your registrasion number:");
            Reg = Console.ReadLine();

            Console.WriteLine(".........................................");

            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Hometown : {0}", town);
            Console.WriteLine("Registration Number : {0}", Reg);



            Console.ReadKey();
        }
    }
}
