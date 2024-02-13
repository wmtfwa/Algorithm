using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string myString) {
        List<int> answer = new List<int>();
        
        string[] str = myString.Split('x');
        for(int i = 0; i < str.Length; i++)
            answer.Add(str[i].Length);
        
        return answer.ToArray();
    }
}