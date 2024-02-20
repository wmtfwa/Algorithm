using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        
        char[] arr = my_string.ToCharArray();
        char temp;
        
        temp = arr[num1];
        arr[num1] = arr[num2];
        arr[num2] = temp;
        
        answer = string.Concat(arr);
        return answer;
    }
}