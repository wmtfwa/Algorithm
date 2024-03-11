public class Solution {
    public long solution(long n) {
        long answer = -1;
        
        long num = 0;
        while(n/2+1 >= num)
        {
            if((num * num) == n)
            {
                return (num+1)*(num+1);
            }
            num++;
        }
        
        return answer;
    }
}