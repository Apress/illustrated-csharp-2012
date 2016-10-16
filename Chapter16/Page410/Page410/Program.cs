using System;

class Program
{
   static void Main()
   {
      int i = 10; // Create and initialize value type

      object oi = i; // Create and initialize reference type
      Console.WriteLine( "i: {0}, io: {1}", i, oi );

      i = 12;
      oi = 15;
      Console.WriteLine( "i: {0}, io: {1}", i, oi );
   }
}

