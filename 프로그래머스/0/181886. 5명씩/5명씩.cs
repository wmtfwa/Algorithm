using System;

public class Solution {
    public string[] solution(string[] names) {
        string[] answer = new string[(int)Math.Ceiling((double)names.Length / 5)];
        
        int j = 0;
        for(int i = 0; i < names.Length; i++)
        {
            if((i+1)%5 == 1)
            {
                answer[j] = names[i];
                j++;
            }
        }
        
        return answer;
    }
}