using System;

class LimitedInt
{
   const int MaxValue = 100;
   const int MinValue = 0;

   public static explicit operator int( LimitedInt li )
   {
      return li.TheValue;
   }

   public static explicit operator LimitedInt( int x )
   {
      LimitedInt li = new LimitedInt();
      li.TheValue   = x;

      return li;
   }

   private int _theValue = 0;
   public int TheValue // Property
   {
      get { return _theValue; }
      set
      {
         if ( value < MinValue )
            _theValue = 0;
         else
            _theValue = value > MaxValue
                              ? MaxValue
                              : value;
      }
   }
}

class Program
{
   static void Main()
   {
      LimitedInt li = (LimitedInt) 500;
      int value = (int) li;

      Console.WriteLine( "li: {0}, value: {1}", li.TheValue, value );
   }
}
