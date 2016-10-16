using System;

class Program
{
   delegate void MyDel( int x );

   static void Main()
   {
      int x = 5;

      MyDel mDel = delegate
                   {
                      Console.WriteLine( "{0}", x );
                   };
   }
}

