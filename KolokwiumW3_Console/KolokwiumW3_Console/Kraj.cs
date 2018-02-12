using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumW3_Console
{
    class Kraj:IComparable<Kraj>
    {
        string nazwa;

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }
        
        int powierzchnia;

        private Kraj(string nazwa, int powierzchnia)
        {
            this.nazwa = nazwa;
            this.powierzchnia = powierzchnia;
        }

        public static Kraj UtworzKraj(string nazwa, int powierzchnia)
        {
            Kraj kraj = new Kraj(nazwa, powierzchnia);
            return kraj;
        }

        public override string ToString()
        {
            return "Kraj: " + nazwa + "," + "powierzchnia: " + powierzchnia;
        }

        public int CompareTo(Kraj other)
        {
            if (this.powierzchnia == other.powierzchnia)
                return other.nazwa.CompareTo(this.nazwa);
            else
                return this.powierzchnia.CompareTo(other.powierzchnia);


        }
    }
}
