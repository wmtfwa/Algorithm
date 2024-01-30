using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        String c = a.ToString();
        String d = b.ToString();
        
        String n1 = c + d;
        String n2 = d + c;
        
        int num1 = Int32.Parse(n1);
        int num2 = Int32.Parse(n2);
        
        if(num1 > num2)
            answer = num1;
        else
            answer = num2;
        
        return answer;
    }
}