using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_5
{
    class Car:Vehicle,IRideable,IComparable<Car>
    {
        private int Rok;
        private string Marka;
        public Car() { }
        public Car(int Rok, string Marka)
        {
            this.Rok = Rok;
            this.Marka = Marka;
        }
        public void Ride()
        {
            Console.WriteLine("Jade samochodem");
        }
        public void Wypisuje()
        {
            Console.WriteLine("Marka : " + Marka);
            Console.WriteLine("Rok produkcji : "+Rok);
        }
        public int CompareTo(Car other)
        {
            if (this.Rok == other.Rok)
            {
                return this.Marka.CompareTo(other.Marka);
            }
            else
                return this.Rok.CompareTo(other.Rok);
        }
    }
}
