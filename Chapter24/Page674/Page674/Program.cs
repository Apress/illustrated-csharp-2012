using System;
using System.Runtime.CompilerServices;

public static class Program
{
   public static void MyTrace( string message,
                              [CallerFilePath] string fileName = "",
                              [CallerLineNumber] int lineNumber = 0,
                              [CallerMemberName] string callingMember = "" )
   {
      Console.WriteLine( "File: {0}", fileName );
      Console.WriteLine( "Line: {0}", lineNumber );
      Console.WriteLine( "Called From: {0}", callingMember );
      Console.WriteLine( "Message: {0}", message );
   }

   public static void Main()
   {
      MyTrace( "Simple message" );
   }
}