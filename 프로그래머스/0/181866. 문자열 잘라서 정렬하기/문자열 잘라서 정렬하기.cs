using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string myString) {
        List<string> answer = new List<string>();
        
        String[] my = myString.Split("x");

        for(int i = 0; i < my.Length; i++)
        {
            if(!String.IsNullOrEmpty(my[i]))
                answer.Add(my[i]);
        }
        answer.Sort();
        
        return answer.ToArray();
    }
}