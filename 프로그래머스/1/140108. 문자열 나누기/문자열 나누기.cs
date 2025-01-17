using System;
using System.Text;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        string x = string.Empty;
        string f = string.Empty;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (string.IsNullOrEmpty(x))
            {
                x +=s[i];
                continue;
            }
            
            char findCh = s[i];
            
            if (x.IndexOf(findCh) == -1)
                f += findCh;
            else
                x += findCh;
            
            if (x.Length == f.Length)
            {
                answer += 1;
                x = string.Empty;
                f = string.Empty;
            }
        }
        
        if (!string.IsNullOrEmpty(x))
            answer += 1;
        
        return answer;
    }
}