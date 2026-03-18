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
                    Console.Write("Sisesta oma nimi: ");
                    string nimi = Console.ReadLine();

                    Console.Write("Sisesta vanus: ");
                    int vanus = int.Parse(Console.ReadLine());

                    Console.Write("Sisesta sugu (mees/naine): ");
                    string sugu = Console.ReadLine().ToLower();

                    Console.Write("Sisesta pikkus (cm): ");
                    double pikkus = double.Parse(Console.ReadLine());

                    Console.Write("Sisesta kaal (kg): ");
                    double kaal = double.Parse(Console.ReadLine());

                    Inimene kasutaja = new Inimene(nimi, vanus, sugu, pikkus, kaal, aktiivsustase);
                    ulesanded.KaalKalkulaator(kasutaja);
                    break;
                default:
                    Console.WriteLine("Valik puudub");
                    break;

            }
        }
	}

}

