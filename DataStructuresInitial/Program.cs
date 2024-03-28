using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresInitial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// arrays
			int[] array1 = new int[3];
			array1[0] = 1;
			array1[1] = 2;
			array1[2] = 3;

			int[] array2 = { 1, 2, 3, 4, 5 };

			// lists
			List<int> list1 = new List<int>();
			list1.Add(1);
			list1.Add(2);
			list1.Add(3);
			list1.Add(4);
			list1.Add(5);

			List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };

		}
	}
}
