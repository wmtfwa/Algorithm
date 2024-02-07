using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        
        myString = myString.ToLower();
        answer = myString.Replace('a','A');
        
        return answer;
    }
}