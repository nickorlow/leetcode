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
                string section = s.Substring(start, current-start);
                
                // quick check to add some efficency
                if(section[0] != section[^1])
                    continue;
                
                string reverseSection = reverse.Substring(reverse.Length - start - section.Length, section.Length);
                if(section == reverseSection)
                    palindrome = section;
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
