// byte age;

// System.Console.WriteLine(age); //  error CS0165: Use of unassigned local variable 'age'

byte? age = null;

age = 77;

short? year = null;

year = 2026;

System.Console.WriteLine(age); 
System.Console.WriteLine(year); 


// dotnet run
