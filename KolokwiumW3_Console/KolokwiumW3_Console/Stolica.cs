using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumW3_Console
{
    class Stolica
    {
        string nazwa;
        bool lotnisko;

        public Stolica(string nazwa, bool lotnisko)
        {
            this.nazwa = nazwa;
            this.lotnisko = lotnisko;
        }

        public override string ToString()
        {
            if (lotnisko) return " Stolica: " + nazwa + ", lotnisko: " + "tak";
            else return "Stolica: " + nazwa + ", lotnisko: " + "nie";
        }
    }
}
