using CodeBreaker;
using NUnit.Framework;

namespace CodeBreakerTest
{
  [TestFixture]
  public class GameTest
  {
    private Game _game;

    [SetUp]
    public void SetUp()
    {
      _game = new Game();
    }

    [Test]
    public void ReturnEmptyStringWhenPasswordCharsNotMatchCodeChars()
    {
      Assert.AreEqual("", _game.GetResultGame("RRRR", "AAAA"));
    }

    [Test]
    public void ReturnXWhenACharCodeAndPasswordIsTheSame()
    {
      Assert.AreEqual("X", _game.GetResultGame("RRRR", "RAAA"));
      Assert.AreEqual("X", _game.GetResultGame("RRRR", "ARAA"));
      Assert.AreEqual("X", _game.GetResultGame("RRRR", "AARA"));
      Assert.AreEqual("X", _game.GetResultGame("RRRR", "AAAR"));
    }

    [Test]
    public void ReturnMoreXWhenTwoOrMoreCharsCodeAndPasswordAreTheSame()
    {
      Assert.AreEqual("XX", _game.GetResultGame("RAMV", "RANN"));
      Assert.AreEqual("XXX", _game.GetResultGame("RAMV", "RAMN"));
      Assert.AreEqual("XXXX", _game.GetResultGame("RAMV", "RAMV"));
    }
  }
}
