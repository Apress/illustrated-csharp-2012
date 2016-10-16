using System;

class Trivial
{
   public static int MyValue { get; set; }
   public void PrintValue()
   {
      Console.WriteLine( "Value from inside: {0}", MyValue );
   }
}
class Program
{
   static void Main()
   {
      Console.WriteLine( "Init Value: {0}", Trivial.MyValue );

      Trivial.MyValue = 10;
      Console.WriteLine( "New Value : {0}", Trivial.MyValue );

      Trivial tr = new Trivial();
      tr.PrintValue();
   }
}
