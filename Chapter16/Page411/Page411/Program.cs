using System;

namespace Page411
{
   class Program
   {
      static void Main()
      {
         int i = 10;

         object oi = i;

         int j = (int) oi;
         Console.WriteLine( "i: {0}, oi: {1}, j: {2}", i, oi, j );
      }
   }
}
