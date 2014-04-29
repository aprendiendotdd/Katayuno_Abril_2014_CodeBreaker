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
      if (code[0] == password[0])
        return "X";
      return "";
    }
  }
}
