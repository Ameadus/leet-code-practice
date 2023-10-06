using System;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        // Nothing was found
        return null;
    }
}

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int targetSum = 7;

        Solution solution = new Solution();
        var indexesWithSum = solution.TwoSum(array, targetSum);

        // Print the result
        Console.WriteLine("[" + string.Join(",", indexesWithSum) + "]");
    }
}