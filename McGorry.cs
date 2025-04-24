using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Holiday___Final_Project
{
    public class McGorry
    {
        public int MaxCoins(int[] nums)
        {
            int n = nums.Length;
            int[] newNums = new int[n + 2];
            newNums[0] = 1;
            newNums[n + 1] = 1;
            for (int i = 0; i < n; i++)
            {
                newNums[i + 1] = nums[i];
            }

            int[,] dp = new int[n + 2, n + 2];

            for (int length = 2; length <= n + 1; length++)
            {
                for (int left = 0; left <= n + 1 - length; left++)
                {
                    int right = left + length;
                    for (int k = left + 1; k < right; k++)
                    {
                        dp[left, right] = Math.Max(
                            dp[left, right],
                            newNums[left] * newNums[k] * newNums[right] + dp[left, k] + dp[k, right]
                        );
                    }
                }
            }

            return dp[0, n + 1];
        }
    }

}