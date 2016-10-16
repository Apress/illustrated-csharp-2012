using System;

class Program
{
   static void Main()
   {
      First();
      Console.WriteLine();
      Second();
   }

   private static void Second()
   {
      int x = 0;
      while ( x < 5 )
      {
         if ( x < 3 )
         {
            x++;
            continue; // Go back to top of loop
         }
         // This line is reached only when x is 3 or greater.
         Console.WriteLine( "Value of x is {0}", x );
         x++;
      }
   }

   private static void First()
   {
      for ( int x=0; x < 5; x++ ) // Execute loop five times
      {
         if ( x < 3 ) // The first three times
            continue; // Go directly back to top of loop
         // This line is only reached when x is 3 or greater.
         Console.WriteLine( "Value of x is {0}", x );
      }
   }
}
