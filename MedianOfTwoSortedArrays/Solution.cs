public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int[] mergedArray = new int[nums1.Length + nums2.Length];
        
        // merge 2 arrays
        int num1pos = 0, num2pos = 0;
        while (num1pos < nums1.Length || num2pos < nums2.Length)
        {
            int mergedPos = num1pos + num2pos;
            if(num2pos < nums2.Length && (num1pos == nums1.Length || nums1[num1pos] > nums2[num2pos]))
            {
                mergedArray[mergedPos] = nums2[num2pos];
                num2pos ++;
            } 
            else if (num1pos < nums1.Length)
            {
                mergedArray[mergedPos] = nums1[num1pos];
                num1pos ++;
            }
        }
        
        // get median value
        if(mergedArray.Length % 2 == 1)
        {
            return mergedArray[mergedArray.Length/2];
        }
        else
        {
            return (mergedArray[mergedArray.Length/2]+mergedArray[(mergedArray.Length/2)-1])/2.0;
        }
    }
}
