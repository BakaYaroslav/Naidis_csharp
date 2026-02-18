using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    internal class osa3
    {
        public static int[] GenereeriRuudud(int min, int max)
        {
            Random rnd = new Random();
           

            int N = rnd.Next(min, max);
            int M = rnd.Next(min, max);

            int start = Math.Min(N, M);
            int end = Math.Max(N, M);
            Console.WriteLine($"{start}, {end}, {end - start + 1}");
            int[] masiiv = new int[end - start+1];
            for (int i = start; i <= end; i++)
            {
                masiiv[i-start] = i * i;
            }
            return masiiv;
        }
        public static Tuple<double,double,double> arvuAnaluus(double[] arvud)
        {
            double sum = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;

            foreach (double arv in arvud)
            {
               
                korrutis *= arv;

            }
            string tulemus = string.Join(", ", arvud);
            Console.WriteLine($"Sa sisetatud: {tulemus}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Korrutis: {korrutis}");
            Console.WriteLine($"Keskmine: {keskmine}");
            return Tuple.Create(sum, keskmine, korrutis);


        }


        public static void ostsElevantAra()
        {
            string vastus = "";
            do
            {
                Console.WriteLine("Osts elevant ära");
                vastus = Console.ReadLine().ToLower();

            } while (vastus != "jah");

            while (true)
            {
                Console.WriteLine("Osts elevant ära");
                vastus = Console.ReadLine().ToLower();
                if (vastus == "jah")
                {
                    Console.WriteLine("Oled ostnud elevandi!");
                    break;
                }
                else
                {
                    Console.WriteLine("Kõik nii rakivad, aga Osts elevant ära");
                }

            }



        }

        public static void arvumang()
        {
            Random rnd = new Random();
            int arv = rnd.Next(1, 101);
            int katse = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Arva ära number 1-100: ");
                int arva = int.Parse(Console.ReadLine());
                katse++;
                if (arva > arv)
                {
                    Console.WriteLine("Sinu number on väiksem");
                }
                else if (arva < arv)
                {
                    Console.WriteLine("Sinu number on suurem");
                }
                else
                {
                    Console.WriteLine($"Õige! Arvasid ära {katse} katsel.");
                    break;
                }
            }

        }

        public static void SuurimNeliarv()
        {
            Console.WriteLine("Sisesta neli arvu:");

            double[] arvud = new double[4];
            for (int i = 0; i < arvud.Length; i++)
            {
             
                Console.Write($"Sisesta {i + 1}. arv: ");
                int arvu = int.Parse(Console.ReadLine());


                foreach (double arv in arvud)
                {
                    string tulemus = string.Join(", ", arvud);
                }
            }
        }
    }
}
    

