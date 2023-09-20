using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpArraysAndLists
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


		public static void UsingArrays()
		{
			

			int[] numbersB = { 4, 6, 8, 12, 9 };
			Console.WriteLine(string.Join(",", numbersB));

			// They can have multiple dimensions
			int[,] coordinatesA = new int[2, 2];
			coordinatesA[0, 0] = 1;
			coordinatesA[0, 1] = 3;
			Console.WriteLine(PrintCoordinates(coordinatesA));

			int[,] coordinatesB = { { 1, 3 }, { 2, 4 } };
			Console.WriteLine(PrintCoordinates(coordinatesB));
		}

		public static string PrintCoordinates(int[,] coordinates)
		{
			string ret = string.Empty;
			for (int i = 0; i < coordinates.GetLength(0); i++)
			{
				ret += "[";
				for (int j = 0; j < coordinates.GetLength(1); j++)
				{
					ret += $"{coordinates[i, j]}, ";
				}
				ret = ret.TrimEnd(',', ' ') + "] ";
			}
			return ret;
		}


		// Creating Lists
		public static void CreatingLists()
		{
			// Lists are not fixed in size. They must be of one type
			List<int> numbersA = new List<int>();
			numbersA.Add(12);
			numbersA.Add(10);
			numbersA.Add(11);
			Console.WriteLine(string.Join(",", numbersA));

			List<int> numbersB = new List<int> { 4, 6, 8, 12, 9 };
			Console.WriteLine(string.Join(",", numbersB));

			// You can have a list of lists
			List<List<int>> coordinatesA = new List<List<int>>();

			// A list of any defined type including your own
			List<DateTime> holidayDates = new List<DateTime>();

			// A list of Tuples (a light weight data structure)             
			List<(int X, int Y)> coordinatesB = new List<(int X, int Y)>();
			coordinatesB.Add((1, 3));
			coordinatesB.Add((X: 2, Y: 3));
			Console.WriteLine(string.Join(",", coordinatesB));
		}

		// Using Lists
		public static void UsingLists()
		{
			List<int> numbers = new List<int> { 4, 6, 8, 12, 9 };
			numbers.Add(2);
			numbers.RemoveAt(1);
			numbers.Reverse();
			Console.WriteLine(string.Join(",", numbers));

			int maxNumber = numbers.Max();
			int minNumber = numbers.Min();
			Console.WriteLine($"Min number is {minNumber}. Max number is {maxNumber}");

			List<int> greaterThanFour = numbers.Where(num => num > 4).ToList();
			Console.WriteLine(string.Join(",", greaterThanFour));

			List<int> doubled = numbers.Select(num => num * 2).ToList();
			Console.WriteLine(string.Join(",", doubled));

			List<string> names = new List<string> { "apple", "plum", "carrot", "sprout" };
			names.Sort();
			Console.WriteLine(string.Join(",", names));
		}


		// Converting a string to an array or a list and back again
		public static void StringToListAndBack()
		{
			string seasons = "Summer, Autumn, Winter, Spring";
			string[] stringArray = seasons.Split(", ");

			// array we cannot add to an array
			Console.WriteLine($"The string array is {stringArray.Length} items long");
			for (int i = 0; i < stringArray.Length; i++)
			{
				Console.WriteLine($"{i + 1}. {stringArray[i]}");
			}

			// List
			List<string> stringList = stringArray.ToList();
			stringList.Add("Christmas");
			Console.WriteLine($"The string list is now {stringList.Count} items long");

			// Turn it back into a string again
			string newString = string.Join(", ", stringList);
			Console.WriteLine(newString);
		}

	}
}
