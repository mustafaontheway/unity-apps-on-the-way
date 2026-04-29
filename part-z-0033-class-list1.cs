using System.Collections.Generic;

List<Employee> allEmps = new List<Employee>();

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

allEmps.Add(empAygun);
allEmps.Add(empAyhan);

public class Employee
{
    public string name;
    public string empID;
    public string department;
    public ushort salaryUSD;
    public bool isMarried;
}

// dotnet run
