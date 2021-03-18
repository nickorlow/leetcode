public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int index = 0;
        
        int ll = 0;
       
        int cl = 0;
        List<char> run = new List<char>();
        
        for(int i = 0; i<s.Length; i++)
        {
            char c = s[i];
            if(run.Contains(c))
            {
                ll = ll > cl ? ll : cl;
                
                run = new List<char>();
                cl = 0;
                i = index++;
            }
            else
            {
                cl++;
                run.Add(c);
            }
        }
        ll = ll > cl ? ll : cl;
                
        return ll;
    }
}
