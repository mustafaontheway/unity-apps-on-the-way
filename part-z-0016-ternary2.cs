byte age = 87;

bool citizen = false;

var canWork = (age >= 18 && age < 80) && citizen ? "Yes" : "No";

System.Console.WriteLine(canWork); // No
