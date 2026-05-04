using ClickerApp.Core;

Clicker clicker;

var fileName = "clicker.data";
if (File.Exists(fileName))
{
    var count = File.ReadAllText(fileName);
    clicker = new Clicker(count);
}
else
{
    clicker = new Clicker();
}

while (true)
{
    Console.Clear();
    Console.WriteLine(clicker.Count);
    Console.WriteLine("<trykk på space for poeng - eller ESC for avslutt>");

    var key = Console.ReadKey();
    var result = ClickerService.ProcessKey(key.Key, clicker);

    if (result == ClickerResult.Incremented)
    {
        File.WriteAllText(fileName, clicker.CountStr);
    }
    else if (result == ClickerResult.Exit)
    {
        return;
    }
}

/*

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
 */
