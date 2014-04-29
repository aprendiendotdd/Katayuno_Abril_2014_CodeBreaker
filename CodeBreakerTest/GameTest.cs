using CodeBreaker;
using NUnit.Framework;

namespace CodeBreakerTest
{
  [TestFixture]
  public class GameTest
  {
    [Test]
    public void ReturnEmptyStringWhenPasswordCharsNotMatchCodeChars()
    {
      var game = new Game();
      Assert.AreEqual("", game.GetResultGame("RRRR", "AAAA"));
    }
  }
}
