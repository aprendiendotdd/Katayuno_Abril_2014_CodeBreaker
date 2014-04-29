using System.Linq;
using CodeBreaker;
using NUnit.Framework;

namespace CodeBreakerTest
{
  [TestFixture]
  public class CodeTest
  {
    private Code _code;

    [SetUp]
    public void SetUp()
    {
      _code = new Code();
    }

    [Test]
    public void ReturnCodeLengthFour()
    {
      Assert.AreEqual(4, _code.GetCode().Length);
    }

    [Test]
    public void ReturnCodeWithAllowedChars()
    {
      _code.GetCode().ToList().ForEach(x => Assert.Contains(x.ToString(), Code.AllowedChars));
    }

    [Test]
    public void FirstCodeMustBeDistinctToSecondCode()
    {
      Assert.That(_code.GetCode(), Is.Not.EqualTo(_code.GetCode()));
    }
  }
}
