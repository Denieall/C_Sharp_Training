using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListofList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>()
            {
                new Vehicle("Proton", new Car(new List<string>() { "Wira", "Waja", "Saga" })),
                new Vehicle("Honda", new Car(new List<string>() { "Jazz", "City", "Civic" }))
            };

            Console.WriteLine(String.Format("Brand: {0}, have Models: {1}, {2}, {3}", vehicles[0].brand, vehicles[0].car.models[0], vehicles[0].car.models[1], vehicles[0].car.models[2]));
        }
    }

    class Vehicle
    {
        public string brand;
        public Car car;

        public Vehicle(String b, Car c)
        {
            brand = b;
            car = c;
        }
    }

    class Car
    {
        public List<String> models;

        public Car(List<String> m)
        {
            models = m;
        }
    }
}
