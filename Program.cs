using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Ride();
            Bicycle byc1 = new Bicycle();
            byc1.Ride();
            Skateboard skate1 = new Skateboard();
            skate1.Ride();

            List<Car> ListaSamochodow = new List<Car>();
            ListaSamochodow.Add(new Car(1994, "Toyota"));
            ListaSamochodow.Add(new Car(1993, "Nissan"));
            ListaSamochodow.Add(new Car(1991, "Pegeut"));
            ListaSamochodow.Add(new Car(1981, "Ford"));
            ListaSamochodow.Add(new Car(1999, "Volvo"));
            ListaSamochodow.Add(new Car(1991, "Nissan"));
            foreach(var element in ListaSamochodow)
            {
                element.Wypisuje();
            }
            Console.WriteLine("Po sortowaniu");
            ListaSamochodow.Sort();
            foreach(var element in ListaSamochodow)
            {
                element.Wypisuje();
            }

            Console.ReadKey();
        }
    }
}
