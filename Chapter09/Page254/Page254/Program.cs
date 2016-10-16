using System;

class Program
{
   static void Main( string[] args )
   {
      for ( int x=1; x < 6; x++ )
      {
         switch ( x )                                 // Evaluate the value of variable x.
         {
            case 2:                                   // If x equals 2
               Console.WriteLine( "x is {0} -- In Case 2", x );
               break;                                 // Go to end of switch.

            case 5:                                   // If x equals 5
               Console.WriteLine( "x is {0} -- In Case 5", x );
               break;                                 // Go to end of switch.

            default:                                  // If x is neither 2 nor 5
               Console.WriteLine( "x is {0} -- In Default case", x );
               break;                                 // Go to end of switch.
         }
      }
   }
}

