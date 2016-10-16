using System;

delegate double MyDel( int par );

class Program
{
   static void Main()
   {
      MyDel del = delegate( int x ) { return x + 1; }; // Anonymous method

      MyDel le1 = ( int x ) => { return x + 1; }; // Lambda expression
      MyDel le2 =     ( x ) => { return x + 1; };
      MyDel le3 =       x   => { return x + 1; };
      MyDel le4 =       x   =>          x + 1;

      Console.WriteLine( "{0}", del( 12 ) );
      Console.WriteLine( "{0}", le1( 12 ) );
      Console.WriteLine( "{0}", le2( 12 ) );
      Console.WriteLine( "{0}", le3( 12 ) );
      Console.WriteLine( "{0}", le4( 12 ) );
   }
}
