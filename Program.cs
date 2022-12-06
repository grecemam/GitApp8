using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Практическая__8__тест_на_скорость_печати_
{
    internal class Program
    {
        public static bool TimerOn = true;
        public static statistika result = new statistika();
        static void Main()
        {
            Result.Deserialize();
            Console.WriteLine("Введите свое имя:");
            result.name = Console.ReadLine();
            Testttt();
        }
        static void Testttt()
        {
            Thread thread = new Thread(_ =>
            {
            var dateTime = DateTime.Now;
            DateTime dt = dateTime.AddMinutes(-1);
            {
                while (dateTime > dt)
                {
                    var time = (dateTime - dt).Ticks;
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine(new DateTime(time).ToString("mm:HH:ss"));
                    Thread.Sleep(1000);
                    dt = dt.AddSeconds(1);
                }
                    TimerOn = false;
            }
            });
            thread.Start();
                Test.test();
            Result.res.Add(result);
            Result.result();
            //
        }
    }

}
