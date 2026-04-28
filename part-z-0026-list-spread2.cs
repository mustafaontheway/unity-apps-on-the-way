using System.Collections.Generic;

List<byte> ages1 = new List<byte> {77, 47, 100};

List<byte> ages2 = new List<byte> {99, 89, 79};

List<byte> allAges = [..ages1, ..ages2, 3, 13];

foreach (var age in allAges)
{
    System.Console.WriteLine($"Age: {age}");
}

// Age: 77
// Age: 47
// Age: 100
// Age: 99
// Age: 89
// Age: 79
// Age: 3
// Age: 13

// dotnet run
