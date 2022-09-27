using System;
using System.Linq;
using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        Array.Sort(d);
        List<int> list = d.ToList();
        int sum = 0;
        
        for (int i = list.Count-1; i >= 0; i --){
            sum = list.Sum();
            
            if(sum <= budget){
                return list.Count;
            }else{
                list.RemoveAt(i);
            }
        }
        
        return answer;
    }
}