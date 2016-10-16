using System;

class MyClass
{
   class MyCounter // Nested class
   {
      public int Count { get; private set; }
      public static MyCounter operator ++( MyCounter current )
      {
         current.Count++;
         return current;
      }
   }

   private MyCounter counter;                                     // Field of nested class type

   public MyClass()                                               // Constructor
   {
      counter = new MyCounter();
   }

   public int Incr()                                              // Increment method.
   {
      return ( counter++ ).Count;
   }

   public int GetValue() { return counter.Count; }                // Get counter value.
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass(); // Create object.
      mc.Incr();
      mc.Incr();
      mc.Incr();                                                  // Increment it.
      mc.Incr();
      mc.Incr();
      mc.Incr();                                                  // Increment it.
      Console.WriteLine( "Total: {0}", mc.GetValue() );           // Print its value.
   }
}