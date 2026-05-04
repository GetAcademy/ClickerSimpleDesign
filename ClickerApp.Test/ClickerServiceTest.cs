using ClickerApp.Core;

namespace ClickerApp.Test
{
    public class ClickerServiceTest
    {
        [Test]
        public void TestIncrement()
        {
            // arrange
            var clicker = new Clicker("7");

            // act
            var result = ClickerService.ProcessKey(ConsoleKey.Spacebar, clicker);

            // assert
            Assert.That(clicker.Count, Is.EqualTo(8));
            Assert.That(result, Is.EqualTo(ClickerResult.Incremented));
        }
    }
}
