using System;

class MyClass
{
   public int Val = 20;
}

class Program
{
   static void RefAsParameter( MyClass f1 )
   {
      f1.Val = 50;
      Console.WriteLine( "After member assignment:    {0}", f1.Val );

      f1     = new MyClass();
      Console.WriteLine( "After new object creation:  {0}", f1.Val );
   }

   static void Main()
   {
      MyClass a1 = new MyClass();

      Console.WriteLine( "Before method call:         {0}", a1.Val );
      RefAsParameter( a1 );
      Console.WriteLine( "After method call:          {0}", a1.Val );
   }
}
