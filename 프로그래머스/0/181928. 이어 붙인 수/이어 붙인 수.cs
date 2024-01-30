using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        
        string num1 = "";
        string num2 = "";

        for(int i = 0; i < num_list.Length; i++)
        {
            if(num_list[i] % 2 == 0)
                num1 += num_list[i].ToString();
            else
                num2 += num_list[i].ToString();
        }
        
        answer = int.Parse(num1) + int.Parse(num2);
        
        return answer;
    }
}