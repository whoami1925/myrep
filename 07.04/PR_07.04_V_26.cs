using System;
class HelloWorld {
  static void Main() {
    int b = Convert.ToInt32(Console.ReadLine());
    double a = Math.Exp(b);
    if (Math.Log(a) == 1) {
        Console.WriteLine("yes");
    }
    else {
        Console.WriteLine("no");
    }
  }
}
