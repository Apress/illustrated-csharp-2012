using System;

delegate void MyDel( int x );

class Program
{
   static void Main()
   {
      MyDel mDel = delegate( int y )
                   {
                      int z = 10;
                      Console.WriteLine( "{0}, {1}", y, z );
                   };

      //Console.WriteLine( "{0}, {1}", y, z );   // Compile error.
   }
}
