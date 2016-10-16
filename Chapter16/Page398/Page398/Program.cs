using System;

class Program
   {
      // This code illustrates that running in the checked mode causes an exception.
      static void Main( string[] args )
      {
         ushort sh = 2000;
         byte sb;

         sb = unchecked( (byte) sh );           // Most significant bits lost
         Console.WriteLine( "sb: {0}", sb );

         sb = checked( (byte) sh );             // OverflowException raised
         Console.WriteLine( "sb: {0}", sb );
      }
   }

