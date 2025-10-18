public class Solution {
    public int MajorityElement(int[] nums) {

        Array.Sort(nums);
        return nums[nums.Length/2];
        /*
        int major = 0;

        for (int j = 0; j < nums.Length; j++){
            int tracker = nums[j], count = 0;
            for (int i = j; i < nums.Length; i++){
                if (tracker==nums[i]){
                    count++;
                }
                if (count > nums.Length/2){
                    major = tracker;
                }
            }
        }
        return major;
        */
    }

}
