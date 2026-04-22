byte? age = null;

age = 77;

short? year = null;

System.Console.WriteLine(age.HasValue);

System.Console.WriteLine(year.GetValueOrDefault());

// True
// 0


// dotnet run
