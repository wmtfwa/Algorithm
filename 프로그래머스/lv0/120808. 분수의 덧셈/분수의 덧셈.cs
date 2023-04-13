using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int topnum = numer1*denom2 + numer2*denom1;
        int botnum = denom1*denom2;
        int maximum = 1;
        
        for(int i = 1; i <= topnum; i++)
        {
            if(topnum%i == 0 && botnum%i == 0)
            {
                maximum = i;
            }
        }
        
        int[] answer = new int[] {topnum/maximum, botnum/maximum};
        return answer;
    }
}