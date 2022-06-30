namespace Leetcode;


/*var twosumArgs = new[] { -1, -2, -3, -4, -5 }; Example Input
var targetValue = -8;
var output = Leetcode.TwoSum.Solution(twosumArgs, targetValue);
Console.WriteLine(output[0] +" , "+ output[1]);*/
public  class TwoSum {
    public static int[] Solution(int[] nums, int target)
    {
        /*Runtime: 167 ms, faster than 87.69% of C# online submissions for Two Sum.
        Memory Usage: 42.7 MB, less than 80.69% of C# online submissions for Two Sum.*/
        var min = nums.Min();
        var max = nums.Max();
        
        for(var i = 0; i< nums.Length;i++){
           if (nums[i]+min > target || nums[i]+max < target) {continue;}

            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new[] { i, j };
                }
            }
        }

        return new[] { 0, 0 };
    }
}