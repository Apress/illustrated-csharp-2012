using System;

class MyClass
{
   public int GetHour()
   {
      DateTime dt = DateTime.Now;      // Get the current date and time.
      int hour    = dt.Hour;              // Get the hour.

      return hour;                     // Return an int.
   }
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass();
      Console.WriteLine( "Hour: {0}", mc.GetHour() );
   }
}
