﻿namespace LeetCodeTasks;

/*
 Given two strings s and t, return true if t is an anagram of s, and false otherwise.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
 */
public class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        List<char> source = new(s.ToArray());
        List<char> target = new(t.ToArray());

        source.Sort();
        target.Sort();

        for (int i = 0; i < source.Count; i++)
        {
            if (source[i] != target[i])
            {
                return false;
            }
        }

        return true;
    }
}