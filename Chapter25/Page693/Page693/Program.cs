using System;

class Program
{
   static void Main()
   {
      string s1 = "hi there! this, is: a string.";

      char[] delimiters = { ' ', '!', ',', ':', '.' };

      string[] words = s1.Split( delimiters, StringSplitOptions.RemoveEmptyEntries );

      Console.WriteLine( "Word Count: {0}\n\rThe Words...", words.Length );

      foreach ( string s in words )
         Console.WriteLine( " {0}", s );
   }
}
