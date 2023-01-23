using System.Reflection.Metadata;
using System.Text;

Console.WriteLine("Hello world.\r Bei.."); // Carriage return \r.

String txt = "JS is a \"programming\" language";

Console.WriteLine(txt);

Console.WriteLine("Hello \\world Bei.. world\\"); //   \\.

Console.WriteLine(@"This a line, 
this is another line,
this is third line"); // Varbatim string @"-------".

int[] arr1 = {1,2,3,4,45,5,6,7,89,0};

foreach(int i in arr1)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nthis is sorted\n");
Array.Sort(arr1);

foreach (int i in arr1)
{
    Console.WriteLine(i);
}

Console.WriteLine(string.Join(",", arr1)); // Using string join. 

// String interpolation

string firstname = "John";
string secondname = "Doe";
int age = 25;

string message = $"{firstname} {secondname} is {age} years old.";
Console.WriteLine(message);

// String Format.

string message2 = string.Format("{0} {1} is {2} years old",firstname, secondname, age);
Console.WriteLine(message2);

// StringJoin.

string name = "MUHA";
string LastName = "MMED";
string FullName = string.Join("",name, LastName);
Console.WriteLine(FullName);

// Concat.

string name2 = "MUHA";
string LastName2 = "MMED";
string FullName2 = string.Concat("", name2, LastName2);
Console.WriteLine(FullName2);

// String Builder Class.

var sb = new StringBuilder();
sb.AppendLine("Hello"); // AppendLine.
sb.Append("World");  //Append.
sb.Append(".!");
sb.AppendFormat("The number is 42");
String text = sb.ToString();
Console.WriteLine(text);

// String function.

// Case Conversion.

string data = "This is a text";
Console.WriteLine(data.ToUpper());
Console.WriteLine(data.ToLower());

// Trim.
Console.WriteLine(data.Trim());

// Find Substring.
string data2 = "John,Jane,and Joe are my freinds ";
Console.WriteLine(data2.IndexOf("Jane")); // 5.
Console.WriteLine(data2.IndexOf("jef"));// -n.

// Contains.
Console.WriteLine(data2.Contains("John"));
Console.WriteLine(data2.Contains("Doe"));

// ToCharArray.
string data3 = "Hellooo World";
char[] chars = data3.ToCharArray();

foreach(char c in chars)
{
    Console.WriteLine(c);
}

// Split.

string data4 = "Hello World";
string[] words3 = data4.Split(' ');
Console.WriteLine(words3);