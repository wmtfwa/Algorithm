using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = -1;
        
        string number = num.ToString();
        
        for(int i = 0; i < number.Length; i++)
        {
            if(number[i].ToString() == k.ToString())
            {
                answer = i+1;
                break;
            }
        }
        
        return answer;
    }
}