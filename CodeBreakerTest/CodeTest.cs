using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBreaker;
using NUnit.Framework;

namespace CodeBreakerTest
{
  [TestFixture]
  public class CodeTest
  {
    [Test]
    public void ReturnCodeLengthFour()
    {
      var code = new Code();
      Assert.AreEqual(4, code.GetCode().Length);
    }

    [Test]
    public void ReturnCodeWithAllowedChars()
    {
      var code = new Code();
      var result = code.GetCode();
      result.ToList().ForEach(x => Assert.Contains(x.ToString(), Code.AllowedChars));
    }
  }
}
