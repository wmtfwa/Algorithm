public class Solution {
    public bool solution(int x) {
        bool answer = false;
        
        string num = x.ToString();
        int sum = 0;
        for(int i = 0; i < num.Length; i++)
        {
            sum += int.Parse(num[i].ToString());
        }
        if(x % sum == 0)
            answer = true;
        
        return answer;
    }
}