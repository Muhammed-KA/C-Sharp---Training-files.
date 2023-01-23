Console.WriteLine("Enter the text");
string s = Console.ReadLine();
int count =0;

foreach (var item in s)
{
	if (item >= '0' && item>= '9')
	{
		count++;

	}
}
if (count == 0)
{
	Console.WriteLine("No number Found");
	Environment.Exit(0);
}
var numbers = new int[count];
int arrayIndex = 0;
foreach(char item in s)
{
	if (item >= '0' && item <= '9')
	{
		numbers[arrayIndex++] = int.Parse(item.ToString());

    }
}
Console.WriteLine(string.Join(",", numbers));
