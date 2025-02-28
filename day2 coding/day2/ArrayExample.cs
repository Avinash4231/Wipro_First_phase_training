using System;

namespace ConsoleProgram
{
	internal class ArrayExample
	{
		public static void ArrayE()
		{
			// single dimensional array 

			// a simple array that holds a sequence of elements in a linear form

			//new is a keyword use to create an object 
			Console.WriteLine("Enter the size of an array :");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] numbers = new int[n];

			// numbers[0] = 1;
			// numbers[1] = 2;
			// numbers[2] = 3;
			// numbers[3] = 4;
			// numbers[4] = 5;

			// Access all the elements to print -- iterate
			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = Convert.ToInt32(Console.ReadLine());

			}

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine($"Element at index {i} : {numbers[i]}");

			}

			//Multidimensional 
			int[,] matrix = new int[2, 3]
				{
					{ 1,2,3},
					{ 4,5,6}

				};

			for (int i = 0; i < 2; i++)   // 2 rows 0,1
			{
				for (int j = 0; j < 3; j++)  // for each row the inner loop will continue to execute 
				{

					Console.WriteLine(matrix[i, j] + " ");

				}
				Console.WriteLine();


			}


			// jagged  Array : when we have different lengths


			int[][] ja = new int[3][];


			ja[0] = new int[] { 1, 2, 3 }; // internal array
			ja[1] = new int[] { 4, 5 };
			ja[2] = new int[] { 6, 7, 8 };

			for (int i = 0; i < ja.Length; i++)
			{

				Console.WriteLine($"At index no : {i} ");
				for (int j = 0; j < ja[i].Length; j++)

				{
					Console.WriteLine(ja[i][j] + " ");

				}
				Console.WriteLine();
			}


		}
	}
}
