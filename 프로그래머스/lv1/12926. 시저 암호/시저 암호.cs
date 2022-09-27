using System;
using System.Text;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        string low = "abcdefghijklmnopqrstuvwxyz";
        string up = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] lowch = low.ToCharArray();
        char[] upch = up.ToCharArray();
        
        int index = 0; char ch =' ';
        
        for (int i = 0; i<s.Length; i++){
            ch = s[i];
            if(ch == ' '){
                // 공백
                sb.Append(' ');
                continue;
            }
            else{
                // 문자
                char[] search = Char.IsLower(ch) ? lowch:upch;
                
                index = Array.IndexOf(search, ch);
                if(index+n >= search.Length){
                    sb.Append(search[index+n - search.Length]);
                }else{
                    sb.Append(search[index+n]);
                }
            }
        }
        
        return sb.ToString();
    }
}