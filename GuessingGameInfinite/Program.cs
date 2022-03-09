using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis on ta mängu võitunud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühte korda.

            bool isCorrectGuess = false;
            Random rnd = new Random();

            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            Console.WriteLine("Tere tulemast numbri äraarvamise mängu");
            Console.WriteLine("Number 1 kuni 10ni genereeritakse");
            Console.WriteLine("Kui sa arvad õige numbri ära, oled võitnud!");

            while (!isCorrectGuess)
            {
                Console.WriteLine("Paku oma vastus.");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess > cpuNumber)
                {
                    Console.WriteLine("Sinu vastus on liiga kõrge");
                }
                else if(guess < cpuNumber)
                {
                    Console.WriteLine("Sinu vastus on liiga madal");
                }
                else
                {
                    i++;
                    Console.WriteLine("Õige");
                    isCorrectGuess = true;
                }
            }


        }
    }
}
