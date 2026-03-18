using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Versioning;
using System.Security.Claims;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Naidis_csharp
{
    internal class osa5_funktsioonid
    {
        public static void array_naide()
        {
            ArrayList nimed = new ArrayList();
            {
                nimed.Add("Kati");
                nimed.Add("Mati");
                nimed.Add("Juku");


                if (nimed.Contains("Mati"))
                    Console.WriteLine("Mati olemas");

                Console.WriteLine("Nimesid kokku: " + nimed.Count);

                nimed.Insert(1, "Sass");

                Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
                Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

                nimed.Sort();
                foreach (string nimi in nimed)
                    Console.WriteLine(nimi);
            }
        }



        public static void Tuple()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }


        public static void LinkedList()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);
            Console.WriteLine("-----------------------------");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);
            LinkedListNode<int> a = loetelu.Find(5);
            loetelu.AddBefore(a, 11);

            loetelu.AddAfter(a, 22);
            Console.WriteLine("-----------------------------");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);
        }
        public static void sonatlik()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            riigid.ContainsKey(1);
            riigid.ContainsValue("Itaalia");

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            string pealinn = riigid[2];
            riigid[2] = "Eestimaa";
            riigid.Remove(3);

        }




    }



    public class Person
    {
        public string Name { get; set; }


        public Person(string name)
        {
            Name = name;
        }

        public Person()
        {
        }

        public static void sonatlikKlassiga()
        {
            Dictionary<char, Person> inimesed = new Dictionary<char, Person>();
            inimesed.Add('k', new Person() { Name = "Kadi" });
            inimesed.Add('m', new Person() { Name = "Mait" });

            foreach (var entry in inimesed)
                Console.WriteLine($"{entry.Key} - {entry.Value.Name}");
        }
        public static void List_klassiga()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }
        public static void Remove_Listist()
        {
            List<Person> people = new List<Person>();
            people.Remove(new Person() { Name = "Kadi" });

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        public static void Insert_Listisse()
        {
            List<Person> people = new List<Person>();
            people.Insert(1, new Person() { Name = "Kadi" });
            people.Remove(new Person() { Name = "Mirje" });
            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }
        public static void kustuta_objekt()
        {

            List<Person> people = new List<Person>();

            foreach (Person p in people)
                Console.WriteLine(p.Name);
            Person p1 = new Person() { Name = "Kadi" };
            people.Add(p1);

            Console.WriteLine($"Person 1 index on: {people.FindIndex(p => p.Name == "Kadi")}");
            people.Remove(p1);
            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }
        public static void remove_objekt2()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            people.Remove(new Person("Lisa"));
        }
        public static void remove_lamda_abil()
        {
            List<Person> people = new List<Person>();
            Person p1 = new Person() { Name = "Kadi" };
            people.Add(p1);
            int i = people.FindIndex(p => p.Name == "Kadi");
            people.RemoveAt(i);
            Console.WriteLine($"Person kustutanud on: {i}; {p1.Name}");
        }

        public static void list_sort_ja_remove()
        {
            List<string> people = new List<string>() { "Kadi", "Anna" };
            people.Sort();

            foreach (string p in people)
                Console.WriteLine(p);
            int nimi1 = people.BinarySearch("Kadi");
            Console.WriteLine(nimi1);

            Console.WriteLine("Sisesta nimi: ");
            string nimi = Console.ReadLine();
            people.Remove(nimi);
            foreach (string p in people)
                Console.WriteLine(p);

            //people.Sort((a, b) => a.Length.CompareTo(b.Length));
            //foreach (string p in people)
            //    Console.WriteLine(p);
        }



        


    }
}









    // OSA 5 ÜLESANDED

    public class Toode
    {
        static string Nimi { get; set; }
        static string Kalorid100g { get; set; }

        public Toode(string name, string kalorid100g)
        {
            Nimi = name;
            Kalorid100g = kalorid100g;
        }



    }
        public class Inimene
        {
            static string Nimi { get; set; }
            static int Vanus { get; set; }
            static string Sugu { get; set; }
            static double Pikkus { get; set; }
            static double Kaal { get; set; }
            static double Aktiivsustase { get; set; }

                public Inimene(string nimi, int vanus, string sugu, double pikkus, double kaal, double aktiivsustase)
                {
                    Nimi = nimi;
                    Vanus = vanus;
                    Sugu = sugu;
                    Pikkus = pikkus;
                    Kaal = kaal;
                    Aktiivsustase = aktiivsustase;
                }
                  

}



public class ulesanded
{
    public static void Toidu_salvestamine_faili()
    {
        try
        {
            string retseptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tooded.txt");



            if (File.Exists(retseptPath))
            {
                Console.WriteLine("Olemasolevad toidud");
                foreach (string rida in File.ReadAllLines(retseptPath))
                    Console.WriteLine($"  - {rida}");
                Console.WriteLine();
            }





           
            ConsoleKeyInfo key;
            do
            {
                Console.Write("Sisesta uus toidu nimi: ");
                string toit = Console.ReadLine();
                using (StreamWriter retseptWriter = new StreamWriter(retseptPath, true))
                {
                        Console.Write("sisesta kaal:  ");
                        string kaal = Console.ReadLine();
             
                        retseptWriter.Write($"{toit};{kaal}");
                        retseptWriter.Close();
                }


                if (!string.IsNullOrWhiteSpace(toit))
                {

                    Console.WriteLine($"{toit} lisatud!");
                }
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Backspace);


            Console.WriteLine(" Kõik salvestatud!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Viga: {e.Message}");
        }
    }

    public static void KaalKalkulaator()
    {
        List<string> list = new List<string>();
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tooded.txt");
            foreach (string rida in File.ReadAllLines(path))
                list.Add(rida);
        }
        catch (Exception)
        {
            Console.WriteLine("Viga faili lugemisel!");
        }

        foreach (string rida in list)
            Console.WriteLine(rida);

        double kaal = 0;
        if ()
        {

        }

    }
}
    





