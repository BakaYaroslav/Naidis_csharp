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
                default:
                    Console.WriteLine("Valik puudub");
                    break;

            }
        }
	}

}

