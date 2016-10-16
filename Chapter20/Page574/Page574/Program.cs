using System;
using System.Threading.Tasks;

static class DoStuff
{
   public static async Task<int> FindSeriesSum( int i1 )
   {
      int sum = 0;
      for ( int i=0; i < i1; i++ )
      {
         sum += i;
         if ( i % 1000 == 0 )
            await Task.Yield();
      }
      return sum;
   }
}

class Program
{
   static void Main()
   {
      Task<int> value = DoStuff.FindSeriesSum( 1000000 );
      CountBig( 100000 );
      CountBig( 100000 );
      CountBig( 100000 );
      CountBig( 100000 );
      Console.WriteLine( "Sum: {0}", value.Result );
   }

   private static void CountBig( int p )
   {
      for ( int i=0; i < p; i++ )
         ;
   }
}
