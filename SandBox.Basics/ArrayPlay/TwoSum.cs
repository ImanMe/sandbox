namespace SandBox.Basics.ArrayPlay
{
    public class TwoSum
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        return new[] { i, j };
                    }
                }    
            }

            return null;
        }
    }
}
