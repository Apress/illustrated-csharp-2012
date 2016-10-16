using System;
using System.Reflection;                                          // Must use this namespace

namespace SimpleReflection
{
   class BaseClass
   {
      public int MyFieldBase;
   }

   class DerivedClass : BaseClass
   {
      public int MyFieldDerived;
   }

   class Program
   {
      static void Main()
      {
         Type tbc = typeof( DerivedClass );                       // Get the type.
         Console.WriteLine( "Result is {0}.", tbc.Name );

         Console.WriteLine( "It has the following fields:" );     // Use the type.
         FieldInfo[] fi = tbc.GetFields();
         foreach ( var f in fi )
            Console.WriteLine( "   {0}", f.Name );
      }
   }
}