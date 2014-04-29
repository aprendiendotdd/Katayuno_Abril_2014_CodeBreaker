using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreaker
{
  public class Game
  {
    public string GetResultGame(string code, string password)
    {
      var result = string.Empty;
      for (int i = 0; i < code.Length; i++)
      {
        if (code[i] == password[i])
          result += "X";
      }

      return result;
    }
  }
}
