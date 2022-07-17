using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_2018ICTS85
{
    class Program05
    {
		static void Main(string[] args)
		{
			int? a = null;
			int b = 10;

			int? c = a ?? b;

			if (c < 0)
			{
				Console.WriteLine("Value is : {0}",b);
			}
			else
			{
				Console.WriteLine("Value is : {0}",a);
			}

			Console.ReadKey();

		}
	}
}
