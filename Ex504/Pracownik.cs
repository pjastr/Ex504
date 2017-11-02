using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex504
{
    class Pracownik : IComparable
    {
        private int wynagrodzenie;
        private string imie;

        public int CompareTo(Object obj)
        {
            Pracownik other = obj as Pracownik;  //traktowanie obj jak pracownika
            if (this.wynagrodzenie == other.wynagrodzenie)
            {
                return this.imie.CompareTo(other.imie);
            }
            return other.wynagrodzenie.CompareTo(this.wynagrodzenie);
        }

        public Pracownik(string imie, int wynagrodzenie) //konstruktor
        {
            this.imie = imie;
            this.wynagrodzenie = wynagrodzenie;
        }

        public override string ToString() //przesłonięcie metody
        {
            return this.imie + " " + this.wynagrodzenie;
        }

    }
}
