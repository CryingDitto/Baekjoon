using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        
        if (arr.Length==1){
            return new int[]{-1};
        }
        
        // int index = Array.IndexOf(arr, arr.Min()); //최솟값 index
        List<int> list = new List<int>();
        foreach(var num in arr){
            list.Add(num);
        }
        list.Remove(list.Min());
        
        
        return list.ToArray();
    }
}