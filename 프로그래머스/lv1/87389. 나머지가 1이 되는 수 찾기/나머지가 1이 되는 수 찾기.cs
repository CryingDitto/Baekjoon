using System;

public class Solution {
    public int solution(int n) {
        int answer = 3;
        for (int x = n-1; x >= 2; x--){
            if(n%x == 1){
                answer = x;
            }
        }
        
        return answer;
    }
}