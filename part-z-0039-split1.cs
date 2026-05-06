var x = "17.212154777777777777777777777";

var x_int = x.Split(".")[0];

var x_dec = "0." + x.Split(".")[1];

System.Console.WriteLine(x_int);
System.Console.WriteLine(x_dec);


// 17
// 0.212154777777777777777777777


//dotnet run
