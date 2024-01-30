using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        List<int> ans = new List<int>();
        
        for(int i = n-1; i < num_list.Length; i++)
            ans.Add(num_list[i]);
        
        return ans.ToArray();
    }
}