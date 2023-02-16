/*
 Given two binary strings a and b, return their sum as a binary string.

Example 1:
Input: a = "11", b = "1"
Output: "100"

Example 2:
Input: a = "1010", b = "1011"
Output: "10101"

a =             "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101"
b =         "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"
expected =  "110111101100010011000101110110100000011101000101011001000011011000001100011110011010010011000000000"
 */

using System.Linq;
using System.Text;

namespace LeetCodeTasks;

public static class AddBinary
{
    public static string GetAddBinary(string a, string b)
    {
        //for (int i = a.Length; i >= 0; i--)
        //{
        //    for (int j = b.Length; j >= 0; j--)
        //    {

        //    }
        //}

        int i = a.Length - 1;
        int j = b.Length - 1;
        //StringBuilder res = new StringBuilder();
        List<char> res = new();
        bool isOverSum = false;

        while (i >= 0 && j >= 0)
        {
            bool resA = int.TryParse(a[i].ToString(), out int numA);
            bool resB = int.TryParse(b[j].ToString(), out int numB);

            if(resA && resB)
            {
                int sum = numA+ numB;

                switch (sum)
                {
                    case 0:
                        res.Add('0');
                        break;
                    case 2:
                        isOverSum = true;
                        res.Add('0');
                        break;
                    case 1:
                        if(isOverSum)
                        {
                            res.Add('0');
                        }
                        else
                        {
                            res.Add('1');
                            isOverSum = false;
                        }
                        break;
                }

                i--;
                j--;
            }
            else
            {
                return string.Empty;
            }

            if(i == 0 && j > 0)
            {
                res.AddRange(b[..j]);
            }

            if (j == 0 && i > 0)
            {
                res.AddRange(a[..j]);
            }
        }

        Array.Reverse(res.ToArray());
        
        return string.Join("", res);
        /*
        try
        {
            var numberA = Convert.ToInt64(a, 2);
            var numberB = Convert.ToInt64(b, 2);

            return Convert.ToString(numberA + numberB, 2);
        }
        catch (Exception)
        {
            return string.Empty;
        }
        */
    }
}
