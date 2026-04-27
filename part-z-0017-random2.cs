string[] names = {"Ayhan", "Bengü", "Bilgin", "Kutluk", "Bumin"};

var r = new Random();

var winnerIndex = r.Next(names.Length);

System.Console.WriteLine($"Winner: {names[winnerIndex]}");
