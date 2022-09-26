using System;
public class Solution {
    public long solution(long n) {        
        char[] num = n.ToString().ToCharArray();
        Array.Sort(num);
        Array.Reverse(num);
        
        long answer = Convert.ToInt64(new string(num));
        
        return answer;
    }
}