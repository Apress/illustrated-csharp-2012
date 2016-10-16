class CSimple
{
   public int X;
   public int Y;
}

struct Simple
{
   public int X;
   public int Y;
}

class Program
{
   static void Main()
   {
      CSimple cs1 = new CSimple(), cs2 = null;           // Class instances
      Simple ss1  = new Simple(),  ss2 = new Simple();   // Struct instances

      cs1.X = ss1.X = 5;                                 // Assign 5 to ss1.X and cs1.X.
      cs1.Y = ss1.Y = 10;                                // Assign 10 to ss1.Y and cs1.Y.

      cs2 = cs1;                                         // Assign class instance.
      ss2 = ss1;                                         // Assign struct instance.
   }
}
