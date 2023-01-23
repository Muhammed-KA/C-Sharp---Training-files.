// Date And time.

//DateTime dt = DateTime.Now;       //Not safe.
//Console.WriteLine(dt);            //Not safe.

//Solution for that.

DateTime dt = DateTime.Now;
Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss"));
Console.WriteLine(dt.ToString("yyyy/MM/dd HH:mm:ss"));

// Getting universal Time.

DateTime dt2 = DateTime.UtcNow;
Console.WriteLine(dt2.ToString("yyyy-MM-dd HH:mm:ss"));


//Creating a date and time object.

DateTime dt3 = new DateTime(2019,03,23,0,0,0);
Console.WriteLine(dt3.ToString("yyyy-MM-dd HH:mm:ss"));

//Parse a string to a date time.

string str = "2019-02-22 00:00:00";
DateTime dt4 = DateTime.Parse(str);
Console.WriteLine(dt4.ToString("yyyy-MM-dd HH:mm:ss"));

//Parsing value from date time.

DateTime dt5 = DateTime.Now;
Console.WriteLine(dt5.ToString("yyyy-MM-dd HH:mm:ss"));

//birth day.

var dt6 = new DateTime(2003,08,25,0,0,0);
Console.WriteLine(dt6.DayOfWeek);

//Time span.

TimeSpan ts = new TimeSpan();
Console.WriteLine(ts);


TimeSpan ts1 = new TimeSpan(2, 30, 45);
Console.WriteLine(ts1);

//Creating time span using methods.

var ts2 = TimeSpan.Zero;
Console.WriteLine("Time span zero:-" + ts2);

//time span from date,seconds,hours...

var ts3 = TimeSpan.FromSeconds(56);
Console.WriteLine("Time span seconds:-" + ts3);

//Adding TimeSpan.

//var



//Finding difference between two dates.
var dt9 = new DateTime(2018, 08, 19, 0, 0, 0);
var dt10 = new DateTime(2019, 02, 28, 0, 0, 0);

TimeSpan ts12 = dt10 - dt9;

Console.WriteLine($"Time span:- {ts12}");

Console.WriteLine($"Total days:- {ts12.TotalDays}");
Console.WriteLine($"Total seconds:- {ts12.TotalSeconds}");

