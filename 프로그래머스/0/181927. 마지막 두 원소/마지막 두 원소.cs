using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length+1];
        
        for(int i = 0; i < num_list.Length; i++)
        {
            answer[i] = num_list[i];
        }
        int a = num_list[num_list.Length-1];
        int b = num_list[num_list.Length-2];
        
        answer[num_list.Length] = a > b ? a - b : a * 2;
        
        return answer;
    }
}