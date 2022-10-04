using System;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        int size = n * (n + 1) / 2;
        int[] answer = new int[size];
        int dir = 1; // 1: going down, 0: going right, -1: going up
        int maxCount = n; int count = 0;
        int add = 1;

        int index = 0;

        for (int i = 1; i<=size; i++)
        {
            // i: 각 자리에 들어가는 숫자
            // index: i가 배열 속에서 위치해야 할 자리
            answer[index] = i;
            count++;

            // direction 순서 : going down - going right - going up
            // +1 -> 0 -> -1 반복
            if (count == maxCount)
            {
                if (dir == 1)
                {
                    dir = 0;
                }
                else if (dir == 0)
                {
                    dir = -1;
                }
                else
                {
                    dir = 1;
                }
                // Count reset
                maxCount--;
                count = 0;
            }

            // going up or down
            if(dir == -1 || dir == 1)
            {
                // 다음 index setting

                //gap += add; 
                // 1, 3, 6, ... , 9-4=5
                index = index + dir * add;
                add = add + dir; // 2,3,4, 3,2, 3

            }
            else
            {
                // going right
                index += 1;

            }

        }



        return answer;
    }
}