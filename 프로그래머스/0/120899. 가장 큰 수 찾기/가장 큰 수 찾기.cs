using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        
        int tem = 0;
        
        for(int i = 0; i < array.Length; i++)
        {
            tem = Math.Max(tem,array[i]);
        }
        answer[0] = tem;
        for(int i = 0; i < array.Length; i++)
        {
            if(tem == array[i])
                answer[1] = i;
        }
        
        return answer;
    }
}