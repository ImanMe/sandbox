using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Basics.ArrayPlay
{
    public class RunningSum
    {
        public int[] GetRunningSum(int[] nums)
        {
            IList<int> resultList = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if(i == 0) resultList.Add(nums[0]);
                else
                {
                    var interSum = 0;

                    for (var j = 0; j <= i; j++)
                    {
                        interSum += nums[j];
                    }
                    resultList.Add(interSum);
                }
            }
            return resultList.ToArray();
        }
    }
}
