using System;

namespace Page251
{
   class Program
   {
      static void Main()
      {
         const int MaxI = 5;

         for ( int i = 0, j = 10; i < MaxI; i++, j += 10 )
         {
            Console.WriteLine( "{0}, {1}", i, j );
         }
      }
   }
}
