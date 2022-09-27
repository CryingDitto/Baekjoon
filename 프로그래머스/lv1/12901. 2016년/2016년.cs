using System;
public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        
        // DateTime dt = DateTime.ParseExact($"2016 {a} {b}", "yyyy M d", null);
        DateTime dt = new DateTime(2016, a, b);
        return dt.ToString("ddd").ToUpper();
    }
}