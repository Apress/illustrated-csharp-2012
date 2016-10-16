using System;
using System.Linq;

class Program
{
   static void Main()
   {
      var students = new[] // Array of objects of an anonymous type
      {
         new { LName="Jones", FName="Mary", Age=19, Major="History" },
         new { LName="Smith", FName="Bob", Age=20, Major="CompSci" },
         new { LName="Fleming", FName="Carol", Age=21, Major="History" }
      };

      var query1 = from s in students
                  select s;

      foreach ( var q in query1 )
         Console.WriteLine( "{0}, {1}: Age {2}, {3}",
         q.LName, q.FName, q.Age, q.Major );

      Console.WriteLine();

      var query2 = from s in students
                  select s.LName;

      foreach ( var q in query2 )
         Console.WriteLine( q );
   }
}