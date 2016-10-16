using System;

class Incrementer
{
   public event EventHandler CountedADozen;

   public void DoCount()
   {
      for ( int i=1; i < 100; i++ )
         if ( i % 12 == 0 && CountedADozen != null )
            CountedADozen( this, null );
   }
}

class Dozens
{
   public int DozensCount { get; private set; }

   public Dozens( Incrementer incrementer )
   {
      DozensCount = 0;
      incrementer.CountedADozen += IncrementDozensCount;
   }

   void IncrementDozensCount( object source, EventArgs e )
   {
      DozensCount++;
   }
}

class Program
{
   static void Main()
   {
      Incrementer incrementer = new Incrementer();
      Dozens dozensCounter    = new Dozens( incrementer );

      incrementer.DoCount();
      Console.WriteLine( "Number of dozens = {0}",
                              dozensCounter.DozensCount );
   }
}
