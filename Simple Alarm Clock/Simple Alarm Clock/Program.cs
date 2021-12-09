using System;
using System.Diagnostics;
using System.Threading;

namespace MyFirstLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Tuuur o'rningdaaan";
            int scheduleHour = DateTime.Now.Hour, scheduleMin = DateTime.Now.Minute;

            Thread budilnik = new Thread(() =>
            {
                while (true)
                {
                    int hour = DateTime.Now.Hour;
                    int min = DateTime.Now.Minute;
                   
                    if (hour == scheduleHour && min == scheduleMin)
                    {
                        ProcessStartInfo info = new ProcessStartInfo();
                        info.FileName = @"d:\nasheed.mp3";
                        info.UseShellExecute = true;
                        Process.Start(info);
                        Console.WriteLine(msg);
                        break;
                    }
                }
            });

            budilnik.Start();
            
        
        }
    }
}