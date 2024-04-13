using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a, b, c;
			a = 5;
			b = 8;
			c = 10;

			if (a > b)
			{
				Console.WriteLine("a > b");
			}
			else 
			{
                Console.WriteLine("a < b");
            }

			// nested conditionals
			if (a > b) 
			{				
                Console.WriteLine("a > b");
				if(c > b)
				{
                    Console.WriteLine("c > b");
                }
			}
			else
			{
				Console.WriteLine("a < b");
			}

            Console.WriteLine();
            // Ternary Operator example 1
            string result = (a > b) ? "a > b" : "a < b";
            Console.WriteLine(result);
			// Ternary Operator example 2
			int x = 2;
			bool isEven = (x % 2 == 0) ? true : false;
        }
	}
}
