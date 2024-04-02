using System;

public class Solution {
    public string solution(string myString, string pat) {
        string answer = "";
        
        int idx = myString.LastIndexOf(pat);
        
        answer = myString.Substring(0,idx)+pat;
        
        return answer;
    }
}