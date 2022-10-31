namespace LeetCodeTasks;

/*
 You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.
  The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
Increment the large integer by one and return the resulting array of digits.
 */
public class PlusOne
{
  public int[] GetPlusOne(int[] digits)
  {
      for (int i = digits.Length - 1; i >= 0; i--)
      {
          if (digits[i] < 9)
          {
              digits[i]++;
              return digits;
          }
          
          if (i == 0)
          {
              digits[i]++;
          }
          else {
              digits[i] = 0;    
          }
      }
      
      int[] result = new int [digits.Length + 1];
      result[0] = 1;
      result.Concat(digits.Skip(1));
      
      /*
      long bigNumber = 0;
      int exp = digits.Length - 1;
      
      for (int i = 0; i < digits.Length; i++)
      {
          bigNumber += digits[i] * (long)Math.Pow(10, exp--);
      }

      int size = (int)Math.Floor(Math.Log10(++bigNumber) + 1);
      
      int[] result = new int[size];
      
      while (bigNumber > 0)
      {
          result[--size] = (int)(bigNumber % 10);
          bigNumber /= 10;
      }*/

      return result;
  }
}