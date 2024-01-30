using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        
        foreach(int a in numbers)
        {
            answer += a;
            if(answer > n)
                break;
        }
        
        return answer;
    }
}