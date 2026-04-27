string[] names = {"Ayhan", "Bengü", "Bilgin", "Kutluk", "Bumin"};

var r = new Random(2026); // Seed!

var winnerIndex = r.Next(names.Length);

System.Console.WriteLine($"Winner: {names[winnerIndex]}");

// Winner: Ayhan

// dotnet run 
