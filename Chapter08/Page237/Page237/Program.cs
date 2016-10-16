using System;

class SomeClass
{
}

class Program
{
   static void Main()
   {
      SomeClass s = new SomeClass();
      Console.WriteLine( "Type s: {0}", s.GetType().Name );
   }
}
