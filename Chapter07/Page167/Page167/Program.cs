using System;

class MyBaseClass
{
   public void Print()
   {
      Console.WriteLine( "This is the base class." );
   }
}

class MyDerivedClass : MyBaseClass
{
   new public void Print()
   {
      Console.WriteLine( "This is the derived class." );
   }
}

class Program
{
   static void Main()
   {
      MyDerivedClass derived = new MyDerivedClass();
      MyBaseClass mybc = (MyBaseClass) derived;

      derived.Print();                    // Call Print from derived portion.
      mybc.Print();                       // Call Print from base portion.
   }
}
