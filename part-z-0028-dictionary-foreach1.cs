using System.Collections.Generic;

Dictionary<string, byte> agesByNames = new Dictionary<string, byte> () {{"Aygün Bilir", 36}};

agesByNames.Add("Ayhan Bilir", 99);

agesByNames.Add("Hakan Bilir", 19);

foreach (var p in agesByNames)
{
    System.Console.WriteLine($"Name: {p.Key} and age: {p.Value}");
}

// Name: Aygün Bilir and age: 36
// Name: Ayhan Bilir and age: 99
// Name: Hakan Bilir and age: 19

// dotnet run
