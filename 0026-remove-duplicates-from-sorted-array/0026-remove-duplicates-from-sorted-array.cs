public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        if (nums.Length>0){
            int unique_elements = 1;
            int[] new_nums;
            new_nums = new int[nums.Length];

            new_nums[0] = nums[0];
            
            for (int i = 0; i < nums.Length-1; i++){
                if (nums[i] != nums[i+1]){
                    new_nums[unique_elements] = nums[i+1];
                    unique_elements += 1;
                }
            }
            for (int i = 0; i < new_nums.Length; i++){
                nums[i] = new_nums[i];
            }
            
            return unique_elements;
        }
        else {
            return 0;
        }
        
    }
}