using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diar
{
    internal class Guessgame
    {
        //počítadlo hádání
        int guessCount = 0;

        public void StartHry()
        {
            //Vytvoří objekt k přístupu k metodám
            var program = new Guessgame();

            //Zavolá metodu na první uvítání
            SayHelloToConsole();

            //Načte správné číslo do promněné 
            var spravnaOdpoved = program.GuessTheNumber();

            //Zavolá Konečnou zprávu se správným číslem
            program.KonecHry(spravnaOdpoved);

        }

        /// <summary>
        /// Úvítací zpráva
        /// </summary>
        static void SayHelloToConsole()
        {
            //vypíše uvítání
            Console.WriteLine("Zdravím, vítejte v mé hádací hře!");
            Console.WriteLine("Myslím na číslo mezi 1-100");
        }

        /// <summary>
        /// Smyčka hádání správného čísla
        /// </summary>
        /// <param name="spravneCislo"></param>
        /// <returns></returns>
        public int GuessTheNumber()
        {

            //vytvoří náhodné číslo mezi 1-100
            var randomNumber = new Random().Next(0, 101);

            //definice základního čísla uživatele
            var userGuess = 0;


            //smyčka dotázání na číslo a porovnání s náhodným
            //jesliže se hádané číslo nerovná s náhodným
            while (userGuess != randomNumber)
            {

                //přičte počet hádání
                guessCount++;


                Console.WriteLine("Víte které číslo to je?");
                //získání číslo
                var odpoved = Console.ReadLine();

                if (odpoved == "cheat")
                {
                    Console.WriteLine($"Psst....hádané číslo je {randomNumber}");
                    continue;
                }

                if (odpoved == "zmena")
                {
                    randomNumber = new Random().Next(0, 101);
                    Console.WriteLine("Číslo bylo změněno");
                    continue;
                }

                //jestliže uživatel zadal číslo
                if (int.TryParse(odpoved, out var prevedeno))
                {
                    userGuess = prevedeno;

                    //jesliže je náhodné číslo je stejné jako hádané
                    if (userGuess == randomNumber)
                    {
                        break;
                    }
                    //jinak jestliže číslo je větší nebo menší
                    else
                    {
                        Console.WriteLine($"Číslo na které myslím je {(userGuess > randomNumber ? "menší" : "větší")} než hádané");
                    }

                    #region delší možnost zápisu IF ELSE
                    /*
                    if (userGuess > randomNumber)
                    {
                        Console.WriteLine("číslo na které myslím je menší než hádané");
                    }

                    //jesliže je náhodné číslo větší
                    else if (userGuess < randomNumber)
                    {
                        Console.WriteLine("číslo na které myslím je větší než hádané");
                    }
                    */
                    #endregion

                }

                //jinak upozorní aby se zadávali jen čísla
                else
                {
                    Console.WriteLine("Zadejte prosím jen čísla");
                }

            }


            //navrátí správné číslo

            return userGuess;
        }




        /// <summary>
        /// Konec hry se zprávou
        /// </summary>
        /// <param name="spravneCislo"></param>
        public void KonecHry(int spravneCislo)
        {
            Console.WriteLine($"--------------------------------------------");
            Console.WriteLine($"Gratuluji, spravné číslo je {spravneCislo}");
            Console.WriteLine($"--------------------------------------------");
            Console.WriteLine($"A zabralo vám to {guessCount} hádání");
            Console.WriteLine($"---------------------------------------------------------------------------------");
            Console.ReadLine();
        }


    }


}
