using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        char[] arr = my_string.ToCharArray();
        Array.Reverse(arr);
        
        for(int i = 0; i < arr.Length; i++)
            answer += arr[i];
        
        return answer;
    }
}