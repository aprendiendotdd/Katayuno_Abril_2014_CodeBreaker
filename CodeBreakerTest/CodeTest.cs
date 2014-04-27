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
    public void ReturnStringLengthFour()
    {
      int expected = 4;
      CodeBreaker.Code code = new Code();
      int result = code.GetCode().Length;
      Assert.AreEqual(expected, result);
    }
  }
}
