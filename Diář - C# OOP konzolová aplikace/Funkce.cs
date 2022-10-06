using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Diar
{
    class Funkce
    {
        public void FunkceDiare()
        {
            System.IO.Directory.CreateDirectory("log");


            var konec = false;

            

            while (konec == false)
            {
                int pocetZaznamu = Directory.GetFiles("log/", "*", SearchOption.AllDirectories).Length;

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("První záznamy:");
                Console.WriteLine();

                var nalezeneZaznamy = 0;
                for (var i = 0; nalezeneZaznamy < pocetZaznamu; i++)
                {
                    if (pocetZaznamu == 0)
                        break;

                    if (File.Exists("log/" + i + ".txt"))
                    {
                        Console.WriteLine(File.ReadAllText("log/" + i + ".txt"));
                        nalezeneZaznamy++;
                    }

                    if (nalezeneZaznamy == 2)
                        break;


                }


                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(" Vyberte si akci:");
                Console.WriteLine(" 1 - Přidat záznam");
                Console.WriteLine(" 2 - Vyhledat záznam");
                Console.WriteLine(" 3 - Vymazat záznam");
                Console.WriteLine(" 4 - Hádací hra");
                Console.WriteLine(" 5 - Konec");

                var odpoved = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(odpoved, out var odpovedInt))
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------- Prosím zadejte pouze čísla --------------");
                    Console.WriteLine();
                    Console.ReadLine();
                    continue;
                }





                switch (odpovedInt)
                {
                    #region Přidat záznam -- Case 1

                    case 1:
                        Console.WriteLine("Zadejte datum události ve formátu: dd mm yyyy");
                        var zadeneDatum = Console.ReadLine();



                        if (!DateTimeOffset.TryParse(zadeneDatum, out var defalutDate))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("-------------- Prosím zadejte datum ve správném formátu --------------");
                            Console.WriteLine("");
                            Console.ReadLine();
                            continue;
                        }

                        var spravneDatum = defalutDate.Day.ToString() + "." + defalutDate.Month.ToString() + "." + defalutDate.Year.ToString();

                        Console.WriteLine("Zadej událost:");
                        var udalost = Console.ReadLine();

                        var cisloSouboru = 1;

                        while (File.Exists("log/" + cisloSouboru + ".txt"))
                        {
                            cisloSouboru++;
                        }
                        File.WriteAllText("log/" + cisloSouboru + ".txt", cisloSouboru.ToString() + " -- " + spravneDatum + " --- " + udalost);

                        break;

                    #endregion

                    #region Vyhledat záznam -- Case 2
                    case 2:

                        Console.WriteLine(" 1 - Zobrazit všechny záznamy");
                        Console.WriteLine(" 2 - Vyhledat záznamy");
                        var odpovedVyhledani = Console.ReadLine();
                        Console.WriteLine();

                        if (!int.TryParse(odpovedVyhledani, out var odpovedVyhledaniInt))
                        {
                            Console.WriteLine();
                            Console.WriteLine("-------------- Prosím zadejte pouze čísla --------------");
                            Console.WriteLine();
                            Console.ReadLine();
                            continue;
                        }

                        if (odpovedVyhledaniInt == 1)
                        {
                            nalezeneZaznamy = 0;

                            for (int k = 0; nalezeneZaznamy < pocetZaznamu; k++)
                            {
                                if (File.Exists("log/" + k + ".txt"))
                                {
                                    Console.WriteLine(File.ReadAllText("log/" + k + ".txt"));
                                    nalezeneZaznamy++;
                                }


                            }
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Zadejte vyhledávaný záznam:");
                            var vyhledavanyObsah = Console.ReadLine();
                            Console.WriteLine();

                            var nalezenSoubor = false;

                            nalezeneZaznamy = 0;
                            for (int l = 0; nalezeneZaznamy < pocetZaznamu; l++)
                            {
                                if (File.Exists("log/" + l + ".txt"))
                                {
                                    var obsahSouboru = File.ReadAllText("log/" + l + ".txt");
                                    nalezeneZaznamy++;

                                    if (obsahSouboru.Contains(vyhledavanyObsah))
                                    {
                                        Console.WriteLine("-----------------------------------");
                                        Console.WriteLine("Nalezeno---: " + File.ReadAllText("log/" + l + ".txt"));
                                        Console.WriteLine("-----------------------------------");
                                        nalezenSoubor = true;
                                    }


                                }
                            }
                            if (!nalezenSoubor)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" --------------Záznam nebyl nalezen --------------");
                                Console.WriteLine();
                                Console.ReadLine();

                            }
                            Console.ReadLine();
                        }
                        break;

                    #endregion

                    #region Vymazat záznam -- Case 3
                    case 3:
                        Console.WriteLine("Který záznam chcete vymazat?");
                        Console.WriteLine();

                        nalezeneZaznamy = 0;
                        for (int t = 0; nalezeneZaznamy < pocetZaznamu; t++)
                        {
                            if (File.Exists("log/" + t + ".txt"))
                            {
                                Console.WriteLine(File.ReadAllText("log/" + t + ".txt"));
                                nalezeneZaznamy++;
                            }
                        }

                        var vymazOdpoved = Console.ReadLine();

                        if (!int.TryParse(vymazOdpoved, out var vymazOdpovedInt))
                        {
                            Console.WriteLine();
                            Console.WriteLine("-------------- Prosím zadejte pouze čísla --------------");
                            Console.WriteLine();
                            Console.ReadLine();
                            continue;
                        }

                        if (!File.Exists("log/" + vymazOdpoved + ".txt"))
                        {
                            Console.WriteLine("-------------- Záznam neexistuje --------------");
                            Console.ReadLine();
                            continue;

                        }
                            
                        File.Delete("log/" + vymazOdpoved + ".txt");

                        Console.WriteLine("záznam vymazán");
                        Console.ReadLine();

                        break;
                    #endregion

                    #region Hra -- Case 4
                    case 4:
                        var game = new Guessgame();
                        Console.WriteLine($"---------------------------------------------------------------------------------");
                        game.StartHry();
                        Program.UvitaciZprava();
                        break;

                    #endregion


                    case 5:
                        konec = true;
                        break;
                }

            }

        }
    }
}
