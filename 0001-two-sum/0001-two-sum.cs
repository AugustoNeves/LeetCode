public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){

            int complement = target - nums[i];
            Console.WriteLine($"Target: {target} - num: {nums[i]} is equal {complement}");
            if (dic.ContainsKey(complement)) {
                Console.WriteLine($"Num: {nums[i]} + complement: {complement} is equal target: {target}");
                return new int[] { dic[complement], i };
            }            
            dic[nums[i]] = i;
        }        

        return new int[]{};
    }
}