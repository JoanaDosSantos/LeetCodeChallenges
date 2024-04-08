using LeetCodeChallenges.TwoSum;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
        int target = Convert.ToInt32(Console.ReadLine());
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine("[" + result[0] + ", " + result[1] + "]");
    }
}
