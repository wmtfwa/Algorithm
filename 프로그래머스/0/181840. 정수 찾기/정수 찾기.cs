using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] num_list, int n) {
        
        List<int> num = num_list.ToList();
        return num.Contains(n) ? 1 : 0;
        
    }
} 