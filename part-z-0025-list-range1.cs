using System.Collections.Generic;

List<byte> ages = new List<byte> {77, 47, 100};

ages.AddRange(new byte[] {16, 46, 89});

System.Console.WriteLine(ages.Count); // 6
