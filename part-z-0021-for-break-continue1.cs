for (byte i = 0; i < 20; i += 2)
{
    if (i == 8) { continue; }

    if (i == 14) { break; }

    System.Console.WriteLine($"Counter value: {i}");
}

// Counter value: 0
// Counter value: 2
// Counter value: 4
// Counter value: 6
// Counter value: 10
// Counter value: 12
