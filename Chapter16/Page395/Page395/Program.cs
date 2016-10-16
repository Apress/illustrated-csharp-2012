using System;

class Program
{
   static void Main()
   {
      ushort sh = 10;
      byte sb = (byte) sh;
      Console.WriteLine
           ( "sb:  {0} = 0x{0:X}", sb );

      sh = 1365;
      sb = (byte) sh;
      Console.WriteLine
           ( "sb:  {0} = 0x{0:X}", sb );
   }
}
