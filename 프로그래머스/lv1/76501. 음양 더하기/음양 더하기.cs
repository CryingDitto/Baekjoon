using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        
        for(int i = 0; i<absolutes.Length; i++){
            int num = signs[i] ? absolutes[i] : (-absolutes[i]);
            answer += num;
        }
        return answer;
    }
}