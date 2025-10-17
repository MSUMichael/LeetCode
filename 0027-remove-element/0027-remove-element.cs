public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length != 0){
            int tracker = 0;
            for (int i = 0; i < nums.Length; i++){
                if (nums[i] != val){
                    nums[tracker] = nums[i];
                    tracker += 1;
                }
            }
            return tracker;
        }
        else {
            return 0;
        }
    }
}