using System;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] nums = new int[size];
            for (int i=0; i<size; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            //정렬
            Array.Sort(nums);

            int[] count = new int[size];
            int[] temp = new int[5];
            int ans = 1; 
            //int check = 1;
            for (int i = 0; i < size; i++)
            {
                temp[0] = nums[i];
                temp[1] = nums[i] + 1;
                temp[2] = nums[i] + 2;
                temp[3] = nums[i] + 3;
                temp[4] = nums[i] + 4;

                for (int j = 1; j < 5; j++)
                {
                    if (i + j < size)
                    {
                        if (temp.Contains(nums[i + j]))
                        {
                            ans++;
                        }
                        //foreach (int t in temp)
                        //{
                        //    if (t == nums[i + j])
                        //    {
                        //        ans++;
                        //    }


                        //}
                    }
                    else
                    {
                        break;
                    }
                        
                }


                //foreach(int t in temp)
                //{
                //    for (int j = 1; j<5; j++)
                //    {
                //        if (t == nums[i+j] && i+j < size)
                //        {
                //            ans++;
                //        }
                //    }
                    
                //}

                //for (int j = 1; j<5; j++)
                //{
                //    if(i+check < size)
                //    {
                //        if (nums[i + check] == temp[j])
                //        {
                //            ans++;
                //        }
                //    }
                //    else
                //    {
                //        break;
                //    }                   
                    
                //}

                count[i] = 5 - ans;
                ans = 1;
            }

            Console.WriteLine(count.Min()); // Linq

        }
    }
}
