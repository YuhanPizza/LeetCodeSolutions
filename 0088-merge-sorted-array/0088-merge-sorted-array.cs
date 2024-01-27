public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int total = m + n;
        int i = 0; int k = 0; int j = 0; 
        int[] potato = new int [total];

        while( i < m && j < n){
            if(nums1[i] < nums2[j]){
                potato[k] = nums1[i];
                i++;
            }else{
                potato[k] = nums2[j];
                j++;
            }
            k++;
        }

        while(i < m){
            potato[k] = nums1[i];
            i++;
            k++;
        }

        while(j < n){
            potato[k] = nums2[j];
            j++;
            k++;
        }

        for(int x = 0; x < total; x++){
            nums1[x] = potato[x];
        }
    }
}