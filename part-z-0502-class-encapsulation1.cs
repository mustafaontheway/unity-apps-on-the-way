SalesResult r1 = new SalesResult(110000, 78000);

r1.ProfitLoss();

SalesResult r2 = new SalesResult(110000, 780000);

r2.ProfitLoss();
class SalesResult
{
    private ulong _sales;
    private ulong _cost;

    // Adding Encapsulation...

    public ulong Sales
    {
        get => _sales;
        set => _sales = value; // we can think "value" is cashier/teller
    }

    public ulong Cost
    {
        get => _cost;

        set
        {
            _cost = value == 0 ? 1 : value;
        }
    }

    // constructor
    public SalesResult(ulong sales, ulong cost)
    {
        Sales = sales;
        Cost = cost;
    }

    public void ProfitLoss()
    {
        if (Sales >= Cost)
        {
            System.Console.WriteLine($"Profit Amount $: {Sales - Cost}");
        }
        else
        {
            System.Console.WriteLine($"Loss Amount $: {Cost - Sales}");
        }
    }

}

// Profit Amount $: 32000
// Loss Amount $: 670000

// dotnet run
