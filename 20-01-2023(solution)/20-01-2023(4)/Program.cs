var employees = new List<Dictionary<string,string>>();
while (true)
{
    Console.WriteLine("1. Add Employee-");
    Console.WriteLine("2. View Employee-");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddEmployee();
            break;
        case "2":
            DisplayEmployee();
            break;
        default:
            break;
    }

    void AddEmployee()
    {
        var dict = new Dictionary<string,string>();

        Console.WriteLine("Enter the name:-");
        dict["Name"] = Console.ReadLine();

        Console.WriteLine("Enter the age:-");
        dict["Age"] = Console.ReadLine();

        employees.Add(dict);
    }

    void DisplayEmployee()
    {
        foreach (var employee in employees)
        {
            Console.WriteLine($"***{employee["Name"]}***");
            Console.WriteLine($"Age: {employee["Age"]}");
            Console.WriteLine(new string('-',30));
        }
        
    }
}