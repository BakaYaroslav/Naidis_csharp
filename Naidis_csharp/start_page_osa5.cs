using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    internal class start_page_osa5
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("        OSA 5 – FUNKTSIOONID        ");
            Console.WriteLine("====================================");
            Console.WriteLine();

            Console.WriteLine("Vali tegevus:");
            Console.WriteLine("1  - Array näide");
            Console.WriteLine("2  - Tuple näide");
            Console.WriteLine("3  - List klassiga");
            Console.WriteLine("4  - LinkedList");
            Console.WriteLine("5  - Sõnastik (Dictionary)");
            Console.WriteLine("6  - Toidu salvestamine faili");
            Console.WriteLine("7  - Kaalukalkulaator");
            Console.WriteLine("8  - Maakonnad ja pealinnad");
            Console.WriteLine("9  - Õpilased");
            Console.WriteLine("10 - Tekstist arvud");
            Console.WriteLine("11 - Lemmikloomade register");
            Console.WriteLine("12 - Valuuta kalkulaator");
            Console.WriteLine("13 - FilmideKogu");

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
                    ulesanded.KaalKalkulaator(Inimene_osa5.GetInimene());
                    break;
                case "8":
                    ulesanded.Maakonnad_pealinnad();
                    break;
                case "9":
                    ulesanded.opilased();
                    break;
                case "10":
                    ulesanded.Tekstist_arvud();
                    break;

                case "11":
                    ulesanded.Lemmikloomade_register();
                    break;

                case "12":
                    ulesanded.ValuteCalculator();
                    break;
                case "13":
                    ulesanded.FilmideKogu();
                    break;

                default:
                    Console.WriteLine("Valik puudub");
                    break;
            }
        }
    }
}

