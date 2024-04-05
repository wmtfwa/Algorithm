using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] mos = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        
        foreach(string let in letter.Split(" "))
        {
            answer +=  Convert.ToChar(Array.IndexOf(mos, let) + 97);
        }
        
        return answer;
    }
}