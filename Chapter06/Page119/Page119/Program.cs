using System;

class D
{
   int Mem1;
   static public int Mem2;
}

class Program
{
   static void Main()
   {
      D.Mem2 = 5;
      Console.WriteLine( "Mem2 = {0}", D.Mem2 );
   }
}
