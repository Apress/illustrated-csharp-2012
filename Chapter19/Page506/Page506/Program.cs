using System;
using System.Linq;


class Program
{
   static void Main()
   {
      var students = new[]                                     // Array of objects of an anonymous type
      {
         new { LName="Jones", FName="Mary", Age=19, Major="History" },
         new { LName="Smith", FName="Bob", Age=20, Major="CompSci" },
         new { LName="Fleming", FName="Carol", Age=21, Major="History" }
      };

      var query = from student in students
                  group student by student.Major;

      foreach ( var s in query )                               // Enumerate the groups.
      {
         Console.WriteLine( "{0}", s.Key );

         foreach ( var t in s )                                // Enumerate the items in the group.
            Console.WriteLine( "      {0}, {1}", t.LName, t.FName );
      }
   }
}

