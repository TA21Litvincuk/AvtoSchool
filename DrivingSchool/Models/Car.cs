using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrivingSchool.Interfaces;

namespace DrivingSchool.Models
{
    public class Car : IDriveable
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Transmission { get; private set; }

        public Car(string brand, string model, string transmission)
        {
            Brand = brand;
            Model = model;
            Transmission = transmission;
        }

        public void StartEngine()
        {
            Console.WriteLine($"The {Brand} {Model} engine has started.");
        }

        public void Drive()
        {
            Console.WriteLine($"The {Brand} {Model} is driving.");
        }
    }
}
