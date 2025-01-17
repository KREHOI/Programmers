using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        for (int idx = 0; idx < s.Length; idx++)
        {
            char ch = s[idx];
            string targetStr = s.Substring(0, idx);
            
            int findIdx = targetStr.LastIndexOf(ch);
            
            if (findIdx == -1)
                answer[idx] = findIdx;
            else
                answer[idx] = idx - findIdx;
        }
        
        return answer;
    }
}