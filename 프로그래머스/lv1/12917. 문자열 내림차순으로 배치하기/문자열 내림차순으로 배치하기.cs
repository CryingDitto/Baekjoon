using System.Text;
using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        char[] schar = s.ToCharArray();
        Array.Sort(schar);
        Array.Reverse(schar);
        
        foreach(var a in schar){
            Console.Write(a);
        }
        return new string(schar);
    }
}