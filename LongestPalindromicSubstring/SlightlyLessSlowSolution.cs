/*
Runtime: 492 ms, faster than 26.75% of C# online submissions for Longest Palindromic Substring.
Memory Usage: 26.7 MB, less than 52.51% of C# online submissions for Longest Palindromic Substring.
*/
public class Solution 
{
    public string LongestPalindrome(string s) 
    {
        if(s.Length == 1)
            return s;
        
        string palindrome = s.Substring(0,1);
        // if we reverse at the beginning, we can save compute by not having to reverse a max
        // of len(s)^2 strings
        string reverse = reverseString(s);
        
        for(int start = 0; start < s.Length; start++)
        {
            // start at (start + palindrome.Length) because it's a waste of time to check palindromes that are 
            // less than the current longest length. +1 is added so we can skip checking i 1 char is a palindrome
            // since that's obviously always going to be true
            for(int current = start + palindrome.Length + 1; current <= s.Length; current++)
            {     
                bool isPalin = true;
                for(int i = 0; i< current-start; i++)
                    if(s[start+i] != s[current-i-1])
                    {
                        isPalin = false;
                        break;
                    }
                
                if(isPalin)
                    palindrome = s[start..current];
            }
        }
        
        return palindrome;
    }
    
    public string reverseString(string s)
    {
        string newS = "";
        for(int i = s.Length-1; i > -1; i--)
            newS += s.Substring(i,1);
        
        return newS;
    }
}
