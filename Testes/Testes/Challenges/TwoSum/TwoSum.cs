namespace LeetCodeChallenges.TwoSum
{
    public class Solution
    {
        //My solution > best time: 145ms
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { 0, 0 };
        }


    }
}
/*Optimized solution > best time: 83ms

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int temp = target - nums[i];

            if (seen.ContainsKey(temp))
            {
                return new int[] { seen[temp], i };
            }
            seen[nums[i]] = i;
        }
        return null;
    }
}


The difference in runtime between the two codes is due to the difference in time complexity of the algorithms.

In your original code, you are using two nested loops to iterate through the array. This results in a time 
complexity of O(n2), where n is the number of elements in the array. This means that for each element in the 
array, you are iterating through the entire array again. This can be quite inefficient, especially for large arrays.

In the second code, a dictionary is used to store the numbers that have been seen and their positions. Then, for 
each number, you check if the difference between the target and that number has been seen before. If so, you return 
the positions of those two numbers. If not, you add the number to the dictionary. This results in a time complexity 
of O(n), as you are iterating through the array only once. This is much more efficient, especially for large arrays, 
and that’s why the second code has a lower runtime.

 */