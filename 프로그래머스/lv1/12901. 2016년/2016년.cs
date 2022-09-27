using System;
public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        
        DateTime dt = DateTime.ParseExact($"2016 {a} {b}", "yyyy M d", null);
        
        return dt.ToString("ddd").ToUpper();
    }
}