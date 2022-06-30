namespace Leetcode.median_of_two_sorted_arrays;

public class Solution {
    /*Runtime: 177 ms, faster than 24.11% of C# online submissions for Median of Two Sorted Arrays.
        Memory Usage: 39.8 MB, less than 45.15% of C# online submissions for Median of Two Sorted Arrays.*/

    /*public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var pointer1 = 0;
        var pointer2 = 0;
        var totalLength = ((double)nums1.Length + (double)nums2.Length);
        //var isDouble = totalLength % 2 == 0 ? true : false;
        var sortedList = new List<int>();
        while (totalLength > sortedList.Count)
        {
            if (nums1.Length > pointer1 && nums2.Length > pointer2)
            {
                if (nums1[pointer1] < nums2[pointer2])
                {
                    sortedList.Add(nums1[pointer1]);
                    pointer1++;
                }
                else
                {
                    sortedList.Add(nums2[pointer2]);
                    pointer2++;
                }
            }
            else if (nums1.Length > pointer1)
            {
                sortedList.Add(nums1[pointer1]);
                pointer1++;
            }
            else
            {
                sortedList.Add(nums2[pointer2]);
                pointer2++;
            }
        }

        var midPoint = sortedList.Count / 2;
        return sortedList.Count % 2 == 0
            ? (double)(sortedList[midPoint] + sortedList[midPoint - 1]) / 2
            : (double)sortedList[(int)midPoint];

    }*/
    
    
    //attempt to speed it up by only looking at half the stuff but I really just made it slower. 
    //could still speed it up by not storing values I guess
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var pointer1 = 0;
        var pointer2 = 0;
        var totalLength = (nums1.Length + nums2.Length) / 2.0;
        var isDouble = totalLength % 2 == 0 ? true : false;
        var sortedList = new List<int>();
        while (totalLength >= sortedList.Count)
        {
            if(nums1.Length > pointer1 && nums2.Length > pointer2)
            {
                if (nums1[pointer1] < nums2[pointer2])
                {
                    sortedList.Add(nums1[pointer1]);
                    pointer1++;
                }
                else
                {
                    sortedList.Add(nums2[pointer2]);
                    pointer2++;  
                }
            }else if (nums1.Length > pointer1)
            {
                sortedList.Add(nums1[pointer1]);
                pointer1++;
            }
            else
            {
                sortedList.Add(nums2[pointer2]);
                pointer2++;
            }
        }
        
        return totalLength - Math.Truncate(totalLength) == 0 ? ((double)sortedList.Last() + (double)sortedList[^2]) / (double)2.00 : (double)sortedList.Last();

    }
    
}