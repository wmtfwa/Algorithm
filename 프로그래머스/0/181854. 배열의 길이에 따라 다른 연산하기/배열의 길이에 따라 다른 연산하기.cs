using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        
        if(arr.Length % 2 == 0)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(i % 2 == 1)
                    arr[i] += n;
            }
        }
        else
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(i % 2 == 0)
                    arr[i] += n;
            }
        }
        
        return arr;
    }
}