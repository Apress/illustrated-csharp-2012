using System;

class MyBaseClass
{
   virtual public void Print()
   {
      Console.WriteLine( "This is the base class." );
   }
}

class MyDerivedClass : MyBaseClass
{
   override public void Print()
   {
      Console.WriteLine( "This is the derived class." );
   }
}

class SecondDerived : MyDerivedClass
{
   new public void Print()
   {
      Console.WriteLine( "This is the second derived class." );
   }
}

class Program
{
   static void Main() // Main
   {
      SecondDerived derived = new SecondDerived(); // Use SecondDerived.
      MyBaseClass mybc = (MyBaseClass) derived; // Use MyBaseClass.
      derived.Print();
      mybc.Print();
   }
}
