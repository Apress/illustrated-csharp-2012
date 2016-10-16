using System;

public class Employee
{
   public string LastName;                         // Call this field 0.
   public string FirstName;                        // Call this field 1.
   public string CityOfBirth;                      // Call this field 2.

   public string this[int index]                   // Indexer declaration
   {
      set // Set accessor declaration
      {
         switch ( index )
         {
            case 0:
               LastName = value;
               break;
            case 1:
               FirstName = value;
               break;
            case 2:
               CityOfBirth = value;
               break;
            default:                               // (Exceptions in Ch. 11)
               throw new ArgumentOutOfRangeException( "index" );
         }
      }

      get // Get accessor declaration
      {
         switch ( index )
         {
            case 0:
               return LastName;
            case 1:
               return FirstName;
            case 2:
               return CityOfBirth;
            default:                               // (Exceptions in Ch. 11)
               throw new ArgumentOutOfRangeException( "index" );
         }
      }
   }
}

class Program
{
   static void Main()
   {
      Employee emp1 = new Employee();

      emp1[0] = "Doe";
      emp1[1] = "Jane";
      emp1[2] = "Dallas";

      Console.WriteLine( "{0}", emp1[0] );
      Console.WriteLine( "{0}", emp1[1] );
      Console.WriteLine( "{0}", emp1[2] );
   }
}
