using LeetCodeTasks;

/*Task 1*/
TwoSum twoSum = new TwoSum();

var twoSumResult_1 = twoSum.GetTwoSum(new int[]{3,2,4}, 6); // 1, 2
var twoSumResult_2 = twoSum.GetTwoSum(new int[]{ 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11); // 5, 11

Console.WriteLine("===========Task 1 ==============");
Console.WriteLine(string.Join(", ", twoSumResult_1));
Console.WriteLine(string.Join(", ", twoSumResult_2));

/*Task 2*/
RemoveElement removeElement = new();
var nums_1 = new []{ 0, 1, 2, 2, 3, 0, 4, 2 };

Console.WriteLine("===========Task 2 ==============");
Console.WriteLine("Before changing array:");
Console.WriteLine(string.Join(", ", nums_1));

var removeElementResult = removeElement.GetRemoveElement(nums_1, 2); 

Console.WriteLine("After changing array:");
Console.WriteLine(string.Join(", ", nums_1));  // [0, 0, 1, 3, 4, 2147483647, 2147483647, 2147483647]
Console.WriteLine($"result: {removeElementResult}"); // 5

/*Task 3*/
RemoveDuplicates removeDuplicates = new();
var nums_3 = new []{0,0,1,1,1,2,2,3,3,4};

Console.WriteLine("===========Task 3 ==============");
Console.WriteLine("Before changing array:");
Console.WriteLine(string.Join(", ", nums_3));

var removeDuplicatesResult = removeDuplicates.GetRemoveDuplicates(nums_3);

Console.WriteLine($"result: {removeDuplicatesResult}"); // 5
Console.WriteLine("After changing array:");
Console.WriteLine(string.Join(", ", nums_3)); // [0,1,2,3,4,_,_,_,_,_]

/*Task 4*/
var nums_4 = new []{1,3,5,6};

InsertPosition insertPosition = new();
var insPosResult_1 = insertPosition.SearchInsert(nums_4, 2);
var insPosResult_2 = insertPosition.SearchInsert(nums_4, 5);
    
Console.WriteLine("===========Task 4 ==============");
Console.WriteLine($"result: {insPosResult_1}"); // 1
Console.WriteLine($"result: {insPosResult_2}"); // 2

/*Task 5*/
// var nums_5 = new []{5,2,2,6,5,7,1,9,0,3,8,6,8,6,5,2,1,8,7,9,8,3,8,4,7,2,5,8,9};
var nums_5 = new []{9, 9, 9}; 
PlusOne one = new();
var plusOneResult = one.GetPlusOne(nums_5);

Console.WriteLine("===========Task 5 ==============");
Console.WriteLine(string.Join(", ", plusOneResult)); // [1,0,0]

/*Task 6*/
var nums_6 = new []{7,1,5,3,6,4};
var nums_6_2 = new []{7,6,4,3,1};
var nums_6_3 = new []{2,4,1};
BestTimeBuyAndSellStock stock = new();

var stockResult_1 = stock.MaxProfit(nums_6);
var stockResult_2 = stock.MaxProfit(nums_6_2);
var stockResult_3 = stock.MaxProfit(nums_6_3);
Console.WriteLine("===========Task 6 ==============");
Console.WriteLine($"result: {stockResult_1}"); // 5
Console.WriteLine($"result: {stockResult_2}"); // 0
Console.WriteLine($"result: {stockResult_3}"); // 2

/*Task 7*/
string nums_7 = "LVIII";
string nums_7_2 = "MCMXCIV";
RomanToInt roman = new();

var romanResult_1 = roman.GetRomanToInt(nums_7);
var romanResult_2 = roman.GetRomanToInt(nums_7_2);
Console.WriteLine("===========Task 7 ==============");
Console.WriteLine($"result: {romanResult_1}"); // 58
Console.WriteLine($"result: {romanResult_2}"); // 1994

/*Task 8*/
Parentheses parentheses = new();
var isValidBrackets_1 = parentheses.IsValid("()[]{}");
var isValidBrackets_2 = parentheses.IsValid("([])");
var isValidBrackets_3 = parentheses.IsValid(")(){}");
var isValidBrackets_4 = parentheses.IsValid("({aab})");
Console.WriteLine("===========Task 8 ==============");
Console.WriteLine($"result: {isValidBrackets_1}"); // true
Console.WriteLine($"result: {isValidBrackets_2}"); // true
Console.WriteLine($"result: {isValidBrackets_3}"); // false
Console.WriteLine($"result: {isValidBrackets_4}"); // false

/*Task 9*/
ValidAnagram anagram = new ValidAnagram();
var isValidAnagram_1 = anagram.IsAnagram("anagram", "nagaram");
var isValidAnagram_2 = anagram.IsAnagram("rat", "car");

Console.WriteLine("===========Task 9 ==============");
Console.WriteLine($"result: {isValidAnagram_1}"); // true
Console.WriteLine($"result: {isValidAnagram_2}"); // false


