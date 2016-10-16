using System;

class Class1
{
   int Id;
   string Name;

   public Class1()                  // Constructor 0
   {
      Id = 28; Name = "Nemo";
   }

   public Class1( int val )         // Constructor 1
   {
      Id = val; Name = "Nemo";
   }

   public Class1( String name )     // Constructor 2
   {
      Name = name;
   }

   public void SoundOff()
   {
      Console.WriteLine( "Name {0}, Id {1}", Name, Id );
   }
}

class Program
{
   static void Main()
   {
      Class1 a = new Class1(),            // Call constructor 0.
             b = new Class1( 7 ),         // Call constructor 1.
             c = new Class1( "Bill" );    // Call constructor 2.

      a.SoundOff();
      b.SoundOff();
      c.SoundOff();
   }
}
