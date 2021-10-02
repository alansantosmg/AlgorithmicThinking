using System;

namespace _3_Car_Distance
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Calculate car distance traveled");
      Console.WriteLine("----------------------");
      Console.WriteLine();


      try
      {
        // Enter data

        Console.Write("Enter Acceleration: ");
        double acceleration = double.Parse(Console.ReadLine());


        Console.Write("Enter time traveled: ");
        Double time = double.Parse(Console.ReadLine());

        // Calc distance
        double distance = 0.5 * (acceleration * Math.Pow(time, 2));

        // Show result
        Console.Write($"The distance traveled is: {distance}\n ");  
      }
      catch (Exception)
      {

        Console.WriteLine("\nJust enter only numbers!\n");
        
      }

      Console.ReadKey();








    }
  }
}
