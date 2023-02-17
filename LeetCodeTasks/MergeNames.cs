namespace LeetCodeTasks;

/*
 * // Implement the UniqueNames method. When passed two arrays of names, it will return an array containing the names that appear in either or both arrays. 
// The returned array should have no duplicates.
// For example, calling MergeNames.UniqueNames(new string[]{'Ava', 'Emma', 'Olivia'}, new string[]{'Olivia', 'Sophia', 'Emma'}) 
// should return an array containing Ava, Emma, Olivia, and Sophia in any order.*/
public static class MergeNames
{
	public static void MergeNamesRun()
	{
		string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
		string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
		Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia


	}

	private static List<string> res = new List<string>(); 

	public static string[] UniqueNames(string[] names1, string[] names2)
	{
		if(names1.Length == 0 && names2.Length == 0)
		{
			return Array.Empty<string>();
		}

		//List<string> result = new List<string>();
		//result.AddRange(names1);
		//result.AddRange(names2);
		AddToResult(names1);
		AddToResult(names2);

		return res.ToArray();
	}

	private static void AddToResult(string[] arr)
	{
		foreach (var item in arr)
		{
			if (!res.Contains(item))
			{
				res.Add(item);
			}
		}
	}
}
