//void Greet()
//{
//    Console.WriteLine("Hello World !");
//}
//Greet();
//void Add(int a, int b)
//{
//    Console.WriteLine(a + b);
//}
//int x = 6, y = 5;
//Add(x, y);

// Return value from function.
//int Add(int a, int b)
//{
//    return a + b;
//}
//int result = Add(90, 4);
//Console.WriteLine(result);

//string return type method.

//string Add(int a, int b)
//{
//    return (a + b).ToString();
//}
//string result = Add(90, 4);
//Console.WriteLine(result);

//Optional parameters.

//void ShowData(string name, string email = "Me@mail.com")
//{
//    Console.WriteLine("Name: " + name);
//    Console.WriteLine("Email: " + email);
//}
//ShowData("John","EMail/com");
//ShowData("hopper");

// Named parameter .

//void ShowData(string name, string email = null, string Phone = null)
//{ 
//    Console.WriteLine("Name:"+name);
//    Console.WriteLine("Email:" + email);
//    Console.WriteLine("Phone:" +Phone);
//}
//ShowData("John", Phone:"76764986668");

//Params int.

void Add(int x, int y, params int[] numbers)
{
    int sum = x + y;
	foreach (int i in numbers)
	{
		sum += i;
	}
	Console.WriteLine(sum);
}
Add(1, 2);
Add(2, 3, 5, 7);

