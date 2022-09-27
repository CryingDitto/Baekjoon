public class Solution {
    public string solution(int n) {
        string answer = "";
        int count = 1;
        while (count <= n){
            if(count%2==0){
                answer += "박";
            }
            else{
                answer += "수";
            }
            count ++;
        }
        return answer;
    }
}