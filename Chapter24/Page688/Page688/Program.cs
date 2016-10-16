using System;

[AttributeUsage( AttributeTargets.Class )]
public sealed class MyAttributeAttribute : System.Attribute
{
   public string Description     { get; set; }
   public string VersionNumber   { get; set; }
   public string ReviewerID      { get; set; }

   public MyAttributeAttribute( string desc, string ver )
   {
      Description = desc;
      VersionNumber = ver;
   }
}

[MyAttribute( "Check it out", "2.4" )]
class MyClass
{
}

class Program
{
   static void Main()
   {
      Type t = typeof( MyClass );
      object[] AttArr = t.GetCustomAttributes( false );
      foreach ( Attribute a in AttArr )
      {
         MyAttributeAttribute attr = a as MyAttributeAttribute;
         if ( null != attr )
         {
            Console.WriteLine( "Description    : {0}", attr.Description );
            Console.WriteLine( "Version Number : {0}", attr.VersionNumber );
            Console.WriteLine( "Reviewer ID    : {0}", attr.ReviewerID );
         }
      }
   }
}