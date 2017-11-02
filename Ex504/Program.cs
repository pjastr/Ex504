using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex504
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList pracownicy = new ArrayList();
            pracownicy.Add(new Pracownik("Jan", 3000));
            pracownicy.Add(new Pracownik("Anna", 2500));
            pracownicy.Add(new Pracownik("Jan", 3200));
            pracownicy.Add(new Pracownik("Zofia", 4100));
            pracownicy.Add(new Pracownik("Barbara", 4100));
            pracownicy.Sort();
            foreach (var element in pracownicy)
            {
                Console.WriteLine(element.ToString());
            }
            Console.ReadKey();
        }
    }
}
