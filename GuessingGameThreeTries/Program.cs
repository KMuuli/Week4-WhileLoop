using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis on ta mängu võitunud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            Console.WriteLine("Sul on 3 katset, et numbrit ära arvata");

            while (i < 3)
            {
                string guess = Console.ReadLine();
                int guessedNumber = Convert.ToInt32(guess);

                if(guessedNumber != cpuNumber)
                {
                    Console.WriteLine("Proovi uuesti!");

                    i++;
                }
                else
                    Console.WriteLine("Õige vastus!");
                

            }

            Console.WriteLine("Mäng läbi!");

        }
    }
}
