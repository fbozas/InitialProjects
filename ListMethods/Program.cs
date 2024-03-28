using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
			list1.Add(6);
			foreach(var item in list1)
				Console.WriteLine(item);
            Console.WriteLine();
            int lengthOfList = list1.Count;
            Console.WriteLine(lengthOfList);
			Console.WriteLine();
			list1.Reverse();
			foreach (var item in list1)
				Console.WriteLine(item);
		}
	}
}
