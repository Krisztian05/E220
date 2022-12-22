using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CsevegesGUI
{
    internal class Beszelgetes
    {
        public DateTime Kezdet { get; set; }
        public DateTime Veg { get; set; }
        public string Kezdemenyezo { get; set; }
        public string Fogado { get; set; }

        public Beszelgetes(DateTime kezdet, DateTime veg, string kezdemenyezo, string fogado)
        {
            Kezdet = kezdet;
            Veg = veg;
            Kezdemenyezo = kezdemenyezo;
            Fogado = fogado;
        }

        public static void Inicializalas(string fajl, List<Beszelgetes> lista)
        {
            StreamReader sr = new(fajl);
            _ = sr;
            while (!sr.EndOfStream)
            {
                string Sor = sr.ReadLine();
                string[] Tulajdonsagok = Sor.Split(';');
                try
                {
                    DateTime kezdet = DateTime.ParseExact(Tulajdonsagok[0], "yy.MM.dd-HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
                    DateTime veg = DateTime.ParseExact(Tulajdonsagok[1], "yy.MM.dd-HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
                    string kezdemenyezo = Tulajdonsagok[2];
                    string fogado = Tulajdonsagok[3];
                    lista.Add(new Beszelgetes(kezdet, veg, kezdemenyezo, fogado));
                }
                catch (Exception)
                {
                    //Console.WriteLine("Hibás sor kezelve");
                }
            }
        }
    }
}
