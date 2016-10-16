using System;

class MyClass
{
   void TimeUpdate()
   {
      DateTime dt = DateTime.Now;               // Get the current date and time.
      if ( dt.Hour < 12 )                       // If the hour is less than 12,
         return;                                // then return.

      Console.WriteLine( "It's afternoon!" );   // Otherwise, print message.
   }

   static void Main()
   {
      MyClass mc = new MyClass();               // Create an instance of the class.
      mc.TimeUpdate();                          // Invoke the method.
   }
}
