using System;

class Program
{
   static void Main( string[] args )
   {
      int x = 3;
      while ( x > 0 )
      {
         Console.WriteLine( "x: {0}", x );
         x--;
      }
      Console.WriteLine( "Out of loop" );
   }
}

