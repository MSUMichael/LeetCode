public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int replacement = nums[nums.Length-1]+1;
        int progress_max = nums[0];
        int distinct_ints = 1;
        if (nums.Length != 1){
            for (int i = 1; i < nums.Length; i++){
                if (nums[i] > progress_max){
                    distinct_ints += 1;
                    progress_max = nums[i];
                }
                else if (nums[i] == progress_max) {
                    nums[i] = replacement;
                }
            }
            Array.Sort(nums);
        }
        return distinct_ints;
    }
}