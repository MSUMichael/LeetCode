public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int num_removed = 0;
        int count = 0;
        int current_num = nums[0];

        /*
        for (int j = 0; j < nums.Length-1; j++){
            nums[j] = nums[j+1];
            //num_removed += 1;
        }
        Array.Resize(ref nums, nums.Length-1);
        */

        
        for (int i = 0; i < nums.Length-1; i++){
            
            if (nums[i] == nums[i+1]){
                
                if (count > 0){
                    nums[i] = nums.Max()+1;
                    num_removed += 1;
                }
                count += 1;
            }
            else {
                count = 0;
                current_num = nums[i];
            }
        }
        Array.Sort(nums);
        return nums.Length-num_removed;
    }
}