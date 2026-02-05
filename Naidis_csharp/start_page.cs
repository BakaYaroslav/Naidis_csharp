using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    public class start_page
    {
        public static void Main(string[] args)
        {
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("1. Osa ´Anmdetüübid");
                string text = "Tere tulemast c#-i mailmaa!";
                Console.WriteLine($"Oli loodud muutuja tekst,mis võrdub: {text}");
                Console.Write("mis on sinu nimi: ");
                string nimi = Console.ReadLine();
                Console.WriteLine("kui vana sa oled?: ");
                
                try
                {
                    int vanus = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Tere {nimi}, sa oled {vanus}, aastat vana");

                    Console.Write("arv1: ");
                    float a = float.Parse(Console.ReadLine());
                    Console.Write("arv2: ");
                    float b = float.Parse(Console.ReadLine());
                    float vastus = Naidis_funktsioon.Summa(a, b);
                    Console.WriteLine($"{a} + {b} = {vastus}");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }

               


            }

        }
    }
}

