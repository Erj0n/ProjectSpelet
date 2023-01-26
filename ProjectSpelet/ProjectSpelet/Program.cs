using System;
using System.ComponentModel.DataAnnotations;

namespace TärningSpel
{

    class Program
    {

        static void Main(string[] args)
        {
            // här i int spalterna deklarera vi intsen
            int spelareNum;
            int fiendeNum;

            int spelarensPoäng = 0;
            int fiendensPoäng = 0;

            Random random = new Random();


            // Skapar en for loop för att kunna få igång spelet och kunna slå tärningen 10 gånger
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Klicka enter för att snurra tärningen!");

                Console.ReadKey();

                spelareNum = random.Next(1, 16);
                Console.WriteLine(" Du slog en " + spelareNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                fiendeNum = random.Next(1, 16);
                Console.WriteLine(" Fienden slog träning " + fiendeNum);

                // sedan skapar vi en if statement där en av spelarna som får högst nummer vinner rundan eller om slaget är lika så blir rundan oavgjort
                if (spelareNum > fiendeNum)
                {
                    spelarensPoäng++;
                    Console.WriteLine("Spelaren vinner denna rundan!");
                }
                else if (spelareNum < fiendeNum)
                {
                    fiendensPoäng++;
                    Console.WriteLine("Fienden vinner denna rundan!");
                }
                else
                {
                    Console.WriteLine("Denna rundan blev lika! ");
                }

                // Visar resultatet på vem som leder spelet.
                Console.WriteLine("Poängen är nu - Spelare : " + spelarensPoäng + ". Fiende : " + fiendensPoäng + ".");
                Console.WriteLine();
            }

            // Resultat på vem som har vunnit hela spelet eller om det har bilvit oavgjort.
            if (spelarensPoäng > fiendensPoäng)
            {
                Console.WriteLine("Du är vinnaren!!!");
            }
            else if (spelarensPoäng < fiendensPoäng)
            {
                Console.WriteLine("Du har förlorat :(");
            }
            else
            {
                Console.WriteLine("Det blev lika");
            }

            Console.ReadKey();
        }
    }
}

//skapare Erjon Merovci!
