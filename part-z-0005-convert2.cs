var x = "17.212154777777777777777777777";

var x_int = x.Split(".")[0];
var x_dec = "0." + x.Split(".")[1];

System.Console.WriteLine(x_int);
System.Console.WriteLine(x_dec);

var x1 = Convert.ToInt16(x_int);

var x2 = Convert.ToUInt64(x_int);

var x3 = Convert.ToDecimal(x_dec);

var x4 = Convert.ToDouble(x_dec);

System.Console.WriteLine(x1);
System.Console.WriteLine(x2);
System.Console.WriteLine(x3);
System.Console.WriteLine(x4);

// 17
// 0.212154777777777777777777777
// 17
// 17
// 0.212154777777777777777777777
// 0.21215477777777778

//dotnet run
