using System.Linq; 
public class Solution {
    public bool solution(int x) {
        bool answer = false;
        
        char[] nums =  x.ToString().ToArray();
        int div = 0;

        for(int i = 0; i<nums.Length; i++)
        {
            div += int.Parse(nums[i].ToString());
        }
        if(x % div == 0)
        {
            answer = true;
        }
        return answer;
    }
}