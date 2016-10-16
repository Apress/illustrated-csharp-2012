using System;
using System.Linq;

namespace Page492
{
   class Program
   {
      static void Main( string[] args )
      {
         int[] arr1 = { 10, 11, 12, 13 };

         var query = from item in arr1
                     where item < 13
                     select item;

         foreach ( var item in query )
            Console.Write( "{0}, ", item );
      }
   }
}
