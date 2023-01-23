var s = new Student();
s.Name = "john";
s.Mark1 = 40;
s.Mark2 = 50;

var s1 = new Student();
s1.Name = "Jane";
s1.Mark1 = 30;
s1.Mark2 = 50;

var s2 = new Student()
{
    Name = "Boom",
    Mark1 = 30,
    Mark2 = 80
};

Console.WriteLine(s1.Name);

Console.WriteLine($"Total Mark of {s1.Name} is { s1.Total()}");

Console.WriteLine(s.Name);
Console.WriteLine($"Total Mark of {s.Name} is {s.Total()}");


Console.WriteLine(s2.Name);
Console.WriteLine($"Total Mark of {s2.Name} is {s2.Total()}");

class Student
{
    public string Name;
    public int Mark1;
    public int Mark2;
    public int Total()
    {
        return Mark1 + Mark2;
    }
}