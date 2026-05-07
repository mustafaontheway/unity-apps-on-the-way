byte[] grades = {85, 64, 78, 98, 42, 32, 14, 25, 75, 50};

countSuccess(grades); // Number of successful students: 5


static void countSuccess(byte[] grades)
{
    ushort count = 0;
    
    foreach (var g in grades)
    {
        if (g > 60)
        {
            count++;
        }
    }

    System.Console.WriteLine("Number of successful students: " + count);
}

