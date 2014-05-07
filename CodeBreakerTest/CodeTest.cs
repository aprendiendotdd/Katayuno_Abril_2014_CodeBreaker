using System.Linq;
using CodeBreaker;
using NUnit.Framework;

namespace CodeBreakerTest
{
  [TestFixture]
  public class CodeTest
  {
    private Code code;

    [SetUp]
    public void SetUp()
    {
      code = new Code();
    }

    [Test]
    public void ReturnCodeLengthFour()
    {
      Assert.AreEqual(4, code.GetCode().Length);
    }

    [Test]
    public void ReturnCodeWithAllowedChars()
    {
      code.GetCode().ToList().ForEach(x => Assert.Contains(x.ToString(), Code.AllowedChars));
    }

    [Test]
    public void FirstCodeMustBeDistinctToSecondCode()
    {
      Assert.That(code.GetCode(), Is.Not.EqualTo(code.GetCode()));
    }
  }
}
