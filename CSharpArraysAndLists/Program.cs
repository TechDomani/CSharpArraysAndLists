namespace CSharpArraysAndLists
{
	internal class Program
	{
		static void Main()
		{
			ArraysAndLists.SimpleIntArray();
			ArraysAndLists.SimpleStringArray();

			double[] array = [3.2, 19.4, 12.2]; // Creates an array with initial values set
			Console.WriteLine("Initial values: " + string.Join(", ", array));
			ArraysAndLists.ArraysAreReferenceTypes(array);
			Console.WriteLine("Values now: " + string.Join(", ", array));
			Console.WriteLine();

			ArraysAndLists.TwoDimensionalArray();
			ArraysAndLists.JaggedArray();

			ArraysAndLists.CreatingLists();
			ArraysAndLists.UsingLists();
		}
	}
}