public class Solution {
    public int[] RunningSum(int[] nums)
    {
        int[] runningSum = new int[nums.Length];
        runningSum[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            runningSum[i] = nums[i] + runningSum[i - 1];
        }
        return runningSum;
    }
}