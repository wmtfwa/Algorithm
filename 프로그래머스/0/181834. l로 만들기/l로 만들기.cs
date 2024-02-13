using System;

public class Solution {
    public string solution(string myString) {
        
        char[] myChar = myString.ToCharArray();
        for(int i = 0; i < myChar.Length; i++)
        {
            if(myChar[i] < 'l')
                myChar[i] = 'l';
        }
        string myStr = new string(myChar);
        
        return myStr;
    }
}