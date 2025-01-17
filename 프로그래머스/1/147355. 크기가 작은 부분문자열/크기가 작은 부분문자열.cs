using System;
using System.IO;
using System.Threading;

public class Solution {
    public int solution(string t, string p)
    {
        int answer = 0;
        long diff2 = Convert.ToInt64(p);
        int diff2Length = p.Length;

        for (int i=0; i<t.Length; i++)
        {
            if (i+diff2Length > t.Length)
                break;

            string s = t.Substring(i, diff2Length);

            long diff1 = Convert.ToInt64(s);
            
            if (diff1 <= diff2)
                answer++;
        }

        return answer;
    }
}