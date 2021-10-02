using System;

namespace _6_Sales_price
{
  class Program
  {
    static void Main(string[] args)
    {

      // App Title
      Console.WriteLine("Sales Price Calculator");
      Console.WriteLine("----------------------\n");

      // Initialize Constants 
      const decimal VAT = 0.19M;

      // Initialize variables

      decimal originalPrice;
      decimal salesDiscount;
      decimal salesPrice;
      decimal salesVat;
      decimal discountPercentual;
    
      // Input data
      Console.Write("Input original price: ");

      if(!decimal.TryParse(Console.ReadLine(), out originalPrice))
      {
        Console.WriteLine("ERROR: invalid discount number!");
      }
      else
      {
        
        Console.Write("Input discount: ");

        if (!decimal.TryParse(Console.ReadLine(), out discountPercentual))
        {
          Console.WriteLine("ERROR: Invalid original price number!");
        }
        else
        {

          // Calculations

          discountPercentual = discountPercentual / 100;

          salesDiscount = originalPrice * discountPercentual;

          salesVat = (originalPrice - salesDiscount) * VAT;

          salesPrice = originalPrice - salesDiscount + VAT;


          // Show results

          Console.WriteLine($"\nOriginal price: {originalPrice.ToString("c")}\n" +
                            $"Discount Percentual: {discountPercentual.ToString("p")}\n" +
                            $"Sales Discount: {salesDiscount.ToString("c")}\n" +
                            $"Sales tax (VAT):{salesVat.ToString("c")}\n" +
                            $"Sales Price: {salesPrice.ToString("c")}");
        }
      }
      Console.ReadKey();

  
    }
  }
}
