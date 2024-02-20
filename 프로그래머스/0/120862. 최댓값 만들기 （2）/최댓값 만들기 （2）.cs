using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        Array.Sort(numbers);
        
        int num1 = numbers[numbers.Length-2]*numbers[numbers.Length-1];
        int num2 = numbers[0]*numbers[1];
        
        return Math.Max(num1,num2);
    }
}