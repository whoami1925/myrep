using System;
class HelloWorld {
  static void Main() {
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());
    int d = Convert.ToInt32(Console.ReadLine());
    int e = Convert.ToInt32(Console.ReadLine());
    
    b = Math.Max(a, b);
    c = Math.Max(b, c);
    d = Math.Max(c, d);
    e = Math.Max(d, e);
    
    Console.WriteLine(e);
 
  }
}