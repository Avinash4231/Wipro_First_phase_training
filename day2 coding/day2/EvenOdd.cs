using System;
 namespace temp
{
  public static class EvenOdd
  {
    public static void run()
    {
      int a = Convert.ToInt32(Console.ReadLine());
      if (a >= 2 && a <= 20)
      {
        if (a % 2 == 0)
        { 
          Console.WriteLine($"{a} is even");
        }
        else
        {
          Console.WriteLine($"{a} is odd");

        }
      }
      else
      {
        Console.WriteLine($"{a} is greater than 20 and less than 2");
      }
    }
  }
}
