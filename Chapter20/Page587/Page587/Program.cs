using System;
using System.Threading.Tasks;          // Must use this namespace

namespace ExampleParallelFor
{
   class Program
   {
      static void Main()
      {
         const int maxValues = 50;
         int[] squares = new int[maxValues];

         Parallel.For( 0, maxValues, i => squares[i] = i * i );

         for ( int i=0; i < maxValues; i++ )
            Console.WriteLine( "Element {0}: {1}", i, squares[i] );
      }
   }
}