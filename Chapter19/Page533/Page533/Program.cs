using System;
using System.Xml.Linq;


class Program
{
   static void Main()
   {
      XDocument xd = new XDocument(                            // Create XML tree.
         new XElement( "root",
               new XAttribute( "color", "red" ),
               new XAttribute( "size", "large" ),
            new XElement( "first" )
         )
      );

      Console.WriteLine( xd );                                 // Display XML tree.
      Console.WriteLine();

      XElement rt = xd.Element( "root" );                      // Get the element.

      XAttribute color = rt.Attribute( "color" );              // Get the attribute.
      XAttribute size = rt.Attribute( "size" );                // Get the attribute.

      Console.WriteLine( "color is {0}", color.Value );        // Display attr. value.
      Console.WriteLine( "size  is {0}", size.Value );         // Display attr. value.
   }
}

