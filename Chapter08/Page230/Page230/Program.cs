﻿using System;

class LimitedInt
{
   const int MaxValue = 100;
   const int MinValue = 0;

   public static implicit operator int( LimitedInt li ) // Convert type
   {
      return li.TheValue;
   }

   public static implicit operator LimitedInt( int x ) // Convert type
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
   static void Main()               // Main
   {
      LimitedInt li    = 500;       // Convert 500 to LimitedInt
      int        value = li;        // Convert LimitedInt to int
      Console.WriteLine( "li: {0}, value: {1}", li.TheValue, 
         value );
   }
}
