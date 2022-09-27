using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[] {};
        //List
        List<int> list = new List<int>();
        for(int i=0; i < arr.Length; i++){
            if(arr[i]%divisor == 0){
                list.Add(arr[i]);
            }
        }
        answer = list.ToArray();
        Array.Sort(answer);
        if(answer.Length == 0){
            answer = new int[]{-1};
        }
        
        //Linq
//         var nums = from a in arr
//             where a%divisor == 0
//             orderby a
//             select a;
//         var numArr = nums.ToArray();

//         if (numArr.Length==0){
//             answer = new int[]{-1};
//         }
//         else{
//             answer = numArr;
//         }
        
        
        return answer;
    }
}