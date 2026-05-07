using System.ComponentModel;

byte[] ages = new byte[5]{11, 14, 37, 47, 73};

for (var i = ages.Length - 1; i >= 0; i--)
{
    System.Console.WriteLine($"Age: {ages[i]}");
}

// Age: 73
// Age: 47
// Age: 37
// Age: 14
// Age: 11
