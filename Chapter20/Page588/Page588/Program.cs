using System;
using System.Threading.Tasks;

namespace ParallelForeach1
{
   class Program
   {
      static void Main()
      {
         string[] squares = new string[]
                  { "We", "hold", "these", "truths", "to", "be", "self-evident",
                    "that", "all", "men", "are", "created", "equal"};

         Parallel.ForEach( squares,
         i => Console.WriteLine( string.Format( "{0} has {1} letters", i, i.Length ) ) );
      }
   }
}