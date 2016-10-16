using System;

// Uncomment the following line for the second run of the program and notice the difference in the output.
//[Flags]
enum CardDeckSettings : uint
{
   SingleDeck    = 0x01,   // bit 0
   LargePictures = 0x02,   // bit 1
   FancyNumbers  = 0x04,   // bit 2
   Animation     = 0x08    // bit 3
}
class Program
{
   static void Main()
   {
      CardDeckSettings ops;

      // Set one flag.
      ops = CardDeckSettings.FancyNumbers; 
      Console.WriteLine( ops.ToString() );

      // Set two bit flags.
      ops = CardDeckSettings.FancyNumbers | CardDeckSettings.Animation;
      Console.WriteLine( ops.ToString() );                                 // Print what?
   }
}
