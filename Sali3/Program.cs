using System;
using System.Globalization;

namespace Sali3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan Henkilo-olion luontia");

            // Testataan oletusmuodostin

            Henkilo henkilo = new Henkilo();

            //testataan muodostin kaikilla parametreillä

            Henkilo henkilo1 = new Henkilo("Niko", "Lindroos", "Kaerlantie 8", "21320", "Turku");


            //katsotaan olion ominaisuuksia
            Console.WriteLine("Testi oletusmuodostimelle");
            henkilo.naytaHenkilo();

            Console.WriteLine("Testi muodostimelle kaikilla parametreillä");
            henkilo1.naytaHenkilo();
        }
    }
}
