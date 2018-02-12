using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumW3_Console
{
    class Azja:IOperacje
    {
        string nazwa, nazwaStolicy;
        Stolica stolica;
        Kraj panstwo;
        int powierzchnia;
        bool lotnisko;
        SortedDictionary<Kraj, Stolica> panstwa = new SortedDictionary<Kraj, Stolica>();

        public void Dodaj(string nazwa, int powierzchnia, string nazwaStolicy, bool lotnisko)
        {
            this.nazwa = nazwa;
            this.powierzchnia = powierzchnia;
            this.nazwaStolicy = nazwaStolicy;
            this.lotnisko = lotnisko;
            panstwo = Kraj.UtworzKraj(nazwa, powierzchnia);
            stolica = new Stolica(nazwaStolicy, lotnisko);
            panstwa.Add(panstwo, stolica);

        }

        public void Usun()
        {
            try
            {
                panstwa.Remove(panstwa.First().Key);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Usun(string nazwa)
        {
            this.nazwa = nazwa;
            foreach (var i in panstwa)
            {
                if (i.Key.Nazwa == nazwa) panstwa.Remove(i.Key); break;
            }
        }

        public string Kraje()
        {
            string opis = "Wszystkie panstwa:" + Environment.NewLine;
            foreach (var i in panstwa)
            {
                opis += i.Key.ToString() + i.Value.ToString() + Environment.NewLine;
            }
            return opis;

        }

        public string Stolice()
        {
            string napis = "Stolice panstw:" + Environment.NewLine;
            foreach (var i in panstwa.Values)
            {
                napis += i.ToString() + Environment.NewLine;
            }
            return napis;
        }

        public bool Sprawdz(string nazwa)
        {

            this.nazwa = nazwa;
            foreach (var i in panstwa)
            {
                if (i.Key.Nazwa == nazwa) return true;
            }
            return false;
        }
    }
}
