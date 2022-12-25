using System;
using System.Diagnostics;


namespace CountdownTimer
{
    class countdown
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Duration > ");
            int dur = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();
            int countdownDuration = dur;

            if (dur > 100000)
            {
                Console.WriteLine($"{dur} is an unreasonable number.");
                Console.ReadKey();
            }

            stopwatch.Start();

            while (stopwatch.Elapsed.TotalSeconds < countdownDuration)
            {
                int remainingTime = countdownDuration - (int)stopwatch.Elapsed.TotalSeconds;
                Console.Beep(800, 50);
                Console.WriteLine("Time remaining: " + remainingTime + " seconds");

                System.Threading.Thread.Sleep(1000);
            }

            

            Console.WriteLine("Countdown Ended!");
            for (int i = 0; i < 4; i++)
            {
                Console.Beep(1000, 400);
            }
            Console.ReadKey();
                
        }
    }
}
