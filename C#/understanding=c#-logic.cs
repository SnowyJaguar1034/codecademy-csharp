using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      BOOL TYPE: bool variableName
      COMPARISON OPERATORS: ==, <, >, <=, >=
      LOGICAL OPERATORS: &&, ||, !

      Good luck! */
      string password = "H3110 W0r1d!";
      bool uppercaseCheck = password.Contains('H');
      bool symbolCheck = password.Contains('!');
      bool passwordCheck = uppercaseCheck && symbolCheck;
      bool actor = true;
      bool drama = false;
      bool show = actor || drama;
      Console.WriteLine(passwordCheck);
      Console.WriteLine(show);
    }
  }
}
