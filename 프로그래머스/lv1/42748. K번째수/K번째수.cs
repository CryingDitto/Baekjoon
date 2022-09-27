using System;
using System.Text;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        
        int[] answer = new int[commands.GetLength(0)] ;
        // StringBuilder sb = new StringBuilder();
        // Array.ForEach(array, x => sb.Append(x));
        // string strArr = sb.ToString();
        //int[] temp = new int[] {};

        for (int n=0; n < commands.GetLength(0); n++){
            int i = commands[n,0];
            int j = commands[n,1];
            int k = commands[n,2];
            
            int[] temp = new int[j-i+1];
            for (int nn = 0; nn<temp.Length; nn++){
                temp[nn] = array[i-1+nn];
            }
            
            Array.Sort(temp);
            answer[n] = temp[k-1];
        }
        
        return answer;
    }
}