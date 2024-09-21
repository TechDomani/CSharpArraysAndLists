﻿namespace CSharpArraysAndLists
{
	public static class ArraysAndLists
	{
		// Arrays

		public static void SimpleIntArray()
		{
			Console.WriteLine("Arrays are fixed in size and contain data of the same type");
			int[] numbers = new int[5]; // Creates the array
			Console.WriteLine("Initial values: " + string.Join(", ", numbers));
			Console.WriteLine("The array type is: " + numbers.GetType().Name);
			numbers[3] = 12; // Changes the 4th element
			Console.WriteLine("The array length is: " + numbers.Length);
			Console.WriteLine("Current value: " + string.Join(", ", numbers));
			// numbers[6] = 22;
			Console.WriteLine();
		}

		public static void SimpleStringArray()
		{
			string[] words = new string[7]; // Creates the array
			Console.WriteLine("Initial values: " + WriteStringArray(words));
			Console.WriteLine("The array type is: " + words.GetType().Name);
			words[1] = "cat"; // Changes the 2nd element
			words[4] = string.Empty; // Changes the 5th element
			Console.WriteLine("The array length is: " + words.Length);
			Console.WriteLine("Current value: " + WriteStringArray(words));
			Console.WriteLine();
		}

		private static string WriteStringArray(string[] array)
		{
			string result = string.Empty;
			foreach (string val in array)
			{
				result += val ?? "null";
				result += ", ";
			}
			return result.Trim(',');
		}

		public static void ArraysAreReferenceTypes(double[] doubles)
		{
			Console.WriteLine("Arrays are reference types");
			for (int i = 0; i<doubles.Length; i++)
			{
				doubles[i] = doubles[i] * 2;
			}
		}

		public static void TwoDimensionalArray()
		{
			// Create a noughts and crosses board 
			char[,] board = new char[3, 3];
			// The first dimension represents the row
			// The second dimension represents the column 
			board[1, 1] = 'X';  // Player X makes the first move and goes for the centre
			board[0, 2] = '0'; // Player 0 makes the second move and goes for the top right
			Console.WriteLine("The array type is: " + board.GetType().Name);
			Console.WriteLine($"The total size of the board is {board.Length}");
			Console.WriteLine($"The length of the first dimension is: {board.GetLength(0)}");
			Console.WriteLine($"The length of the second dimension is: {board.GetLength(1)}");
			PrintBoard(board);
			Console.WriteLine();

			// Note that curly rather than square brackets are used to initialise two dimensional arrays
			int[,] numbers = { { 4, 5 }, { 9, 3 }, { 6, 2 }, { 8, 13 } };
			Console.WriteLine($"A 4 x 2 array of integers: ");
			Console.WriteLine($"The length of the first dimension is: {numbers.GetLength(0)}");
			Console.WriteLine($"The length of the second dimension is: {numbers.GetLength(1)}");
		}


		private static void PrintBoard(char[,] input)
		{
			string ret = string.Empty;
			for (int i = 0; i < input.GetLength(0); i++)
			{
				for (int j = 0; j < input.GetLength(0); j++)
				{
					char value = input[i, j] == char.MinValue ? '_' : input[i, j]; //Set '_' as default when printing
					ret += $"{value} ";
				}
				ret = ret.TrimEnd() + "\n";
			}
			Console.WriteLine(ret);
		}

		public static void JaggedArray()
		{
			char[][] buttons =
			[
				['a', 'b', 'c', 'd'],
				[ 'e', 'f', 'g', 'h' ],
				[ 'i', 'j', 'k', 'l' ],
				[ 'm', 'n', 'o', 'p' ],
				[ 'q', 'r', 's', 't' ],
				[ 'u', 'v', 'w', 'x' ],
				[ 'y', 'z' ], // Not all the arrays need to be the same length
			];
			Console.WriteLine("The array type is: " + buttons.GetType().Name);
			Console.WriteLine($"The number of rows is {buttons.Length}");

			//Print the buttons
			foreach (char[] row in buttons)
			{
				Console.WriteLine(string.Join(" ", row));
			}
			Console.WriteLine();
		}
	
		// Creating Lists
		public static void CreatingLists()
		{
			// Lists are not fixed in size. They must be of one type
			List<int> numbersA = [];
			Console.WriteLine("Initial values of numbersA: " + string.Join(", ", numbersA));
			Console.WriteLine("The type is: " + numbersA.GetType());
			numbersA.Add(12);
			numbersA.Add(10);
			numbersA.Add(11);
			Console.WriteLine("Current values of numbersA: " + string.Join(", ", numbersA));

			List<int> numbersB = new () { 4, 6, 8, 12, 9 }; // Declaring a list with initial valuesh
			Console.WriteLine("Initial values of numbersB: " + string.Join(", ", numbersB));
			Console.WriteLine();

			// You can have a list of lists
			List<List<int>> coordinatesA =
			[
				[ 3, 5 ],
				[ 4, 7 ]
			];
			Console.WriteLine("Initial values of coordinatesA");
			foreach (List<int> coordinates in coordinatesA)
			{
				Console.WriteLine(string.Join(", ", coordinates));
			}
			Console.WriteLine("The type is: " + coordinatesA.GetType());
			Console.WriteLine();

			// A list of any defined type including your own
			List<DateTime> holidayDates = [];
			holidayDates.Add(new DateTime(2023, 12, 24));
			holidayDates.Add(new DateTime(2023, 01, 01));
			Console.WriteLine("Holiday dates: " + string.Join(", ", holidayDates));

			// A list of Tuples (a light weight data structure)             
			List<(int X, int Y)> coordinatesB = [];
			coordinatesB.Add((1, 3));
			coordinatesB.Add((X: 2, Y: 3));
			Console.WriteLine("Coordinates are:" + string.Join(",", coordinatesB));
			Console.WriteLine();
		}

		// Using Lists
		public static void UsingLists()
		{
			List<int> numbers = [ 4, 6, 8, 12, 9 ];
			numbers.Insert(1, 2);
			numbers.RemoveAt(4);
			numbers.Reverse();
			Console.WriteLine(string.Join(",", numbers));

			int maxNumber = numbers.Max();
			int minNumber = numbers.Min();
			Console.WriteLine($"Min number is {minNumber}. Max number is {maxNumber}");

			List<int> greaterThanFour = numbers.Where(num => num > 4).ToList();
			Console.WriteLine(string.Join(",", greaterThanFour));

			List<int> doubled = numbers.Select(num => num * 2).ToList();
			Console.WriteLine(string.Join(",", doubled));

			List<string> names = [ "apple", "plum", "carrot", "sprout" ];
			names.Sort();
			Console.WriteLine(string.Join(",", names));

			// Convert list to array
			string[] arrayNames = [.. names];
			Console.WriteLine("Names as an array: " + string.Join(",", names));

			// Convert array to list
			int[] moreNumbers = [ 12, 66, 77, 22, 14 ];
			List<int> moreNumberList = moreNumbers.Where(num => num > 20).ToList();
			Console.WriteLine("Numbers as a list: " + string.Join(",", moreNumberList));
		}

	}
}
