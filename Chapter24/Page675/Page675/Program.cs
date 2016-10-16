using System;
using System.Diagnostics;                                // Required for this DebuggerStepThrough

class Program
{
   int _x = 1;
   int X
   {
      get { return _x; }
      [DebuggerStepThrough]                              // Don’t step through the set accessor.
      set
      {
         _x = _x * 2;
         _x += value;
      }
   }

   public int Y { get; set; }

   public static void Main()
   {
      Program p = new Program();
      p.IncrementFields();
      p.X = 5;
      Console.WriteLine( "X = {0}, Y = {1}", p.X, p.Y );
   }

   [DebuggerStepThrough]                                 // Don’t step through this method.
   void IncrementFields()
   {
      X++;
      Y++;
   }
}