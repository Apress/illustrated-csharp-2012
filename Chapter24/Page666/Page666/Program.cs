using System;
using System.Reflection;                                    // Must use this namespace

class BaseClass
{
   public int BaseField = 0;
}

class DerivedClass : BaseClass
{
   public int DerivedField = 0;
}

class Program
{
   static void Main()
   {
      var bc = new BaseClass();
      var dc = new DerivedClass();

      BaseClass[] bca = new BaseClass[] { bc, dc };

      foreach ( var v in bca )
      {
         Type t = v.GetType();                              // Get the type.

         Console.WriteLine( "Object type : {0}", t.Name );

         FieldInfo[] fi = t.GetFields();                    // Get the field information.
         foreach ( var f in fi )
            Console.WriteLine( "      Field : {0}", f.Name );
         Console.WriteLine();
      }
   }
}