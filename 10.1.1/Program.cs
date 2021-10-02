using System;

namespace _10._1._1
{
  class Program
  {
    static void Main(string[] args)
    {
      // title
      Console.WriteLine("Math calc");
      Console.WriteLine("--------------------");
      Console.WriteLine("Retangle's area\n");
      Console.WriteLine();


      try
      {


   
        // input base and height

        Console.Write("Input the base value: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Input the height value: ");
        double h = double.Parse(Console.ReadLine());



        // calculate area 
        double area = b * h;


        // show results
        Console.WriteLine($"Retangle's area = {area}\n");
        Console.ReadKey();
      }
      catch (Exception)
      {
        Console.WriteLine("Please, input only numbers.");
        
      }




    }
  }
}
