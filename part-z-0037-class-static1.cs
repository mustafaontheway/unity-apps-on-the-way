UserMath.ageCalc(1977, 2010);

UserMath.ageCalc(2025, 1960);


public static class UserMath
{
    public static void ageCalc(ushort year, ushort birthYear) 
    {
        if (year < birthYear)
        {
            System.Console.WriteLine("You hadn't been born yet!");
        } 
        else
        {
            System.Console.WriteLine($"You were/will/are {year - birthYear} years old.");
        }
    }
}

// You hadn't been born yet!
// You were/will/are 65 years old.
