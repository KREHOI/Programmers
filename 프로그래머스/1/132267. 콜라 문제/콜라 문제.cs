using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        
        while(n >= a)
        {
            int exchanged = (n/a) * b;
            int rest = n%a;
            answer += exchanged;
            n = exchanged + rest;
        }
        
        return answer;
    }
}