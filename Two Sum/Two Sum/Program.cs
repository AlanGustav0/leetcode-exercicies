

int[] numbers = [2, 5, 5, 11];

var result = TwoSum(numbers, 10);

foreach (var number in result)
{
    Console.WriteLine(number);
}


int[] TwoSum(int[] nums, int target)
{
    var outputIndex = new List<int>();

    for(int i = 0;i < nums.Length -1; i++)
    {
        for(int j = i + 1;j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                outputIndex.Add(i);
                outputIndex.Add(j);
            }
        }
    }

    return outputIndex.ToArray();
}
