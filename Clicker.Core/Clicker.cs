namespace ClickerApp.Core
{
    public class Clicker
    {
        public int Count { get; private set; }
        public string CountStr => "" + Count;

        public Clicker()
        {
        }

        public Clicker(string count)
        {
            Count = int.Parse(count);
        }

        public void Increment()
        {
            Count++;
        }
    }
}
