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
    public int GetRomanToInt(string s)
    {
        if (s.Length == 0)
            return 0;
        
        int finalNumber = 0;
        int lastSymbol = 4000;

        for (int i = 0; i < s.Length; i++)
        {
            int number = GetNumberFromSymbol(s[i]);
            
            if (lastSymbol < number){
                finalNumber -= lastSymbol;
                finalNumber += number - lastSymbol;
            }
            else{
                finalNumber += number;
                lastSymbol = number;
            }
        }
        
        return finalNumber;
    }
    
    private int GetNumberFromSymbol(char letter)
    {
        int value = letter switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 1
        };

        return value;
    }
}