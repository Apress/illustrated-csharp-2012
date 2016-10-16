using System;

class Program
{
   static void Main()
   {
      double myDouble = 12.345678;
      Console.WriteLine( "{0,-10:G} -- General", myDouble );
      Console.WriteLine( "{0,-10} -- Default, same as General", myDouble );
      Console.WriteLine( "{0,-10:F4} -- Fixed Point, 4 dec places", myDouble );
      Console.WriteLine( "{0,-10:C} -- Currency", myDouble );
      Console.WriteLine( "{0,-10:E3} -- Sci. Notation, 3 dec places", myDouble );
      Console.WriteLine( "{0,-10:x} -- Hexadecimal integer", 1194719 );
   }
}

