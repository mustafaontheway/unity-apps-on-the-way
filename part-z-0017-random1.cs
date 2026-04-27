var r = new Random();

var num1 = r.Next();

System.Console.WriteLine(num1);

var num2 = r.Next(25, 750);

System.Console.WriteLine(num2);

var num3 = r.NextDouble();

System.Console.WriteLine(num3);

// 693313907
// 315
// 0.040036115347176215

// dotnet run 
