using System;

class Program
{
   public static int Add20( int x )
   {
      return x + 20;
   }

   delegate int OtherDel( int InParam );
   static void Main()
   {
      OtherDel del = Add20;

      Console.WriteLine( "{0}", del( 5 ) );
      Console.WriteLine( "{0}", del( 6 ) );
   }
}
