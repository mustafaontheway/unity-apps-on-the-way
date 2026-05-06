sbyte[] nums = {3, -3};

System.Console.WriteLine($"Number 1: {nums[0]}");

System.Console.WriteLine($"Number 2: {nums[1]}");

System.Console.WriteLine("----------------------------------");

SwapNumbers(nums);

static void SwapNumbers(sbyte[] myNums)
{
   sbyte temp = myNums[0];
   myNums[0] = myNums[1];
   myNums[1] = temp;
}

System.Console.WriteLine($"Number 1: {nums[0]}");

System.Console.WriteLine($"Number 2: {nums[1]}");

// Number 1: 3
// Number 2: -3
// ----------------------------------
// Number 1: -3
// Number 2: 3




// dotnet run
