using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	internal class Program
	{
		static int Sum(int a, int b) 
		{ 
			return a + b;
		}

		static void Sum() 
		{
            Console.WriteLine("Give first number");
			int firstNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Give second number");
			int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum is {firstNumber + secondNumber}");
        }
		static void Main(string[] args)
		{
			int sum = Sum(2, 3);
			Console.WriteLine(Sum(2, 3));
            Console.WriteLine(sum);
			Sum();
        }
	}
}
