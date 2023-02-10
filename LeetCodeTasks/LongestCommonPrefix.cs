/*
 Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 
Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters.
 */
using System.Text;

namespace LeetCodeTasks
{
    public static class LongestCommonPrefix
    {
        public static string GetLongestPrefix(string[] strs)
        {
            StringBuilder prefix = new StringBuilder();

            string fstWord = strs[0];

            for (int i = 0; i < fstWord.Length; i++)
            {
                char letter = fstWord[i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || letter != strs[j][i])
                    {
                        return prefix.ToString();
                    }
                }

                prefix.Append(letter);
            }

            return prefix.ToString();
        }
    }
}
