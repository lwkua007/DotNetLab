using System;

namespace SquareSort
{
    class SquareSort
    {
		public static void Main(string[] args)
		{
			int[] array = ReadArray();
			int[] sortArray = SortArray(array);

			Console.WriteLine("The input array is: " + array);
			Console.WriteLine("The sorted array is: " + sortArray);
		}

		private static int[] ReadArray()
		{
			Console.WriteLine("Please input your array:");
			string length = Console.ReadLine();
			int arrayLength = Int32.Parse(length);

			int[] array = new int[arrayLength];
			for (int i = 0; i < arrayLength; i++)
			{
				Console.WriteLine("Please input array number " + i + "th:");
				string currentNumber = Console.ReadLine();
				array[i] = Int32.Parse(currentNumber);
			}

			return array;
		}

		private static int[] SortArray(int[] array)
		{
			int[] sortArray = new int[array.Length];
			//int[] containers = new int[array.Length];

			for (int i = 0; i < array.Length; i++)
			{
				sortArray[i] = (int)Math.Pow(array[i], 2);
			}




			return sortArray;
		}
	}
}