Employee empAyhan = new Employee("Ayhan Bilir", "ab004296", "HR");

Employee empBengu = new Employee("Bengü Bilici", "bb009684", "Sales");

empBengu.salaryUSD = 3000;
empBengu.isMarried = true;

public class Employee
{
    public string name;
    public string empID;
    public string department;
    public ushort salaryUSD;
    public bool isMarried;

    // adding constructor
    public Employee(string name, string empID, string department)
    {
        this.name = name; // required
        this.empID = empID; // required
        this.department = department; // required

        // salaryUSD = 0 and isMarried = false (default)
    }

    public void salaryInc(ushort amount)
    {
        salaryUSD += amount;
    }

    public void printInfo()
    {
        System.Console.WriteLine($"ID: {empID} | Name: {name} | Department: {department} | Salary: {salaryUSD}$");
    }
}

// dotnet run
