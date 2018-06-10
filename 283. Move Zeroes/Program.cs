using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _283.Move_Zeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int lenZero = 0;
            int i = 0;
            for (;i < nums.Length;i++)
            {
                if (0 == nums[i])
                {
                    lenZero++;
                }
                else
                {
                    nums[i - lenZero] = nums[i];
                }
            }
            for (i=i- lenZero; i< nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
