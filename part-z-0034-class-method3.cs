UserMath user1 = new UserMath(2000);

user1.ageCalc(2025); // You were/will/are 25 years old.
user1.ageCalc(2040); // You were/will/are 40 years old.
user1.ageCalc(1977); // You hadn't been born yet! 


public class UserMath
{
    private ushort birthYear;

    public UserMath(ushort birthYear) { this.birthYear = birthYear; }

    public void ageCalc(ushort year) 
    {
        if (year < this.birthYear)
        {
            System.Console.WriteLine("You hadn't been born yet!");
        } 
        else
        {
            System.Console.WriteLine($"You were/will/are {year - birthYear} years old.");
        }
    }
}
