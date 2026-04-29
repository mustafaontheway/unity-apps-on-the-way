Employee empAyhan = new Employee 
{
    name = "Ayhan Bilir",
    empID = "ab004254",
    department = "HR",
    salaryUSD = 4200,
    isMarried = true
};

Employee empAygun = new Employee
{
    name = "Aygün Kaplan",
    empID = "ak009874",
    department = "Operations",
    salaryUSD = 4000,
    isMarried = false
};

empAygun.printInfo(); // ID: ak009874 | Name: Aygün Kaplan | Department: Operations | Salary: 4000$

public class Employee
{
    public string name;
    public string empID;
    public string department;
    public ushort salaryUSD;
    public bool isMarried;

    public void printInfo()
    {
        System.Console.WriteLine($"ID: {empID} | Name: {name} | Department: {department} | Salary: {salaryUSD}$");
    }
}

// dotnet run
