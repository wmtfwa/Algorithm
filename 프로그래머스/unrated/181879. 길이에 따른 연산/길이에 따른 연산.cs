using System;

public class Solution {
    public int solution(int[] num_list) {
        
        int sum = 0;
        int mul = 1;
        int answer = 0;
        
        for(int i = 0; i < num_list.Length; i++)
        {
            if(num_list.Length > 10)
            {
                sum += num_list[i];
                answer = sum;
            }
            else
            {
                mul *= num_list[i];
                answer = mul;
            }
        }
        
        return answer;
    }
}