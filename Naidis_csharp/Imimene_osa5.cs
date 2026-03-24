using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    public class Inimene_osa5
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; }
        public double Pikkus { get; set; }
        public double Kaal { get; set; }
        public int Aktiivsustase { get; set; }

        public Inimene_osa5(string nimi, int vanus, string sugu, double pikkus, double kaal, int aktiivsustase)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Pikkus = pikkus;
            Kaal = kaal;
            Aktiivsustase = aktiivsustase;
        }
    }
}

public class opilane
{
  

    public string Nimi { get; set; }
    public List<int>  Hinded { get; set; }


    public opilane(string? nimi, List<int> hinded)
    {
        Nimi = nimi;
        Hinded = hinded;
    }
}

public class Lemmikloom
{
    public string Nimi { get; set; }
    public string Liik { get; set; }
    public int Vanus { get; set; }
}



