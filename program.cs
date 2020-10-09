/*
First, use .IndexOf() and bracket notation to grab 
the first letter of the first name and save it to 
the variable firstLetter.using System;
*/
namespace NameGrab
{
  class Program
  {
    static void Main(string[] args)
    {
      // User Name
      string name = "Farhad Hesam Abbasi";

      // Get first letter
      int charPosition = name.IndexOf("F");
      char firstLetter = name[charPosition];
/*
Next, use the .IndexOf() and .Substring() methods to 
get the entire last name. Save this value to a variable 
called lastName. Run the code and see your results printed
 to the console.
 */
      // Get last name
      charPosition = name.IndexOf("Abbasi");
      string lastName = name.Substring(charPosition);

      // Print results
      Console.WriteLine($"{firstLetter}. {lastName}");

    }
  }
}
