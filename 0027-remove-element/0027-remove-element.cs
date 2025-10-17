public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        if (nums.Length>0){
            int replace_elem = nums.Max()+1;
            int num_of_vals = 0; 

            for (int i = 0; i < nums.Length; i++){
                if (nums[i] == val) {
                    nums[i] = replace_elem;
                    num_of_vals += 1;
                }
            }
            Array.Sort(nums);
            return nums.Length-num_of_vals;
        }
        else {
            return 0;
        }
        
        

    }
}