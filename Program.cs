using System;
using System.Timers;
using Timer = System.Timers.Timer;

namespace counter
{
    class Program
    {

        static int minutesRest =30;

        static void Main(string[] args)
        {


            Timer timer = new Timer(60000);
            timer.AutoReset = true;



            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_elapsed);

            timer.Start();
            Console.WriteLine("Contador iniciado.");
            Console.ReadLine();
        }

        private static void timer_elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            minutesRest--;
            Console.WriteLine($"Quedan {minutesRest} minutos");

            if(minutesRest==0){
                Console.WriteLine("Tomate la pastilla");
                ((Timer)sender).Stop();
            }
        }
    }
}