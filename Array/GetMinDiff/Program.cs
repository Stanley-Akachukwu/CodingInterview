using System.Collections;

public class Program
{
//1. Given an array of distinct integers, determine the minimum absolute difference between 
//any two elements.Print all element pairs with that difference in ascending order.
//Example
//numbers =[6, 2, 4, 10]
//The minimum absolute difference is 2 and the pairs with that difference are 
//(2.4) and(4,6). When printing element pairs(), they should be ordered ascending first by/and then by J.
	public static void Main()
	{
		int[] arr = { 6, 2, 4, 10 };
		//{2,4,6,10}
		GetMinDiff(arr);
	}
	public static void GetMinDiff(int[] nums)
	{
		var arr = new ArrayList(nums);
		arr.Sort();

		var pairs = new List<KeyValuePair<int, string>>();
		int min = int.MaxValue;
		var size = arr.Count - 1;
		for (int i = 0; i < size; i++)
		{
			if (i < size)
			{
				var diff = (int)arr[i + 1] - (int)arr[i];
				var pair = new KeyValuePair<int, string>(diff, arr[i] + "," + arr[i + 1]);
				pairs.Add(pair);
				if (min > diff)
					min = diff;
			}
		}

		for (int i = 0; i < pairs.Count; i++)
		{
			var pair = pairs[i].Value.Split(',');
			if (pairs[i].Key == min)
				Console.WriteLine($"{pair[0]}{pair[1]}");

		}
	}
 
}