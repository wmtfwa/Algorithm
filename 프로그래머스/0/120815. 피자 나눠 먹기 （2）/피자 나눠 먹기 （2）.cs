using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        int max = 0;
        int min = 0;
        
        if(6>=n)
        {
            max = 6;
            min = n;
        }
        else
        {
            max = n;
            min = 6;
        }
        
        int num = 0;
        while(true)
        {
            num = max % min;
            max = min;
            
            if(num == 0)
                break;
            min = num;
        }
        answer = (6*n)/min/6;
        
        return answer;
    }
}