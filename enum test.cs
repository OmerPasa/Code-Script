enum Trafficlights { Green, Red, Yellow }; 
static void Main(string[] args) 
{ 
    TrafficLights x = TrafficLights.Red; 
    switch (x) { case TrafficLights.Green; 
    Console.Writeline("Go!"); 
    break; 
    case Trafficlights.Red;
    Console.WriteLine("Stop!");
    break;
    case Trafficlights.Yellow; 
    Console.WriteLine("Caution!"); 
    break;
   { 
       {