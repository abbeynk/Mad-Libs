using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program writes a Mad Libs word game!
      Author: Abbey Nandakumar
      */


      // Let the user know that the program is starting:
Console.WriteLine("Mad Libs is starting!");

      // Give the Mad Lib a title:
      string title = "TITLE";

      Console.WriteLine(title);
      // Define user input and variables:
Console.Write("Enter a name: ");
string name = Console.ReadLine();
Console.Write("Enter a word: ");
string word = Console.ReadLine();
 
Console.Write("Enter a first adjective: ");
string adj1 = Console.ReadLine();

Console.Write("Enter a second adjective: ");
string adj2 = Console.ReadLine();

Console.Write("Enter a third adjective: ");
string adj3 = Console.ReadLine();

Console.Write("Enter a first verb: ");
string verb1 = Console.ReadLine();

Console.Write("Enter a second verb: ");
string verb2 = Console.ReadLine();

Console.Write("Enter a third verb: ");
string verb3 = Console.ReadLine();

Console.Write("Enter a first noun: ");
string noun1 = Console.ReadLine();

Console.Write("Enter a second noun: ");
string noun2 = Console.ReadLine();

Console.Write("Enter an animal: ");
string anim1 = Console.ReadLine();

Console.Write("Enter a food: ");
string food1 = Console.ReadLine();

Console.Write("Enter a fruit: ");
string fruit1 = Console.ReadLine();

Console.Write("Enter A superhero : ");
string super1 = Console.ReadLine();

Console.Write("Enter A country : ");
string countr1 = Console.ReadLine();

Console.Write("Enter A dessert : ");
string dess1 = Console.ReadLine();

Console.Write("Enter A year : ");
string year1 = Console.ReadLine();
      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {anim1}s were protesting to keep {food1}in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit1}s very {adj3}. Concerned, {name} texted {super1}, who flew {name} to {countr1} and dropped _{name}in a puddle of frozen {dess1}. {name} woke up in the year {year1}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine("story");

    }
  }
}
