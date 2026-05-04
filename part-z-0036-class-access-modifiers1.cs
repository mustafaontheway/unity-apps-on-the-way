Employee empBengu = new Employee("Bengü Bilici", "bb009684", "Sales", 3000, true);

empBengu.printInfo(); // ID: bb009684 | Name: Bengü Bilici | Department: Sales | Salary: $ 3000 | Marriage: True 

//System.Console.WriteLine(empBengu.salaryUSD); // 'Employee.salaryUSD' is inaccessible due to its protection level

public class Employee
{
    public string name;
    public string empID;
    public string department;
    private ushort salaryUSD;
    private bool isMarried;

    // adding constructor
    public Employee(string name, string empID, string department, ushort salaryUSD, bool isMarried)
    {
        this.name = name; 
        this.empID = empID; 
        this.department = department; 
        this.salaryUSD = salaryUSD;
        this.isMarried = isMarried;
    }

    public void salaryInc(ushort amount)
    {
        salaryUSD += amount;
    }

    public void printInfo()
    {
        System.Console.WriteLine($"ID: {empID} | Name: {name} | Department: {department} | Salary: $ {salaryUSD} | Marriage: {isMarried} ");
    }
}

// dotnet run
