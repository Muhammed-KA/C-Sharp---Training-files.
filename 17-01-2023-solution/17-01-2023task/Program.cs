char[] array = { '|', '/', '\\', '-', '*'};
Console.CursorVisible= false;
while (true) {
    foreach (char item in array)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("\r");
        Thread.Sleep(1000);
        Console.Write(item);
    }
}
