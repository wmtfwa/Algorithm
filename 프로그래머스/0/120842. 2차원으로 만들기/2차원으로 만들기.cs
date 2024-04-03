using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length/n, n];
        int num = 0;
        for(int i = 0; i < answer.GetLength(0); i++)
        {
            for(int j = 0; j < answer.GetLength(1); j++)
            {
                answer[i,j] = num_list[num];
                num++;
            }
        }
        
        return answer;
    }
}