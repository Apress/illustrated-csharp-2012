using System;
using System.Linq;

class Program
{
   static void Main()
   {
      var groupA = new[] { 3, 4, 5, 6 };
      var groupB = new[] { 4, 5, 6, 7 };

      var someInts = from a in groupA
                     join b in groupB on a equals b
                     into groupAandB
                     from c in groupAandB
                     select c;

      foreach ( var a in someInts )
         Console.Write( "{0} ", a );
   }
}

