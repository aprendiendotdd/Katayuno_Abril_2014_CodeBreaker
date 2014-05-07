using CodeBreaker;
using NUnit.Framework;

namespace CodeBreakerTest
{
  [TestFixture]
  public class GameTest
  {
    private Game game;

    [SetUp]
    public void SetUp()
    {
      game = new Game();
    }

    [Test]
    public void Return_Empty_String_When_Password_Chars_Not_Match_Code_Chars()
    {
      Assert.AreEqual("", game.GetResultGame("RRRR", "AAAA"));
    }

    [Test]
    public void Return_X_String_When_Password_One_Chars_Match_Code_One_Chars()
    {
        Assert.AreEqual("X", game.GetResultGame("RAMV", "RNNN"));
    }

    [Test]
    public void Return_X_String_When_Password_Second_Chars_Match_Code_Second_Chars()
    {
        Assert.AreEqual("X", game.GetResultGame("RAMV", "NANN"));
    }

    [Test]
    public void Return_X_String_When_Password_Some_Chars_Match_Code_Some_Chars()
    {
        Assert.AreEqual("X", game.GetResultGame("RAMV", "RNNN"));
        Assert.AreEqual("X", game.GetResultGame("RAMV", "NANN"));
        Assert.AreEqual("X", game.GetResultGame("RAMV", "NNMN"));
        Assert.AreEqual("X", game.GetResultGame("RAMV", "NNNV"));
        Assert.AreEqual("XX", game.GetResultGame("RANI", "RMVI"));
        Assert.AreEqual("XX", game.GetResultGame("RAMV", "RANN"));
        Assert.AreEqual("XXX", game.GetResultGame("RAMV", "RAMN"));
        Assert.AreEqual("XXXX", game.GetResultGame("RAMV", "RAMV"));
    }

    [Test]
    public void Return_Asterisk_When_Find_A_Color()
    {
        Assert.AreEqual("*", game.GetResultGame("RANI", "MVRM"));
        Assert.AreEqual("**", game.GetResultGame("RANI", "INMM"));
        Assert.AreEqual("***", game.GetResultGame("RANI", "INRM"));
        Assert.AreEqual("****", game.GetResultGame("RANI", "INRA"));
    }

    [Test]
    public void Return_X_And_Asterisk_When_Find_Position_And_Color()
    {
        Assert.AreEqual("X*", game.GetResultGame("RANI", "YNYI"));
        Assert.AreEqual("X**", game.GetResultGame("NRRI", "RRVN"));
        Assert.AreEqual("XX*", game.GetResultGame("NRRI", "RRRN"));
    }
  }
}
