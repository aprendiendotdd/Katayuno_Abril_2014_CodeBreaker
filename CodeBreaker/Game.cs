using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreaker
{
  public class Game
  {
    private static string POSITION = "X";
    private static string COLOR = "*";
    public string GetResultGame(string code, string password)
    {
      var resultPosition = string.Empty; 
      var resultColor = string.Empty;
      for (var i = 0; i < code.Length; i++)
        resultPosition = FindPositionOrColor(code, password, i, resultPosition, ref resultColor);
      
      return resultPosition + resultColor;
    }

    private static string FindPositionOrColor(string code, string password, int i, string resultPosition, ref string resultColor)
    {
      if (code[i] == password[i])
        resultPosition += POSITION;
      else if (password.Contains(code[i]))
        resultColor += COLOR;
      return resultPosition;
    }
  }
}
