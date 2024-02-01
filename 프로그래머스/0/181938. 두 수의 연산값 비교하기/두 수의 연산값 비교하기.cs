using System;

public class Solution {
    public int solution(int a, int b) {
        
        string num = $"{a}{b}";
        int num1 = int.Parse(num);
        int num2 = 2 * a * b;
        
        return num1 >= num2 ? num1 : num2;
    }
}