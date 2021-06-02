/*
Runtime: 252 ms, faster than 5.44% of C# online submissions for ZigZag Conversion.
Memory Usage: 29.1 MB, less than 12.81% of C# online submissions for ZigZag Conversion.
*/
public class Solution {
    public string Convert(string s, int numRows) {
        if(s.Length < numRows || numRows == 1)
            return s;
        
        List<string> rows = new List<string>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(i < s.Length - numRows)
            {
                rows.Add(s[i..(i+numRows)]);
                i += numRows;
                for(int x = 0; i+x < s.Length && x < numRows-2; x++)
                    rows.Add(new String(' ', numRows-x-2)+s[i+x].ToString());
                i += numRows - 3;
            }
            else
            {
                rows.Add(s.Substring(i));
                break;
            }
        }
        
        string returner = "";
        
        for (int i = 0; i< numRows; i++)
            foreach(string str in rows)
            {
                if(i<str.Length && str[i] != ' ')
                    returner += str[i];
            }
        
        return returner;
    }
}
