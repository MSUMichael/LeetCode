public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        if (nums.Length>0){
            int unique_elements = 1;
            
            for (int i = 0; i < nums.Length-1; i++){

                if (nums[i] != nums[i+1]){
                    nums[unique_elements] = nums[i+1];
                    unique_elements += 1;
                }
            }
            
            return unique_elements;
        }
        else {
            return 0;
        }
        
    }
}