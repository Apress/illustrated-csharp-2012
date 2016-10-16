using System;

class Program
{
   static void Main()
   {
      // The body of this for loop is executed three times.
      for ( int i=0; i < 3; i++ )
         Console.WriteLine( "Inside loop. i: {0}", i );

      Console.WriteLine( "Out of Loop" );
   }
}

