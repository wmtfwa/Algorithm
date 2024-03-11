using System;

public class Solution {
    public int[] solution(long n) {
        char[] cha = n.ToString().ToCharArray();
        int[] answer = new int[cha.Length];

        int temp = 0;
        for(int i = cha.Length-1; i >= 0 ; i--)
        {
            answer[i] = int.Parse(cha[temp++].ToString());
        }
        
        return answer;
    }
}