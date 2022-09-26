public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        long la = (long)a;
        long lb = (long)b;
        answer = la;
        while(la!=lb){
            la = (la-lb)>0 ? la-1 : la+1;    
            answer += la;        
        }
        
        // if (la-lb > 0){
        //     while (la >= lb){
        //         answer += la;
        //         la--;
        //     }
        // }
        // else if(la-lb < 0){
        //     while (la <= lb){
        //         answer += la;
        //         la++;
        //     }
        // }
        // else{
        //     answer = la;
        // }
        return answer;
    }
}