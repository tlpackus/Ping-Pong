using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Type in Number: ");
    int userInput = int.Parse(Console.ReadLine());
    for (int index = 1; index <= userInput; index++)
    {
      if ((index % 5 == 0) && (index % 3 == 0)) {
        Console.WriteLine("ping-pong");
    }
    else if (index % 5 == 0) {
      Console.WriteLine("pong");
    }
    else if (index % 3 == 0) {
      Console.WriteLine("ping");
    }
    else {
      Console.WriteLine(index);
    }
    }
  }
}