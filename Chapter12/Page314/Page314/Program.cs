using System;

class Program
{
   static void Main()
   {
      int total = 0;
      int[,] arr1 = { { 10, 11 }, { 12, 13 } };

      foreach ( var element in arr1 )
      {
         total += element;
         Console.WriteLine( "Element: {0}, Current Total: {1}", element, total );
      }
   }
}
