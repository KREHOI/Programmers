using System;
using System.Text;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        string x = "";
        string f = "";
        
        for (int i=0; i<s.Length; i++)
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
                Console.WriteLine($"{x}{f}");
                
                answer += 1;
                x = "";
                f = "";
            }
        }
        
        if (!string.IsNullOrEmpty(x))
        {
            Console.WriteLine($"{x}");
            answer += 1;
        }
        
        return answer;
    }
}