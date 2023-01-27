using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string word) {
        int answer = 0;
           
            
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("A", 1);
            dict.Add("E", dict["A"] + 781);
            dict.Add("I", dict["E"] + 781);
            dict.Add("O", dict["I"] + 781);
            dict.Add("U", dict["O"] + 781);

            int[] diff = { (int) (Math.Pow(5,4) + Math.Pow(5, 3) + Math.Pow(5, 2) + 5 + 1),
                (int) (Math.Pow(5, 3) + Math.Pow(5, 2) + 5 + 1),
                (int) Math.Pow(5, 2) + 5 + 1, 
                5 + 1, 
                1 };

            if (word.Length == 1)
            {
                answer = dict[word];
            }
            else
            {
                int basic = dict[word[0].ToString()];       
                int letter = 0;
                
                // 다음 자리
                for (int i = 1; i < word.Length; i++)
                {
                    basic += 1; // 다음 자리로 넘어감 // AA or EA or IA or OA or UA
                    switch (word[i])
                    {
                        case 'A':
                            letter = 0;
                            break;
                        case 'E':
                            letter = 1;
                            break;
                        case 'I':
                            letter = 2;
                            break;
                        case 'O':
                            letter = 3;
                            break;
                        case 'U':
                            letter = 4;
                            break;
                    }

                    basic += diff[i] * letter;

                }
                answer = basic;
            }
        
        return answer;
    }
}