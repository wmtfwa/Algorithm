public class Solution {
    public int solution(int num) {
        int answer = 0;
        
        double num2 = num;
        
        int n = 0;
        while(num2 != 1)
        {
            if(num2 % 2 == 0)
                num2 /= 2;
            else
                num2 = 3*num2 + 1;
            n++;
            if(n == 500)
            {
                answer = -1;
                break;
            }
            answer++;
        }
        
        return answer;
    }
}