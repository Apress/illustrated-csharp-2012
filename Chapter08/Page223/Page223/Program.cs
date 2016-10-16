using System;

class Program
{
   static void Main( string[] args )
   {
      int a, b, x = 14;

      a = x << 3;                // Shift left
      b = x >> 3;                // Shift right

      Console.WriteLine( "{0} << 3 = {1}", x, a );
      Console.WriteLine( "{0} >> 3 = {1}", x, b );
   }
}

