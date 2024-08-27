namespace MyApplication
{
    public class ListTwoSum
    {
        public static int[] twoSum(List<int> num, int target)
        {
            Dictionary<int, int> numToIndex = new Dictionary<int, int>();

            for (int i = 0; i < num.Count; i++)
            {

                int nums = num[i];
                int complement = target - nums;

                if (numToIndex.ContainsKey(complement))
                {

                    return new int[] { numToIndex[complement] + 1, i + 1 };

                }
                numToIndex[nums] = i;

            }
            return null;
        }
    }

}
