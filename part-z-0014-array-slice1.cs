string[] names = {"Ayhan", "Aykan", "Ayman", "Aykul", "Ayben", "Aygül", "Aysel", "Aysu"};

var namesSlice = names[2..6];

foreach(var n in namesSlice)
{
    System.Console.WriteLine(n);
}

// Ayman
// Aykul
// Ayben
// Aygül

// dotnet run
