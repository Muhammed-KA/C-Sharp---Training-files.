using System.Collections.Generic; //for using list,stack,que,Dictionary..etc in old version of c#.

//Dictionary.

Dictionary<string, string> dict1 = new Dictionary<string, string>();
dict1.Add("Name", "John");
dict1.Add("Age", "35");
dict1["planet"] = "Earth";
dict1["planet"] = "Mars";  //Replace or updating an elements value.


//Console.WriteLine(dict1["Name"]);
//Console.WriteLine(dict1["Age"]);

foreach (var item in dict1)
{
    Console.WriteLine(item.Key + ":" + item.Value);
}

//string s = "muhammedka";
//foreach(var item in s)
//{
//    Console.Write(item == 'm' ? '*' :item);
//}
