using System;


class Program
{
   static void Main( string[] args )
   {
      int? myI4 = null;
      Console.WriteLine( "myI4: {0}", myI4 ?? -1 );

      myI4 = 10;
      Console.WriteLine( "myI4: {0}", myI4 ?? -1 );

      int? i1 = null, i2 = null;                         // Both are null.
      if ( i1 == i2 )                                    // Operator returns true.
         Console.WriteLine( "Equal" );
   }
}

