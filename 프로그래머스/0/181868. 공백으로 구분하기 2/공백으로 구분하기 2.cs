using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        
        my_string = my_string.Trim();
        List<string> answer = new List<string>();
        
        string[] str = my_string.Split(" ");
        
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] != "")
                answer.Add(str[i]);
        }
        
        return answer.ToArray();
    }
}