using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumW3_Console
{
    interface IOperacje:ISprawdzanie
    {
        void Dodaj(string nazwa, int powierzchnia, string nazwaStolicy, bool lotnisko);
        void Usun();
        void Usun(string p1);
    }
}
