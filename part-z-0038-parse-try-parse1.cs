System.Console.WriteLine("Type number 1: ");

string? num1 = Console.ReadLine();

System.Console.WriteLine("Type number 2: ");

string? num2 = Console.ReadLine();

if (num1 != null && num2 != null)
{
    System.Console.WriteLine($"{num1} + {num2} = {Double.Parse(num1) + Double.Parse(num2)}");
}
else
{
    System.Console.WriteLine("Some error... Try again!");
}

// Type number 1: 
// 12
// Type number 2: 
// 14.57
// 12 + 14.57 = 26.57
