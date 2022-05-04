using System;

namespace SquareSort
{
    class SquareSort
    {
		public static void Main(string[] args)
		{
			int[] array = ReadArray();
			int[] sortArray = SortArray(array);

			Console.WriteLine("The input array is: " + string.Join(" ", array));
			Console.WriteLine("The sorted array is: " + string.Join(" ", sortArray));
		}

		private static int[] ReadArray()
		{
			Console.WriteLine("Please input your array length:");
			string length = Console.ReadLine();
			int arrayLength = Int32.Parse(length);

			int[] array = new int[arrayLength];
			for (int i = 0; i < arrayLength; i++)
			{
				Console.WriteLine("Please input array " + i + "th number:");
				string currentNumber = Console.ReadLine();
				array[i] = Int32.Parse(currentNumber);
			}

			return array;
		}

		private static int[] SortArray(int[] array)
		{
			int[] squareArray = new int[array.Length];

			for (int i = 0; i < array.Length; i++)
			{
				squareArray[i] = (int)Math.Pow(array[i], 2);
			}

            int squareArrayMax = squareArray.Max();
            int containerLength = squareArrayMax + 1;
            int[] containers = new int[containerLength];

            for (int i = 0; i < squareArray.Length; i++)
            {
                containers[squareArray[i]]++;
            }

            int[] sortedArray = new int[squareArray.Length];
			int squareArrayMin = squareArray.Min();
			int containerElementCount = 0;

            for (int i = squareArrayMin; i < containers.Length; i++)
            {
                while (containers[i]-- > 0)
                {
                    sortedArray[containerElementCount++] = i;
                }
            }

            return sortedArray;
		}
	}
}