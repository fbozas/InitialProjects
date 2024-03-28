using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 1;
			int b = 2;
			var c = 3;
			var sum = a + b + c;

            Console.WriteLine("The sum of a: " + a + " b: " + b + " c: " + c + " is: " + sum);
			// place holders (or string.Format)
			Console.WriteLine("The sum of a: {0} b: {1} c: {2} is: {3}", a, b, c, sum);
            // interpollation
            Console.WriteLine($"The sum of a: {a} b: {b} c: {c} is: {sum}");
        }
	}
}
