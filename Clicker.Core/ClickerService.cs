namespace ClickerApp.Core
{
    public class ClickerService
    {
        public static ClickerResult ProcessKey(ConsoleKey key, Clicker clicker)
        {
            if (key == ConsoleKey.Spacebar) // business logic 
            {
                clicker.Increment();
                return ClickerResult.Incremented;
            }

            if (key == ConsoleKey.Escape)
            {
                return ClickerResult.Exit;
            }

            return ClickerResult.NoAction;
        }
    }
}
