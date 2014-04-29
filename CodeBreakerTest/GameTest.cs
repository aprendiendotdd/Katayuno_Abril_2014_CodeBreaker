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
    public void ReturnXWhenACharCodeAndPasswordIsTheSame()
    {
      var game = new Game();
      Assert.AreEqual("X", game.GetResultGame("RRRR", "RAAA"));
      Assert.AreEqual("X", game.GetResultGame("RRRR", "ARAA"));
      Assert.AreEqual("X", game.GetResultGame("RRRR", "AARA"));
      Assert.AreEqual("X", game.GetResultGame("RRRR", "AAAR"));
    }
  }
}
