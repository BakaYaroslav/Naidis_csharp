using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    internal class start_page_osa5
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("osa5 funktsioonid");
         
            string valik = Console.ReadLine();
            switch (valik)
            {

                case "1":
                    osa5_funktsioonid.array_naide();
                    break;
                case "2":
                    osa5_funktsioonid.Tuple();
                    break;
                case "3":
                    Person.List_klassiga();
                    break;
                case "4":
                    osa5_funktsioonid.LinkedList();
                    break;
                case "5":
                    osa5_funktsioonid.sonatlik();
                    break;
                case "6":
                    ulesanded.Toidu_salvestamine_faili();
                    break;
                case "7":
                    while (true)
                        try
                    {
                        Console.Write("Sisesta oma nimi: ");
                        string nimi = Console.ReadLine();

                        Console.Write("Sisesta vanus: ");
                        int vanus = int.Parse(Console.ReadLine());
                            if (vanus < 0 && vanus > 100) 
                                {
                                Console.WriteLine("Vanus peab olema vahemikus 0-100");
                                continue;
                                }

                        Console.Write("Sisesta sugu (mees/naine): ");
                        string sugu = Console.ReadLine().ToLower();
                            if (sugu != "mees" && sugu != "naine")
                            {
                                Console.WriteLine("Sugu peab olema 'mees' või 'naine'");
                                continue;
                            }

                            Console.Write("Sisesta pikkus (cm): ");
                        double pikkus = double.Parse(Console.ReadLine());
                            if (pikkus < 50 || pikkus > 250)
                            {
                                Console.WriteLine("Pikkus peab olema vahemikus 50-250 cm");
                                continue;
                            }

                            Console.Write("Sisesta kaal (kg): ");
                        double kaal = double.Parse(Console.ReadLine());
                            if (kaal < 20 || kaal > 300)
                            {
                                Console.WriteLine("Kaal peab olema vahemikus 20-300 kg");
                                continue;
                            }

                            Console.Write("Sisesta aktiivsustase (1-5): ");
                           
                        int aktiivsustase =int.Parse(Console.ReadLine());
                            if (aktiivsustase < 1 || aktiivsustase > 5)
                            {
                                Console.WriteLine("Aktiivsustase peab olema vahemikus 1-5");
                                continue;
                            }
                            Inimene_osa5 kasutaja = new Inimene_osa5(nimi, vanus, sugu, pikkus, kaal, aktiivsustase);
                        ulesanded.KaalKalkulaator(kasutaja);
                        break;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Vale andmed");
                    }
                  

                   
                    break;

                default:
                    Console.WriteLine("Valik puudub");
                    break;

                case "8":
                    ulesanded.Maakonnad_pealinnad();
                    break;

            }
        }
	}

}

