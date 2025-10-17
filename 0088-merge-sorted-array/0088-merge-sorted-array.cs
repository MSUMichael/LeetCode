public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        m -= 1;
        n -= 1;

        int i = nums1.Length-1;

        while (m >= 0 && n >= 0){
            if (nums1[m] >= nums2[n]){
                nums1[i] = nums1[m];
                m -= 1;
                i -= 1;
            }
            else if (nums1[m] < nums2[n]){
                nums1[i] = nums2[n];
                n -= 1;
                i -= 1;
            }
        }
        
        while (n >= 0){
            nums1[i] = nums2[n];
            n -= 1;
            i -= 1;
        }

    }
}