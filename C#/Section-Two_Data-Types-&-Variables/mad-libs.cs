using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      
      // Description & Author of the program:
      string description = "This program creates a unique Mad Libs story from the users inputs.";
      string author = "Teagan Collyer";

      // Let the user know that the program is starting:
      Console.WriteLine($"{author}'s Mad Libs generator is starting! {description}");

      // Give the Mad Lib a title:
      Console.WriteLine("Give the Mad Lib a title: ");
      string title = Console.ReadLine();
      Console.WriteLine($"You gave the Mad Lib a title of: {title}");

      // Define user input and variables:
      // Charcter Name
      Console.WriteLine("Name your main character: ");
      string name = Console.ReadLine();
      
      // Seperator Line, Helps make the terminal feel less cramped
      Console.WriteLine("\n");

      // Three Adjectives
      // Seperator Line, Helps make the terminal feel less cramped
      Console.WriteLine("\n");
      Console.WriteLine(@"Now it's time to enter your three adjectives.        
      An adjective is a word that describes a noun, like a color (‘blue’), or feeling (‘silly’), texture (‘soft’).");
      Console.Write("First adjective: ");
      string adj1 = Console.ReadLine();

      Console.Write("Second adjective: ");
      string adj2 = Console.ReadLine();

      Console.Write("Third adjective: ");
      string adj3 = Console.ReadLine();
      
      // One Verb
      // Seperator Line, Helps make the terminal feel less cramped
      Console.WriteLine("\n");

      Console.WriteLine(@"Now it's time to enter your verb.
      A verb is a word that represents an action, like ‘sit’, ‘eat’, ‘sleep’.");
      Console.WriteLine("Verb: ");
      string verb = Console.ReadLine();
      
      // Two Nouns
      // Seperator Line, Helps make the terminal feel less cramped
      Console.WriteLine("\n");

      Console.WriteLine(@"Now it's time to enter your two nouns.
      A noun is a person (‘girl’), place (‘cabin’), or thing (‘toaster’).");
      Console.WriteLine("First noun: ");
      string noun1 = Console.ReadLine();

      Console.WriteLine("Second noun: ");
      string noun2 = Console.ReadLine();
      
      // Seperator Line, Helps make the terminal feel less cramped
      Console.WriteLine("\n");
      
      // Random Input
      Console.WriteLine("Now it's time for more general random inputs.");
      Console.WriteLine("A type of animal: ");
      string animal = Console.ReadLine();
      Console.WriteLine("A type of main course: ");
      string food = Console.ReadLine();
      Console.WriteLine("A type of fruit: ");
      string fruit = Console.ReadLine();
      Console.WriteLine("A superhero: ");
      string superhero = Console.ReadLine();
      Console.WriteLine("A country name: ");
      string country = Console.ReadLine();
      Console.WriteLine("A type of dessert: ");
      string dessert = Console.ReadLine();
      Console.WriteLine("A year: ");
      string year = Console.ReadLine();

      // The template for the story:
      //string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

      // Print the story:
      Console.WriteLine($"{title}\n\n\n{story}");
      // This morning Crystal woke up feeling white. 'It is going to be a free day!' Outside, a bunch of dragons were protesting to keep pasta in stores. They began to fuck to the rhythm of the freighter, which made all the apples very unsettled. Concerned, Crystal texted vlandimir, who flew Crystal to sweden and dropped Crystal in a puddle of frozen victoria spunge cake. Crystal woke up in the year 1048, in a world where girls ruled the world.
    }
  }
}
