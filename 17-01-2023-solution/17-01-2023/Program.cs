// Looping statements.

//for loop

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(i);
//}

//For loop without value initialization.

//int i = 0;
//for(;i < 5; i++)
//{
//    Console.WriteLine($"value of i after loop: {i}");
//}

// For loop without a condition

//int i = 0;
//for (;;)
//{
//    //Console.WriteLine(i++); //Endless loop Bomb
//}

// While loop.

//int i = 0;
//while (i < 5)
//{
//    Console.WriteLine(i++);
//}

//Endless loop while

//while ()
//{
//    Console.WriteLine(i++);
//    break;
//}

// Do While loop.

//int i = 0;
//do
//{
//    Console.WriteLine(i++);
//} while (i < 5);

// For Each Loop.

//using System;

//int[] number = {1, 2, 3, 4, 5, 6, 7};

//foreach () // not completed.
//{
//    Console.WriteLine(number);
//}

//If LOOP.

//int total = 80;

//if(total >= 50)
//{
//    Console.WriteLine("passed:");
//}

//IF & ELSE.

//int total = 80;

//if (total >= 50)
//{
//    Console.WriteLine("passed:");
//}
//else
//{
//    Console.WriteLine("failed");
//}

//Switch cases.

//string number = "ONE";

//switch (number.ToLower())
//{
//	case "ONE":
//	case "one":
//		Console.WriteLine("THE NUMBER IS ONE");
//		break;
//	case "TWO":
//	case "two":
//		Console.WriteLine("THE NUMBER IS TWO");
//		break;
//    case "THREE":
//    case "three":
//        Console.WriteLine("THE NUMBER IS THREE");
//        break;
//    default:
//		break;
//}

// Another switch method.

//int number = 6;
//string result = number switch
//{
//    1 => "Number is 1",
//    2 => "Number is 2",
//    3 => "Number is 3",
//    4 => "Number is 4",
//    5 => "Number is 5",
//    6 => "Number is 6",
//    7 => "Number is 7",
//    _ => "Number is not 1,2 or 3"

//};
//Console.WriteLine(result);

//Break  And Continue statements.

//for (int i = 0; i < 10; i++)
//{
//	if (i == 2)
//	{
//		break;
//	}
//	Console.WriteLine(i);
//}


// Continue statement.

//for (int i = 0; i < 10; i++)
//{
//	if (i % 2 != 0)
//	{
//		continue;
//	}
//	Console.WriteLine(i);
//}

//Object.

//object o = 7;
//object s = "Hello";
//object[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 19, 10, "Seven" };
//Console.WriteLine(o);

//Console.WriteLine(o.GetType());

//Console.WriteLine(s.GetType());

//foreach (object item in data)
//{
//    Console.WriteLine(item);
//}

// object type (type of data type).

//int sum = 0;
//foreach(object item in data)
//{
//    var toi = item.GetType();
//	if (toi == typeof(int))
//	{
//		sum+= (int)item;
//	}
//}
//Console.WriteLine(sum);

// Dynamic Type.

//dynamic d = "Hello";
//Console.WriteLine(d.ToUpper());   

//Boxing AND Unboxing.

//Anonymous object

var obj = new
{
    name = "John Doe",
    email = "johndoe@email.com"
};
Console.WriteLine(obj.email);