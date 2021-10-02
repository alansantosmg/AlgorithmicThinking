using System;

namespace _5_Farenheit_to_Kelvim_temp
{
  class Program
  {
    static void Main(string[] args)
    {

      // App Title
      
      Console.WriteLine("Farenheit to Kelvin");
      Console.WriteLine("-------------------");
      Console.WriteLine();

      try
      {
        // Declare constants

        const double FH_ADD = 459.67;
        const double FH_DIVIDE = 1.8;

        // Enter data
        Console.Write("Enter Fahrenheit temperature: ");
        double FarhrenheitTemp = double.Parse(Console.ReadLine());


        // Calculate kelvin temperature
        double kelvinTemp = (FarhrenheitTemp + FH_ADD) / FH_DIVIDE;


        // Show result
        Console.WriteLine($"Kelvin temperature = {kelvinTemp}\n");

      }
      catch (Exception)
      {
        Console.WriteLine("Enter only a number!") ;
      }

      Console.ReadKey();
    }
  }
}
