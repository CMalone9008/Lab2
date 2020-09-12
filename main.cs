using System;

class MainClass {
  public static void Main (string[] args) {
    double cel, fah;
    Console.WriteLine("Enter temperature in Celsius:");
    cel = double.Parse(Console.ReadLine());
    fah = (cel * 9) / 5 + 32;
    Console.WriteLine("Fahrenheit equivalent for " + cel + " degree celsius is " + fah);

    if (fah <= 32)
    { 
      Console.WriteLine("This temperature is below freezing temperature of 32 degrees fahrenheit");
     }
    else if (fah >= 212)
    {
      Console.WriteLine("The temperature is above boiling temperature of 212 degrees fahrenheit");
     }
    
   
   
   



   

    
    
  
  }
}