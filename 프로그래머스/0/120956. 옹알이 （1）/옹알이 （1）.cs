using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        List<string> speaks = new List<string>() {"aya", "ye", "woo", "ma"};
        
        foreach (string str in babbling){
            int length = str.Length;
            int targetLength = 0;
            
            foreach (string speak in speaks){
                if (str.Contains(speak)){
                    targetLength += speak.Length;
                }
            }
            
            if (length == targetLength)
                answer += 1;
        }
        
        return answer;
    }
}