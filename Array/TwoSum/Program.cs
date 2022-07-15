static class Program
{
    /// <summary>
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// Example:
    /// Given nums = [2, 7, 11, 15], target = 9,
    /// Because nums[0] + nums[1] = 2 + 7 = 9,
    /// return [0, 1].
    /// </summary>
    static void Main(string [] args)
    {
        int [] nums = { 1, 2, 3 };
        int target = nums[2];
        int [] result = FindIndicesOfTwoSum(nums,target);
    }

    private static int[] FindIndicesOfTwoSum(int[] nums, int target)
    {
        var result = new int[2];                                //1
        var seenLogs = new Dictionary<int, int>();              //2
        for (int index = 0; index < nums.Length; ++index)       //4+6n
        {
            // Subtract the target from the current array index.
            int remaining = target - nums[index];                      //4n

            // Check if we have 'logged' this remaining value before
            if (seenLogs.ContainsKey(remaining))                           //3n
            {
                result[0] = seenLogs[remaining];                                  //3n
                result[1] = index;                                                  //3n
            }

            // log the number and index since they are seen for the first time
            seenLogs[nums[index]] = index;                                              //4

        }
        return result;                                                                   //1
    }
}

//Time Complexity:12+18n
//O(n)