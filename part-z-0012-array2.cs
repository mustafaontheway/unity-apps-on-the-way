string[] names = new string[10];

names[0] = "Ayhan";
names[1] = "Aykan";
names[2] = "Ayman";
names[3] = "Aykul";
names[4] = "Ayben";
names[5] = "Aygül";
names[6] = "Aysel";
names[7] = "Aysu";

System.Console.WriteLine(names.Length);

var result = Array.IndexOf(names, "Aysel");

System.Console.WriteLine(result);

// 10
// 6


// dotnet run
