using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Give me a number");
     int Num1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Give me a second number");
     int Num2 = Convert.ToInt32(Console.ReadLine());
     double Sum = Num1 + Num2;
     double Diff = Num2 - Num1;
     double Product = Num2 * Num1;
     double Quotient = Num1/Num2;
     double Remainder = Num1%Num2;
     Console.WriteLine(Sum);
     Console.WriteLine(Diff);
     Console.WriteLine(Product);
     Console.WriteLine(Quotient);
     Console.WriteLine(Remainder);

  }
}