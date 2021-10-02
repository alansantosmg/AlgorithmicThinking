using System;

namespace _2_Area_do_circulo
{
  class Program
  {
    static void Main(string[] args)
    {
      // title
      Console.WriteLine("Math calcs");
      Console.WriteLine("--------------------");
      Console.WriteLine("Circle's perimeter\n");
      Console.WriteLine();


      try
      {


        // input base and height
        Console.Write("Input circles perimeter: ");
        double r = double.Parse(Console.ReadLine());


        // calculate area 
        double area = Math.PI  * r;


        // show results
        Console.WriteLine($"Circle's area  = {area.ToString("N2")}\n");
       
      }
      catch (Exception)
      {
        Console.WriteLine("Please, input only numbers.");

      }

      Console.ReadKey();

    }
  }
}
