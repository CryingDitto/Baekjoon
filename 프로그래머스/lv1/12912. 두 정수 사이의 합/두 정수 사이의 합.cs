public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        long la = (long)a;
        long lb = (long)b;
        
        if (la-lb > 0){
            while (la >= lb){
                answer += la;
                la--;
            }
        }
        else if(la-lb < 0){
            while (la <= lb){
                answer += la;
                la++;
            }
        }
        else{
            answer = la;
        }
        return answer;
    }
}