using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot_Lab
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }

        //Constructor

        public UsedCar(string make, string model, int year, decimal price, double mileage) : base (make, model, year, price)
        {
           this.Mileage = mileage;
        }

        //ToString Override
        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}, Mileage: {Mileage}";
        }
    }
}
