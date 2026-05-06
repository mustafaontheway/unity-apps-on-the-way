sbyte x = 3;

sbyte y = -3;

SwapNumbers1(x, y);

System.Console.WriteLine($"x value: {x}");

System.Console.WriteLine($"y value: {y}");

static void SwapNumbers1(sbyte a, sbyte b)
{
    a = b;
    b = a;
}

System.Console.WriteLine("----------------------------------");

static (sbyte, sbyte) SwapNumbers2(sbyte a, sbyte b)
{
    return (b, a);
}

(x, y) = SwapNumbers2(x, y);

System.Console.WriteLine($"x value: {x}");

System.Console.WriteLine($"y value: {y}");

// x value: 3
// y value: -3
// ----------------------------------
// x value: -3
// y value: 3



// dotnet run
