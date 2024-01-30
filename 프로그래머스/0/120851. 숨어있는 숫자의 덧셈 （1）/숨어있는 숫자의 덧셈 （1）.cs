using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        for(int i = 0; i < my_string.Length; i++)
        {
            if(Char.IsNumber(my_string[i]) == true)
            {
                answer += (int)Char.GetNumericValue(my_string[i]);
            }
        }
        
        return answer;
    }
}