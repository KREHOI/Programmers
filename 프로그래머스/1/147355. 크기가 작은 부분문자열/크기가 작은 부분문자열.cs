using System;
using System.IO;
using System.Threading;

public class Solution {
    public int solution(string t, string p)
    {
        int answer = 0;
        long target = Convert.ToInt64(p);
        int targetLength = p.Length;

        for (int idx = 0; idx < t.Length; idx++)
        {
            if (idx + targetLength > t.Length)
                break;

            string str = t.Substring(idx, targetLength);
            if (Convert.ToInt64(str) <= target)
                answer++;
        }

        return answer;
    }
}