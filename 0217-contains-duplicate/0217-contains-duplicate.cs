public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var dic = new Dictionary<int,int>();
        for(int i = 0; nums.Length > i;i++){
            if(dic.ContainsKey(nums[i]))
                return true;
            dic.Add(nums[i], i);
        }

        return false;

    }
}