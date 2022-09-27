using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long lp = (long)(price);
        long lm = (long)(money);
        long total = lp * (count+1) * count / 2;
        long returnVal = lm - total >= 0 ? 0: total - lm;
        return returnVal;
    }
}