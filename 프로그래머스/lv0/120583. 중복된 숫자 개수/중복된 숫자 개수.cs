using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        foreach(int arr in array)
            if(arr == n)
                answer += 1;
        
        return answer;
    }
}