using System;
using System.Collections;

class Program
{
   static void Main()
   {
      int[] MyArray = { 10, 11, 12, 13 }; // Create an array.

      IEnumerator ie = MyArray.GetEnumerator();

      while ( ie.MoveNext() )
      {
         int i = (int) ie.Current;
         Console.WriteLine( "{0}", i ); // Write it out.
      }
   }
}
