namespace LeetCodeTasks;

/*
 Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 */
public class RomanToInt
{
    private readonly Dictionary<char, int> digits = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    public int GetRomanToInt(string s)
    {
        if (s.Length == 0)
            return 0;
        
        int finalNumber = 0;
        int lastNumber = 4000;

        for (int i = 0; i < s.Length; i++)
        {
            digits.TryGetValue(s[i], out int number);
            
            if (lastNumber < number){
                finalNumber += number - 2 * lastNumber;
            }
            else{
                finalNumber += number;
                lastNumber = number;
            }
        }
        
        return finalNumber;
    }
}