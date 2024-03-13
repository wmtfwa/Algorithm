using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        char[] ans = n.ToString().ToCharArray();
        Array.Sort(ans);
        Array.Reverse(ans);
        answer = long.Parse(ans);
        
        return answer;
    }
}