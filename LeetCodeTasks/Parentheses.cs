namespace LeetCodeTasks;
/*
 Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 */

public class Parentheses
{
    private Stack<char> _state = new();
    private readonly HashSet<char> _openedBrackets = new() { '(','[','{' };
    
    private readonly Dictionary<char, char> _pairBrackets = new()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };
    
    public bool IsValid(string s)
    {
        if (s.Length == 0 || s.Length == 1)
        {
            return false;
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            if (_openedBrackets.Contains(s[i]))
            {
                _state.Push(s[i]);
            }
            else
            {
                if (_state.Count == 0)
                {
                    return false;
                }
                
                if (_pairBrackets.TryGetValue(_state.Pop(), out char closedBracket))
                {
                    if (s[i] != closedBracket)
                    {
                        return false;
                    }
                }    
            }
        }
        
        return _state.Count == 0;
    }
}