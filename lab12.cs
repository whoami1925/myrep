using System;
class HelloWorld {
  static void Main() {
     int a = Convert.ToInt32(Console.ReadLine());
    int b = Math.Abs(a);
    Console.WriteLine(b);
    
    int c = Convert.ToInt32(Console.ReadLine());
    int d = Math.Max(a, c);
    Console.WriteLine(d);
    
    int e = Convert.ToInt32(Console.ReadLine());
    double f = Math.Sqrt(e);
    Console.WriteLine(f);
    
    double g = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Math.Truncate(g));
    
  }
}
