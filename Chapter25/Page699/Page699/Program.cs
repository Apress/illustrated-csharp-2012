using System;

namespace Page699
{
   class Program
   {
      static void Main()
      {
         int? myI1, myI2, myI3;

         myI1 = 28;                    // Value of underlying type
         myI2 = myI1;                  // Value of nullable type
         myI3 = null;                  // null

         Console.WriteLine( "myI1: {0}, myI2: {1}", myI1, myI2 );
      }
   }
}
