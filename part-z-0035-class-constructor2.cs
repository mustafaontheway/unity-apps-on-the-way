Employee empAyhan = new Employee("Ayhan Bilir", "ab004296", "HR");

Employee empBengu = new Employee("Bengü Bilici", "bb009684", "Sales", 3000, true);


public class Employee
{
    public string name;
    public string empID;
    public string department;
    public ushort salaryUSD;
    public bool isMarried;

    // adding constructor
    public Employee(string name, string empID, string department, ushort salaryUSD = 0, bool isMarried = false)
    {
        this.name = name; // required
        this.empID = empID; // required
        this.department = department; // required

        this.salaryUSD = salaryUSD;
        this.isMarried = isMarried;
    }

    public void salaryInc(ushort amount)
    {
        salaryUSD += amount;
    }

    public void printInfo()
    {
        System.Console.WriteLine($"ID: {empID} | Name: {name} | Department: {department}");
    }
}

// dotnet run
