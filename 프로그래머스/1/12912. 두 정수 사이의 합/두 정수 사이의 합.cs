using System;

public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        
        int x = Math.Min(a,b);
        int y = Math.Max(a,b);
        
        if(x==y)
            answer = x;
        else
        {
            for(int i = x; i <= y; i++)
                answer += i;
        }
        
        return answer;
    }
}