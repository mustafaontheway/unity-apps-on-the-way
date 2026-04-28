using System.Collections.Generic;

Dictionary<string, byte> agesByNames = new Dictionary<string, byte> () {{"Aygün Bilir", 36}};

agesByNames.Add("Ayhan Bilir", 99);

agesByNames.Add("Hakan Bilir", 19);

agesByNames.Remove("Ayhan Bilir");

System.Console.WriteLine(agesByNames.Count); // 2

// dotnet run
