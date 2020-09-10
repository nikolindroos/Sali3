using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class Henkilo
    {

        // määritellään kaikkien henkilöiden yhteiset ominaisuudet (kentät)
        protected string etunimi;
        protected string sukunimi;
        protected string katuosoite;
        protected string postinumero;
        protected string postitoimipaikka;
        
        // Olion muodostimet (konstruktorit)

        // Oletusmuodostin
        public Henkilo()
        {
            this.etunimi = "etunimi";
            this.sukunimi = "sukunimi";
            this.katuosoite = "katuosoite";
            this.postinumero = "postinumero";
            this.postitoimipaikka = "postitoimipaikka";
        }

        // Muodostin kaikilla parametreilla
        public Henkilo(string etu, string suku, string katu, string pnro, string paikka)
        {
            this.etunimi = etu;
            this.sukunimi = suku;
            this.katuosoite = katu;
            this.postinumero = pnro;
            this.postitoimipaikka = paikka;
        }
    }
}
