public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        answer += new string('*', phone_number.Length-4);
        answer +=phone_number.Substring(phone_number.Length-4);
        return answer;
    }
}