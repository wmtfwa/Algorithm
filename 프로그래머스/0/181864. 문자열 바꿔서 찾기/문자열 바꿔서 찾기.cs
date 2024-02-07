using System;

public class Solution {
    public int solution(string myString, string pat) {
        
        myString = myString.Replace("A","X").Replace("B","A").Replace("X","B");
        
        return myString.Contains(pat) ? 1 : 0;
    }
}