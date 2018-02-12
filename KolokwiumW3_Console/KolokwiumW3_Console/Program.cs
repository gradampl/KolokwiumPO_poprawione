using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumW3_Console
{
    class Program
    {
        static Azja azja = new Azja();
        static char klawisz;

        static void Main(string[] args)
        {
            Wykonaj();
        }
        
        private static void WczytajKlawisz()
        {
            Console.WriteLine("Co chcesz zrobic?");
            Console.WriteLine("A - dodaj pozycję.");
            Console.WriteLine("B - usuń pozycję.");
            Console.WriteLine("C - pokaż kraje.");
            Console.WriteLine("D - pokaż stolice");
            Console.WriteLine("E - sprawdź.");
            Console.WriteLine("X - zakoncz program.");
            klawisz = Convert.ToChar(Console.ReadLine());
        }

        public static void Wykonaj()
        {
            while(true)
            {
                WczytajKlawisz();

                switch(klawisz)
                {
                    case'A':
                    case 'a': Dodaj(); break;
                    case'B':
                    case 'b': Usun(); break;
                    case'C':
                    case 'c': Console.Write(azja.Kraje()); break;
                    case'D':
                    case 'd': Console.Write(azja.Stolice()); break;
                    case'E':
                    case 'e':Sprawdz(); break;
                    case'X':
                    case 'x': return;

                }
            }
        }

        public static void Dodaj()
        {
            string nazwa,nazwaStolicy,odp;
            int powierzchnia=-1;
            bool lotnisko;
            Console.WriteLine("Podaj nazwę kraju, który ma byc dodany.");
            nazwa = Console.ReadLine();
            Console.WriteLine("Podaj nazwę stolicy kraju, który ma byc dodany.");
            nazwaStolicy = Console.ReadLine();
            Console.WriteLine("Podaj powierzchnię kraju, który ma byc dodany.");
            try { powierzchnia = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.WriteLine("Czy stolica kraju, który ma byc dodany, ma lotnisko? Odpowiedz t, jeśli tak, n - jeśli nie.");
            odp = Console.ReadLine();
            if (odp == "t") lotnisko = true;
            else lotnisko = false;
            azja.Dodaj(nazwa,powierzchnia,nazwaStolicy,lotnisko);
        }

        public static void Usun()
        {
            string nazwa;
            Console.WriteLine("Podaj nazwę panstwa, ktore ma być usuniete.");
            nazwa = Console.ReadLine();
            azja.Usun(nazwa);
        }

        public static void Sprawdz()
        {
            string nazwa;
            Console.WriteLine("Jakie państwo sprawdzić?");
            nazwa = Console.ReadLine();
            azja.Sprawdz(nazwa);
        }
     }
}

