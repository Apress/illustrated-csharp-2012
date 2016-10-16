using System;
using System.Threading.Tasks;

class Program
{
   static void Main( string[] args )
   {
      Task t = BadAsync();
      t.Wait();
      Console.WriteLine( "Task Status   : {0}", t.Status );
      Console.WriteLine( "Task IsFaulted: {0}", t.IsFaulted );
   }

   static async Task BadAsync()
   {
      try
      {
         await Task.Run( () => { throw new Exception(); } );
      }
      catch
      {
         Console.WriteLine( "Exception in BadAsync" );
      }
   }
}
