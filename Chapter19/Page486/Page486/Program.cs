using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
   static void Main()
   {
      var student = new { Name = "Mary Jones", Age = 19, Major = "History" };

      Console.WriteLine( "{0}, Age {1}, Major: {2}", student.Name, student.Age, student.Major );
   }
}

