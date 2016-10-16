using System;

enum TrafficLight
{
   Green,
   Yellow,
   Red
}

class Program
{
   static void Main( string[] args )
   {
      TrafficLight t1 = TrafficLight.Green;
      TrafficLight t2 = TrafficLight.Yellow;
      TrafficLight t3 = TrafficLight.Red;

      Console.WriteLine( "{0},\t{1}",   t1, (int) t1 );
      Console.WriteLine( "{0},\t{1}",   t2, (int) t2 );
      Console.WriteLine( "{0},\t{1}\n", t3, (int) t3 );
   }
}

