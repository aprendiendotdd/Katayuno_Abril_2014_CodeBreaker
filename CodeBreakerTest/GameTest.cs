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

    [Test]
    public void ReturnXWhenFirstCharCodeAndPasswordIsTheSame()
    {
      var game = new Game();
      Assert.AreEqual("X", game.GetResultGame("RRRR", "RAAAA"));
    }
  }
}
