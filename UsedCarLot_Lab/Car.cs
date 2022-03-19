using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot_Lab
{
    public class Car 
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //no arguments Constructor
        //public Car()
        //{
        //    this.Make = "Toyota";
        //    this.Model = "Camry";
        //    this.Year = 2015;
        //    this.Price = 85000;
        //}

        public Car()
        {

        }

        //Constructor to initialize the object in the class
        public Car(string make, string model, int year, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}";
        }
    }

 
}
