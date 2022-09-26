using System;
public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        
        int num = Array.IndexOf(seoul, "Kim");
        answer = $"김서방은 {num}에 있다";
        return answer;
    }
}