using System;

class Program
{
   static void Main()
   {
      int x = 0;
      do
         Console.WriteLine( "x is {0}", x++ );
      while ( x < 3 );
   }
}

