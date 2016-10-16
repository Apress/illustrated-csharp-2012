using System;

class Program
{
   static void Main( )
   {
      int[] myIntArray;                            // Declare the array.

      myIntArray = new int[4];                     // Instantiate the array.

      for ( int i=0; i < 4; i++ )                  // Set the values.
         myIntArray[i] = i * 10;

      // Read and display the values of each element.
      for ( int i=0; i < 4; i++ )
         Console.WriteLine( "Value of element {0} = {1}", i, myIntArray[i] );
   }
}

