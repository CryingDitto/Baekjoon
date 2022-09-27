using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        Array.Sort(d);
        List<int> list = d.ToList();
        
        for (int i = list.Count-1; i >= 0; i --){
            if(list.Sum() <= budget){
                return i+1; 
            }else{
                list.RemoveAt(i);
            }
        }
        
        return answer;
    }
}