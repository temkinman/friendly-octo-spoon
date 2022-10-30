using LeetCodeTasks;

TwoSum twoSum = new TwoSum();

var twoSumResult_1 = twoSum.GetTwoSum(new int[]{3,2,4}, 6); // 1, 2
var twoSumResult_2 = twoSum.GetTwoSum(new int[]{ 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11); // 5, 11

Console.WriteLine(string.Join(", ", twoSumResult_1));
Console.WriteLine(string.Join(", ", twoSumResult_2));


RemoveElement removeElement = new();
var nums_1 = new []{ 0, 1, 2, 2, 3, 0, 4, 2 };

Console.WriteLine("Before changing array:");
Console.WriteLine(string.Join(", ", nums_1));

var removeElementResult = removeElement.GetRemoveElement(nums_1, 2); 


Console.WriteLine("After changing array:");
Console.WriteLine(string.Join(", ", nums_1));  // [0, 0, 1, 3, 4, 2147483647, 2147483647, 2147483647]
Console.WriteLine(removeElementResult); //5
