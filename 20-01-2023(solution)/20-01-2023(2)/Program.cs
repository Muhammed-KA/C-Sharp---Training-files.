//List<int> lst = new List<int>();
//or
var lst = new List<int>() {400, 200, 500};

var ns = new List<int> { 700, 800, 900};

lst.AddRange(ns);

//lst.Add(5);  //add will add item in last position.
//lst.Add(10);
//lst.Add(15);

//lst[1] = 25;    //Replace in the position 1.

//lst.Remove(200);  //Remove value 200 from the list.

//lst.RemoveAt(1);  //Remove value  from position 1  the list.


Console.WriteLine(string.Join(", ", lst));  //400, 200, 500, 5, 10, 15 -Out put

//Console.WriteLine($"count of list:-{lst.Count}");

//foreach (var item in lst)
//{
//    Console.WriteLine(item);
//}

//var Lst2 = new List<string>();
//for(int i = 0;i < 5; i++)
//{
//    Console.Write($"Enter the Name{i+1}:-");
//    Lst2.Add(Console.ReadLine());
//}

//foreach(string i in Lst2)
//{
//    Console.WriteLine(i);
//}