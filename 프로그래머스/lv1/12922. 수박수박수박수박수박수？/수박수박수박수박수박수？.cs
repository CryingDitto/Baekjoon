using System.Text;
public class Solution {
    public string solution(int n) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        int count = 1;
        while (count <= n){
            if(count%2==0){
                sb.Append("박");
            }
            else{
                sb.Append("수");
            }
            count ++;
        }
        return sb.ToString();
    }
}