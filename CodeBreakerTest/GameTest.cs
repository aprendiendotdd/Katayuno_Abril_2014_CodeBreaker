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
      Assert.AreEqual("X", _game.GetResultGame("RAMV", "RNNN"));
      Assert.AreEqual("X", _game.GetResultGame("RAMV", "NANN"));
      Assert.AreEqual("X", _game.GetResultGame("RAMV", "NNMN"));
      Assert.AreEqual("X", _game.GetResultGame("RAMV", "NNNV"));
    }

    [Test]
    public void ReturnMoreXWhenTwoOrMoreCharsCodeAndPasswordAreTheSame()
    {
      Assert.AreEqual("XX", _game.GetResultGame("RAMV", "RANN"));
      Assert.AreEqual("XXX", _game.GetResultGame("RAMV", "RAMN"));
      Assert.AreEqual("XXXX", _game.GetResultGame("RAMV", "RAMV"));
    }

    [Test]
    public void ReturnAsteriskWhenFindAColor()
    {
      Assert.AreEqual("*", _game.GetResultGame("RANI", "MVRM"));
    }

    [Test]
    public void ReturnMoreAsteriskWhenFindTwoOrMoreColor()
    {
      Assert.AreEqual("**", _game.GetResultGame("RANI", "INMM"));
      Assert.AreEqual("***", _game.GetResultGame("RANI", "INRM"));
      Assert.AreEqual("****", _game.GetResultGame("RANI", "INRA"));
    }

    [Test]
    public void ReturnXAndAsteriskWhenFindPositionAndColor()
    {
      Assert.AreEqual("X*", _game.GetResultGame("RANI", "YNYI"));
      Assert.AreEqual("X**", _game.GetResultGame("NRRI", "RRVN"));
      Assert.AreEqual("XX*", _game.GetResultGame("NRRI", "RRRN"));
    }
  }
}
