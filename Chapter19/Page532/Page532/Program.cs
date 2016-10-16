using System;
using System.Xml.Linq;

   class Program
   {
      static void Main()
      {
         XDocument xd = new XDocument(
            new XElement( "root",
                  new XAttribute( "color", "red" ), // Attribute constructor
                  new XAttribute( "size", "large" ), // Attribute constructor
               new XElement( "first" ),
               new XElement( "second" )
            )
         );

         Console.WriteLine( xd );
      }
   }

