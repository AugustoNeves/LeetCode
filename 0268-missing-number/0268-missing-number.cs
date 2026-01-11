public class Solution {
    public int MissingNumber(int[] nums) {

        int missingNumber = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if (missingNumber == nums[j]){
                    missingNumber++;
                }
            }
        }

        return missingNumber;
    }
}