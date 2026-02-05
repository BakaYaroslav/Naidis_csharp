using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    internal class osa2
    {
        public static string Juku(string nimi = "Juku")
        {
            int vanus = 0;
            string vastus = "";
            string pilet = "";
            string ostus = "";

            Console.WriteLine("sisesta oma nimi");
            nimi = Console.ReadLine();
            if (nimi.ToLower() == "juku") {
                Console.WriteLine("Lähme kinno!");

                while (true) {
                        try
                        {
                            Console.WriteLine("sisesta oma vanus");
                            vanus = int.Parse(Console.ReadLine());
                        if (vanus > 0 && vanus < 100)

                        {
                            if (vanus < 6)
                            {

                                pilet = "sulle on kinopilet on tasuta!";
                                break;
                            }
                            else if (vanus >= 6 && vanus <= 14)
                            {
                                pilet = "sulle on kinopilet on lastepilet!";
                                break;
                            }
                            else if (vanus >= 15 && vanus <= 65)
                            {
                                pilet = "sulle on kinopilet on täispilet!";
                                break;
                            }
                            else
                            {
                                pilet = "sulle on kinopilet on sooduspilet!";
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("vanus peab olema positiivne arv ja kui < 100");
                        }
                    }


                    catch { Console.WriteLine("palun sisesta korrektne vanus"); }

                } 
            }
            else
            {
                Console.WriteLine("ma olen võivatud"); 
            }
            Console.WriteLine(pilet); 
            return vastus;
        }
        }
}
