namespace LeetCodeTasks

/*
 Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

Constraints:

1 <= haystack.length, needle.length <= 104
haystack and needle consist of only lowercase English characters.
 */
{
    public class Find_Index_of_First_Occurrence_in_String
    {
        public static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);

            /*
             // version 1
            if (haystack.Contains(needle))
            {
                for (int i = 0; i < haystack.Length; i++)
                {
                    if (haystack[i..(needle.Length + i)] == needle)
                    {
                        return i;
                    }
                }
                return 0;
            }
            else
            {
                return -1;
            }

            // version 2

            if(needle.Length > haystack.Length) return -1;

            for(int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if(needle[0] != haystack[i]) continue;
                else if(needle.Length == 1) return i;

                for(int j = i + 1; j < i + needle.Length; j++)
                {
                    if(needle[j - i] != haystack[j]) break;
                    else if(j == i + needle.Length - 1) return i;
                }
            }

            return -1;
            */
        }
    }
}
