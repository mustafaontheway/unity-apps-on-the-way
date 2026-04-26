byte[] ages = {17, 99, 21, 10, 8, 55, 14, 74};

uint sum = 0;

foreach (var age in ages)
{
    sum += age;
}

System.Console.WriteLine(sum); // 298
