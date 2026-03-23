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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
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

