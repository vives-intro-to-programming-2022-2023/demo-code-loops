using System;

namespace HelloWorld
{
  class Program
  {

    static void Main(string[] args)
    {
      // SUM of numbers [10 ... 50]
      int sum = 0;
      for(int i = 10; i <= 50; i++) {
        sum = sum + i;      // of sum += i;
      }
      Console.WriteLine($"Sum = {sum}");

      // Drawing a rectangle
      for (int y = 5; y > 0; y--) {

        // 1 horizontal line
        for(int x = y; x > 0; x--) {
          Console.Write("@");
        }
        Console.WriteLine("");

      }

      // DO - WHILE
      int number = 0;
      do {
        Console.Write("Please enter number between 10 and 20: ");
        number = Convert.ToInt32(Console.ReadLine());
      } while(number < 10 || number > 20);

      Console.WriteLine($"Thanks for the number {number}");


      // LOG2(b)
      int bOriginal = 8;
      int b = bOriginal;
      int exponent = 0;

      while(b > 1) {
        b = b / 2;    // of x /= 2
        exponent++;   // exponent = exponent + 1
      }

      Console.WriteLine($"2^{exponent} = {bOriginal}");
 



    }
  }
}