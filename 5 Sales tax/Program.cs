using System;

namespace _5_Sales_tax
{
  class Program
  {
    static void Main(string[] args)
    {

      // Title 
      Console.WriteLine("Calculate Sales Tax");
      Console.WriteLine("-------------------\n");

      try
      {
        // Input data

        const decimal VAT = 0.19M;

        Console.Write("Input original price: $ ");
        decimal originalPrice = decimal.Parse(Console.ReadLine());


        // Calculate 

        decimal salesTax = originalPrice * VAT;
        decimal salesPrice = salesTax + originalPrice;

        // Show result
        Console.WriteLine($"Taxes: {salesTax.ToString("c")}");
        Console.WriteLine($"Sales price: {salesPrice.ToString("c")}");

      }
      catch (Exception)   
      {
        Console.WriteLine("Input number to price.");
      }
        

      Console.ReadKey();
    }
  }
  
}
