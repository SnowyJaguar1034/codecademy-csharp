using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter a cents value you want to convert to coins:");
      double centsvalue = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine($"{centsvalue} cents is equal to...");
      int goldvalue = 10;
      int silvervalue = 5;
      int bronzevalue = 1;
      double goldcoins = Math.Floor(centsvalue/goldvalue);
      double reamains = 11 % goldvalue;
      double silvercoins = Math.Floor(reamains/silvervalue);
      reamains = reamains % silvervalue;
      Console.WriteLine($"Gold coins: {goldcoins}");
      Console.WriteLine($"Silver coins: {silvercoins}");
      Console.WriteLine($"Bronze coins: {reamains}");
    }
  }
}
