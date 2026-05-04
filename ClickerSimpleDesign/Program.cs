

var count = 0;

var fileName = "clicker.data";
if (File.Exists(fileName))
{
    var countStr = File.ReadAllText(fileName);
    count = int.Parse(countStr);
}

while (true)
{
    Console.Clear();
    Console.WriteLine(count);
    Console.WriteLine("<trykk på space for poeng - eller ESC for avslutt>");

    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.Spacebar)
    {
        count++;
        File.WriteAllText(fileName, "" + count);
    }
    else if (key.Key == ConsoleKey.Escape)
    {
        return;
    }
}
