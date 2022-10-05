using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        int[] nums = new int[n+1];
        
        // Array 각 방에 1부터 n까지 채우기
        // index 2인 방에는 2, n인 방에는 n 들어감
        // 1은 소수 아니므로 제외
        // for (int i = 2; i<n+1; i++){
        //     nums[i] = i;
        // }
        nums = Enumerable.Range(0, n+1).ToArray();
        nums[1]=0;
        // 에라토스테네스의 체
        for (int i=2; i<=n; i++){
            if(nums[i]==0) continue; // 이미 소수 아님이 판명된 방 연산 skip
            
            for (int j=i*2; j<=n; j+=i){
                nums[j] = 0; // i의 배수 전부 소수가 아님
            }
        }
        
        // 정답 구하기
        foreach(var num in nums){
            if(num!=0){
                answer++;
            }
        }
        return answer;
    }
}