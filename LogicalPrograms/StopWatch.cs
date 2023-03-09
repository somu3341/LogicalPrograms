using System;
using System.Security.Cryptography.X509Certificates;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public void Run()
        {                        
           const string Start = "start", Stop = "stop";
           Console.WriteLine("Enter start to run the stop watch");
           string start= Console.ReadLine();
           TimeSpan timeSpan = TimeSpan.Zero;
            {
                 int hour1 = timeSpan.Hours;
                  int min1 = timeSpan.Minutes;
                 int sec1 = timeSpan.Seconds;
                 int milli1 = timeSpan.Milliseconds;
                  Console.WriteLine("Enter stop to end the stop watch");
                  string stop= Console.ReadLine();
                  if (stop.Equals(stop))
                  {
                    int hour2= timeSpan.Hours;
                    int min2= timeSpan.Minutes;
                    int sec2= timeSpan.Seconds;
                    int milli2= timeSpan.Milliseconds;
                    Console.WriteLine("stop watch time "+(hour2 - hour1)+" "+(min2-min1)+" "+(sec2-sec1)+" "+(milli2-milli1));
                  }                       
            }                             
        }
    }
}
