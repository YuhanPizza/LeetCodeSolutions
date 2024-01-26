public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] potato = new int[n + m];
        int i = 0;
        int j = 0;
        int k = 0;

        while(j < n &&  i < m){
            if(nums1[i] > nums2[j]){
               potato[k] = nums2[j];
               j++;
            }else{
               potato[k] = nums1[i];
               i++;
            }
            k++;
        }

        while(j < n){
            potato[k] = nums2[j];
            j++;
            k++;
        }
        while(i < m){
            potato[k] = nums1[i];
            i++;
            k++;
        }
        for(int x= 0; x < m + n; x++){
            nums1[x] = potato[x];
        }
    }
}