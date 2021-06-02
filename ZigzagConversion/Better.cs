/*
Runtime: 96 ms, faster than 73.21% of C# online submissions for ZigZag Conversion.
Memory Usage: 26.7 MB, less than 90.72% of C# online submissions for ZigZag Conversion.
*/
public class Solution {
    public string Convert(string s, int numRows) {
        if(s.Length < numRows || numRows == 1)
            return s;
        
        string returner = "";
        int nonce = numRows - 2;
        for(int x = 0; x < numRows; x++)
        {
                int y = 0;
                for(int i = x; i < s.Length; i+= (x == 0 || x == numRows -1) ? (numRows+nonce) : (y%2==1 ? 2*x : (2*numRows-2)-(2*x)), y++)
                    returner += s[i];
        }
        return returner;
    }
}
